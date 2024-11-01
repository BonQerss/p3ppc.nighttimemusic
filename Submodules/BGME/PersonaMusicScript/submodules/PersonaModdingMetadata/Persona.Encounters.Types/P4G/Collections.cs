using Persona.Encounters.Types.Common.Collections;
using BattleUnitCollection = Persona.Encounters.Types.Common.Collections.BattleUnitCollection<Persona.Encounters.Types.P4G.Encounter, Persona.Encounters.Types.P4G.BattleUnit>;

namespace Persona.Encounters.Types.P4G;

public class Collections : GameCollections<Encounter>
{
    private readonly BattleUnit[] shadowBosses = new BattleUnit[]
    {
        BattleUnit.ShadowYosuke,
        BattleUnit.ShadowChie,
        BattleUnit.ShadowYukiko,
        BattleUnit.ShadowKanji,
        BattleUnit.ShadowRise,
        BattleUnit.ShadowTeddie,
        BattleUnit.ShadowNaoto,
        BattleUnit.ShadowMitsuo
    };

    private readonly BattleUnit[] goldenHands = new BattleUnit[]
    {
        BattleUnit.OpulentHand,
        BattleUnit.LuxuryHand,
        BattleUnit.HappinessHand,
        BattleUnit.WealthHand,
        BattleUnit.SupremeHand,
        BattleUnit.GloriousHand,
        BattleUnit.IsolatedHand,
        BattleUnit.TreasureHand,
    };

    private readonly BattleUnit[] reapers = new BattleUnit[]
    {
        BattleUnit.TheReaper288,
        BattleUnit.TheReaper289,
        BattleUnit.TheReaper290,
        BattleUnit.TheReaper291,
        BattleUnit.TheReaper292,
        BattleUnit.TheReaper293,
        BattleUnit.TheReaper294,
        BattleUnit.TheReaper295,
        BattleUnit.TheReaper296,
        BattleUnit.TheReaper297,
    };

    private readonly int[] miniBossesIds = new int[]
    {
        811,
        812,
        813,
        814,
        815,
        816,
        817,
        818,
        819,
        820,
        938,
        939,
    };

    private readonly int[] optionalBossesIds = new int[]
    {
        526,
        527,
        528,
        529,
        530,
        531,
    };

    public Collections()
    {
        this["bosses/Shadow Yosuke"] = new BattleUnitCollection(BattleUnit.ShadowYosuke);
        this["bosses/Shadow Chie"] = new BattleUnitCollection(BattleUnit.ShadowChie);
        this["bosses/Shadow Yukiko"] = new BattleUnitCollection(BattleUnit.ShadowYukiko);
        this["bosses/Shadow Kanji"] = new BattleUnitCollection(BattleUnit.ShadowKanji);
        this["bosses/Shadow Rise"] = new BattleUnitCollection(BattleUnit.ShadowRise);
        this["bosses/Shadow Teddie"] = new BattleUnitCollection(BattleUnit.ShadowTeddie);
        this["bosses/Shadow Mitsuo"] = new BattleUnitCollection(BattleUnit.ShadowMitsuo);
        this["bosses/Shadow Naoto"] = new BattleUnitCollection(BattleUnit.ShadowNaoto);
        this["bosses/Kunino-Sagiri"] = new BattleUnitCollection(BattleUnit.Kuninosagiri);
        this["bosses/Adachi"] = new BattleUnitCollection(BattleUnit.Adachi);
        this["bosses/Ameno-sagiri"] = new BattleUnitCollection(BattleUnit.Amenosagiri);
        this["bosses/Izanami"] = new BattleUnitCollection(BattleUnit.Izanami);
        this["bosses/Izanami-no-Okami"] = new BattleUnitCollection(BattleUnit.IzanaminoOkami);
        this["bosses/Marie"] = new BattleUnitCollection(BattleUnit.Marie);
        this["bosses/Kusumi-no-Okami"] = new BattleUnitCollection(BattleUnit.KusuminoOkami);
        this["bosses/Margaret"] = new BattleUnitCollection(BattleUnit.Margaret);
        this["bosses/Spooky Fog Man"] = new BattleUnitCollection(BattleUnit.QuestionMark275);
        this["bosses/The Reaper"] = new BattleUnitCollection(this.reapers);
        this["Shadow Bosses"] = new BattleUnitCollection(this.shadowBosses);
        this["Golden Hands"] = new BattleUnitCollection(this.goldenHands);
        this["Optional Bosses"] = new EncounterIdCollection<Encounter>(this.optionalBossesIds);
        this["Minibosses"] = new EncounterIdCollection<Encounter>(this.miniBossesIds);
        this["Special Battles"] = new SpecialBattlesCollection<Encounter>();

        // Backwards compatability.
        this["bosses/Namatame"] = new BattleUnitCollection(BattleUnit.Kuninosagiri);
        this["Reapers"] = new BattleUnitCollection(this.reapers);
    }
}
