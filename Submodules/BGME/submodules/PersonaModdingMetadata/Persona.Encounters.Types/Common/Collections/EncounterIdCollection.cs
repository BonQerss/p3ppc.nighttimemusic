namespace Persona.Encounters.Types.Common.Collections;

internal class EncounterIdCollection<TEncounter> : IEncounterFilter<TEncounter>
    where TEncounter : IEncounter
{
    private readonly int[] ids;

    public EncounterIdCollection(int[] ids)
    {
        this.ids = ids;
    }

    public EncounterIdCollection(int id)
        : this(new int[] { id })
    {
    }

    public bool Match(TEncounter encounter)
        => ids.Contains(encounter.Id);
}
