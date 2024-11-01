namespace Persona.Encounters.Types.Common.Collections;

/// <summary>
/// Collection that checks if an encounter contains a specific battle unit(s).
/// </summary>
internal class BattleUnitCollection<TEncounter, TEnemy> : IEncounterFilter<TEncounter>
    where TEncounter : IEncounter
    where TEnemy : Enum
{
    private readonly ushort[] units;
    private readonly bool includesAll;

    /// <summary>
    /// Battle units collection.
    /// </summary>
    /// <param name="units">Units to match for in encounters.</param>
    /// <param name="includesAll">Whether an encounter needs to include all units.</param>
    public BattleUnitCollection(TEnemy[] units, bool includesAll = false)
    {
        this.units = units.Select(x => (ushort)(object)x).ToArray();
        this.includesAll = includesAll;
    }

    public BattleUnitCollection(TEnemy unit)
        : this(new TEnemy[] { unit })
    {
    }

    public bool Match(TEncounter encounter)
    {
        if (this.includesAll)
        {
            // Match enemies by location if all battle units
            // defined.
            if (this.units.Length == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (encounter.BattleUnitsIds[i] != this.units[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            else if (this.units.All(unit => encounter.BattleUnitsIds.Any(x => x == unit)))
            {
                return true;
            }

            return false;
        }
        else
        {
            return encounter.BattleUnitsIds.Any(x => units.Contains(x));
        }
    }
}
