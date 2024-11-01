namespace Persona.Encounters.Types.Common.Collections;

public class PredicateCollection<TEncounter> : IEncounterFilter<TEncounter>
{
    private readonly Func<TEncounter, bool> predicate;

    public PredicateCollection(Func<TEncounter, bool> predicate)
        => this.predicate = predicate;

    public bool Match(TEncounter encounter)
        => this.predicate(encounter);
}
