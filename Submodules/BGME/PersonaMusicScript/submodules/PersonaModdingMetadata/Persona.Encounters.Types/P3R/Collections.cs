using Persona.Encounters.Types.Common.Collections;
using BattleUnitCollection = Persona.Encounters.Types.Common.Collections.BattleUnitCollection<Persona.Encounters.Types.P3R.Encounter, Persona.Encounters.Types.P3R.BattleUnit>;

namespace Persona.Encounters.Types.P3R;

public class Collections : GameCollections<Encounter>
{
    private readonly BattleUnit[] elizabeth = new BattleUnit[]
    {
        BattleUnit.Elizabeth,
        BattleUnit.Elizabeth2,
        BattleUnit.Elizabeth3,
        BattleUnit.Elizabeth4,
        BattleUnit.Elizabeth5,
        BattleUnit.Elizabeth6,
        BattleUnit.Elizabeth7,
        BattleUnit.Elizabeth8,
        BattleUnit.Elizabeth9,
        BattleUnit.Elizabeth10,
    };

    private readonly BattleUnit[] strega = new BattleUnit[]
    {
        BattleUnit.Chidori,
        BattleUnit.Jin,
        BattleUnit.Jin2,
        BattleUnit.Takaya,
        BattleUnit.Takaya2,
        BattleUnit.Takaya3,
    };

    private readonly BattleUnit[] fullmoon = new BattleUnit[]
    {
        BattleUnit.Priestess,
        BattleUnit.Emperor,
        BattleUnit.Emperor2,
        BattleUnit.Emperor3,
        BattleUnit.Emperor4,
        BattleUnit.Empress,
        BattleUnit.Empress2,
        BattleUnit.Empress3,
        BattleUnit.Hierophant,
        BattleUnit.Lovers,
        BattleUnit.Chariot,
        BattleUnit.Justice,
        BattleUnit.ShadowoftheAbyss,
        BattleUnit.Hermit,
        BattleUnit.Fortune,
        BattleUnit.Strength,
        BattleUnit.HangedMan,
    };

    public Collections()
    {
        this["Special Battles"] = new SpecialBattlesCollection<Encounter>();

        this["bosses/Chidori"] = new BattleUnitCollection(BattleUnit.Chidori);
        this["bosses/Elizabeth"] = new BattleUnitCollection(this.elizabeth);
        this["bosses/Jin"] = new BattleUnitCollection(BattleUnit.Jin2);
        this["bosses/Nyx Avatar"] = new EncounterIdCollection<Encounter>(709);
        this["bosses/Nyx"] = new EncounterIdCollection<Encounter>(710);
        this["bosses/Takaya and Jin"] = new EncounterIdCollection<Encounter>(715);
        this["bosses/Takaya"] = new EncounterIdCollection<Encounter>(718);
        this["bosses/The Reaper"] = new BattleUnitCollection(BattleUnit.TheReaper);
        this["Strega"] = new BattleUnitCollection(this.strega);

        this["Full Moon Bosses"] = new BattleUnitCollection(this.fullmoon);
        this["Minibosses"] = new PredicateCollection<Encounter>(encounter => encounter.Music == Music.MasterOfTartarus);
    }
}
