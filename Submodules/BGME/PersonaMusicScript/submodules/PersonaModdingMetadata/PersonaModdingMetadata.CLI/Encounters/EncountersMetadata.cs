using Persona.Encounters.Types.Common;
using Persona.Encounters.Types.Common.Collections;
using PersonaModdingMetadata.CLI.Common;
using PersonaModdingMetadata.Shared.Games;
using PersonaModdingMetadata.Shared.Serializers;
using Serilog;

namespace PersonaModdingMetadata.CLI.Encounters;

internal class EncountersMetadata : IMetadata
{
    private readonly string baseDir;

    public EncountersMetadata(string solutionDir)
    {
        this.baseDir = Path.Join(solutionDir, "Persona.Encounters.Metadata"); ;
    }

    public void Generate()
    {
        this.GenerateGame(Game.P4G_PC);
        this.GenerateGame(Game.P5R_PC);
        this.GenerateGame(Game.P3P_PC);
        this.GenerateGame(Game.P3R_PC);
    }

    private void GenerateGame(Game game)
    {
        var originalDir = game.OriginalFilesDir(this.baseDir);
        Directory.CreateDirectory(originalDir);

        var encountFile = Path.Join(originalDir, "ENCOUNT.TBL");
        if (!File.Exists(encountFile))
        {
            Log.Warning("Missing: {file}", encountFile);
            return;
        }

        switch (game)
        {
            case Game.P4G_PC:
                this.Generate_P4G(encountFile);
                break;
            case Game.P5R_PC:
                this.Generate_P5R(encountFile);
                break;
            case Game.P3P_PC:
                this.Generate_P3P(encountFile);
                break;
            case Game.P3R_PC:
                this.Generate_P3R(encountFile);
                break;
            default:
                break;
        }
    }

    private void Generate_P4G(string file)
    {
        Log.Information("Persona 4 Golden");
        var encounterTbl = new Persona.Encounters.Types.P4G.EncounterTbl(file);
        var collectionsDir = Path.Join(encounterTbl.Game.GameFolder(this.baseDir), "collections");
        var collections = new Persona.Encounters.Types.P4G.Collections();

        this.FixLocationCollections(encounterTbl);
        GenerateCollections(collectionsDir, encounterTbl.Encounters, collections);
    }

    private void Generate_P5R(string file)
    {
        Log.Information("Persona 5 Royal");
        var encounterTbl = new Persona.Encounters.Types.P5R.EncounterTbl(file);
        var collectionsDir = Path.Join(encounterTbl.Game.GameFolder(this.baseDir), "collections");
        var collections = new Persona.Encounters.Types.P5R.Collections();
        this.FixLocationCollections(encounterTbl);
        GenerateCollections(collectionsDir, encounterTbl.Encounters, collections);
    }

    private void Generate_P3P(string file)
    {
        Log.Information("Persona 3 Portable");
        var encounterTbl = new Persona.Encounters.Types.P3P.EncounterTbl(file);
        var collectionsDir = Path.Join(encounterTbl.Game.GameFolder(this.baseDir), "collections");
        var collections = new Persona.Encounters.Types.P3P.Collections();

        GenerateCollections(collectionsDir, encounterTbl.Encounters, collections);
    }

    private void Generate_P3R(string file)
    {
        Log.Information("Persona 3 Reload");
        var encounterTbl = new Persona.Encounters.Types.P3R.EncounterTbl(file);
        var collectionsDir = Path.Join(encounterTbl.Game.GameFolder(this.baseDir), "collections");
        var collections = new Persona.Encounters.Types.P3R.Collections();

        GenerateCollections(collectionsDir, encounterTbl.Encounters, collections);
    }

    private static void GenerateCollections<TEncounter>(
        string outputDir,
        IEnumerable<TEncounter> encounters,
        GameCollections<TEncounter> collections)
        where TEncounter : IEncounter
    {
        foreach (var collection in collections)
        {
            var name = collection.Key;
            var filter = collection.Value;

            var collectionEncounters = encounters.Where(filter.Match).ToArray();
            if (collectionEncounters.Length < 1)
            {
                Log.Warning("No encounters matched collection {name}. Skipping...", name);
                continue;
            }

            var outputFile = Path.Join(outputDir, $"{name}.enc");
            CollectionSerializer.Serialize(outputFile, FormatEncounters(collectionEncounters.OfType<IEncounter>()));

            Log.Logger.CreatedFile(outputFile, "Created collection: {name}", name);
        }
    }

    private void FixLocationCollections<TEncounter>(BaseEncounterTbl<TEncounter> encounterTbl)
        where TEncounter : IEncounter
    {
        var locationsDir = Path.Join(encounterTbl.Game.OriginalFilesDir(this.baseDir), "collections", "locations");
        if (!Directory.Exists(locationsDir))
        {
            Log.Debug("Missing: {dir}", locationsDir);
            return;
        }

        var specialBattlesCollection = new SpecialBattlesCollection<TEncounter>();
        var specialBattles = encounterTbl.Encounters.Where(specialBattlesCollection.Match).ToArray();

        foreach (var file in Directory.EnumerateFiles(locationsDir, "*.enc", SearchOption.AllDirectories))
        {
            var relativePath = Path.GetRelativePath(encounterTbl.Game.OriginalFilesDir(this.baseDir), file);
            var outputFile = Path.Join(encounterTbl.Game.GameFolder(this.baseDir), relativePath);
            //if (File.Exists(outputFile))
            //{
            //    Log.Debug("Location collection already exists. Delete existing collection to regenerate.");
            //    continue;
            //}

            Log.Information("Fixing Location Collection: {name}", Path.GetFileNameWithoutExtension(file));

            var collection = CollectionSerializer.DeserializeFile(file);
            var fixedEncounters = collection
                .Where(x =>
                {
                    if (specialBattles.Any(battle => battle.Id == x))
                    {
                        Log.Debug("Removed encounter: {id}", x);
                        return false;
                    }

                    return true;
                })
                .Select(x => encounterTbl.Encounters[x])
                .ToArray();

            CollectionSerializer.Serialize(outputFile, FormatEncounters(fixedEncounters.OfType<IEncounter>()));

            Log.Logger.CreatedFile(outputFile, "Fixed Location Collection: {name}", Path.GetFileNameWithoutExtension(file));
        }
    }

    private static string[] FormatEncounters(IEnumerable<IEncounter> encounters)
        => encounters.Select(x => $"// {x.Name}\n{x.Id}\n").ToArray();
}
