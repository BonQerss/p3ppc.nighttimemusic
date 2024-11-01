using PersonaModdingMetadata.Shared.Games;

namespace Persona.Encounters.Types.Common;

internal class EncounterFactory : IEncounterFactory<IEncounter>
{
    public IEncounter Create(Game game, int id, BinaryReader br)
    {
        return game switch
        {
            Game.P4G_PC => new P4G.Encounter(id, br),
            Game.P5R_PC => new P5R.Encounter(id, br),
            Game.P3P_PC => new P3P.Encounter(id, br),
            Game.P3R_PC => new P3R.Encounter(id, br),
            _ => throw new Exception("Unknown game.")
        };
    }
}
