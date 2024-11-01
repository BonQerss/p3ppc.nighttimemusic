using PersonaModdingMetadata.Shared.Games;

namespace Persona.Encounters.Types.Common;

public interface IEncounterFactory<TEncounter>
{
    TEncounter Create(Game game, int id, BinaryReader br);
}
