namespace Persona.Encounters.Types.Common;

public interface IEncounterFilter<TEncounter>
{
    bool Match(TEncounter encounter);
}
