using Persona.Encounters.Types.Common.Collections;
using BattleUnitCollection = Persona.Encounters.Types.Common.Collections.BattleUnitCollection<Persona.Encounters.Types.P3P.Encounter, Persona.Encounters.Types.P3P.BattleUnit>;

namespace Persona.Encounters.Types.P3P;

public class Collections : GameCollections<Encounter>
{
    private readonly BattleUnit[] velvetRoom = new BattleUnit[]
    {
        BattleUnit.EnemyElizabeth294,
        BattleUnit.EnemyTheodore298,
        BattleUnit.EnemyMargaret299,
    };

    private readonly BattleUnit[] strega = new BattleUnit[]
    {
        BattleUnit.EnemyChidori264,
        BattleUnit.EnemyJin268,
        BattleUnit.EnemyJin271,
        BattleUnit.EnemyTakaya267,
        BattleUnit.EnemyTakaya272,
    };

    public Collections()
    {
        this["Special Battles"] = new SpecialBattlesCollection<Encounter>();

        this["bosses/Chidori"] = new BattleUnitCollection(BattleUnit.EnemyChidori264);
        this["bosses/Elizabeth"] = new BattleUnitCollection(BattleUnit.EnemyElizabeth294);
        this["bosses/Jin"] = new BattleUnitCollection(BattleUnit.EnemyJin271);
        this["bosses/Nyx Avatar"] = new EncounterIdCollection<Encounter>(428);
        this["bosses/Nyx"] = new BattleUnitCollection(BattleUnit.EnemyNyx274);
        this["bosses/Takaya and Jin"] = new BattleUnitCollection(new BattleUnit[] { BattleUnit.EnemyTakaya267, BattleUnit.EnemyJin268 }, true);
        this["bosses/Takaya"] = new BattleUnitCollection(BattleUnit.EnemyTakaya272);
        this["bosses/The Reaper"] = new BattleUnitCollection(BattleUnit.EnemyTheReaper193);
        this["bosses/Theodore"] = new BattleUnitCollection(BattleUnit.EnemyTheodore298);
        this["bosses/Margaret"] = new BattleUnitCollection(BattleUnit.EnemyMargaret299);
        this["Velvet Room"] = new BattleUnitCollection(this.velvetRoom);
        this["Strega"] = new BattleUnitCollection(this.strega);

        this["Full Moon Bosses"] = new PredicateCollection<Encounter>(encounter => encounter.MusicId == 2);
        this["Minibosses"] = new PredicateCollection<Encounter>(encounter => encounter.MusicId == 6);

        // Backwards compatability.
        this["Velvet Room Attendants"] = new BattleUnitCollection(this.velvetRoom);
    }
}
