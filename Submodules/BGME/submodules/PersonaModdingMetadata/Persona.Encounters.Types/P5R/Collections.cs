using Persona.Encounters.Types.Common.Collections;
using BattleUnitCollection = Persona.Encounters.Types.Common.Collections.BattleUnitCollection<Persona.Encounters.Types.P5R.Encounter, Persona.Encounters.Types.P5R.BattleUnit>;

namespace Persona.Encounters.Types.P5R;

public class Collections : GameCollections<Encounter>
{
    private readonly BattleUnit[] akechi = new BattleUnit[]
    {
        BattleUnit.GoroAkechi,
        BattleUnit.GoroAkechi2,
        BattleUnit.GoroAkechi3,
        BattleUnit.GoroAkechi4,
    };

    private readonly BattleUnit[] kamoshida = new BattleUnit[]
    {
        BattleUnit.SuguruAsmodeusKamoshida,
        BattleUnit.SuguruAsmodeusKamoshida2,
    };

    private readonly BattleUnit[] kaneshiro = new BattleUnit[]
    {
        BattleUnit.JunyaBaelKaneshiro,
        BattleUnit.JunyaBaelKaneshiro2,
    };

    private readonly BattleUnit[] madarame = new BattleUnit[]
    {
        BattleUnit.IchiryusaiAzazelMadarame,
        BattleUnit.IchiryusaiAzazelMadarame2,
    };

    private readonly BattleUnit[] maruki = new BattleUnit[]
    {
        BattleUnit.Maruki,
        BattleUnit.Maruki2,
        BattleUnit.Maruki3,
        BattleUnit.Maruki4,
        BattleUnit.Maruki5,
        BattleUnit.MarukiSecondHalf,
    };

    private readonly BattleUnit[] sae = new BattleUnit[]
    {
        BattleUnit.ShadowSae,
        BattleUnit.ShadowSae2,
        BattleUnit.SaeLeviathanNiijima,
    };

    private readonly BattleUnit[] shido = new BattleUnit[]
    {
        BattleUnit.MasayoshiSamaelShido,
        BattleUnit.MasayoshiSamaelShido2,
        BattleUnit.TrueMasayoshiSamaelShido,
        BattleUnit.TrueMasayoshiSamaelShido2,
    };

    private readonly int[] awakenings = new int[]
    {
        642,
        648,
        651,
        663,
        843,
        669,
        855,
        658,
    };

    public Collections()
    {
        this["Special Battles"] = new SpecialBattlesCollection<Encounter>();

        // Bosses.
        this["bosses/Kamoshida"] = new BattleUnitCollection(this.kamoshida);
        this["bosses/Madarame"] = new BattleUnitCollection(this.madarame);
        this["bosses/Kaneshiro"] = new BattleUnitCollection(this.kaneshiro);
        this["bosses/Wakaba Phase 1"] = new BattleUnitCollection(BattleUnit.CognitiveWakabaIsshiki);
        this["bosses/Wakaba Phase 2"] = new BattleUnitCollection(BattleUnit.CognitiveWakabaIsshiki2);
        this["bosses/Sae Phase 1"] = new BattleUnitCollection(BattleUnit.ShadowSae);
        this["bosses/Sae Phase 2"] = new BattleUnitCollection(BattleUnit.ShadowSae2);
        this["bosses/Akechi Phase 1"] = new BattleUnitCollection(BattleUnit.GoroAkechi);
        this["bosses/Akechi Phase 2"] = new BattleUnitCollection(BattleUnit.GoroAkechi3);
        this["bosses/GoroAkechi2"] = new BattleUnitCollection(BattleUnit.GoroAkechi2);
        this["bosses/Akechi Confidant Battle"] = new BattleUnitCollection(BattleUnit.GoroAkechi4);
        this["bosses/Shido Phase 1"] = new BattleUnitCollection(BattleUnit.BeastofHumanSacrifice);
        this["bosses/Shido Phase 2"] = new BattleUnitCollection(new BattleUnit[] { BattleUnit.MasayoshiSamaelShido, BattleUnit.MasayoshiSamaelShido2 });
        this["bosses/Shido Phase 3"] = new BattleUnitCollection(new BattleUnit[] { BattleUnit.TrueMasayoshiSamaelShido, BattleUnit.TrueMasayoshiSamaelShido2 });
        this["bosses/Holy Grail Phase 1"] = new EncounterIdCollection<Encounter>(786);
        this["bosses/Holy Grail Phase 2"] = new EncounterIdCollection<Encounter>(787);
        this["bosses/Treasure of Mementos"] = new BattleUnitCollection(BattleUnit.TreasureofMementos);
        this["bosses/Caroline and Justine Story Battle"] = new EncounterIdCollection<Encounter>(791);
        this["bosses/Yaldabaoth Phase 1"] = new EncounterIdCollection<Encounter>(785);
        this["bosses/Yaldabaoth Phase 2"] = new EncounterIdCollection<Encounter>(788);

        // Royal battles.
        this["bosses/Sumire"] = new BattleUnitCollection(BattleUnit.Sumire);
        this["bosses/Maruki and Kasumi Phase 1"] = new EncounterIdCollection<Encounter>(853);
        this["bosses/Maruki and Kasumi Phase 2"] = new EncounterIdCollection<Encounter>(854);
        this["bosses/Maruki Phase 1"] = new EncounterIdCollection<Encounter>(856);
        this["bosses/Maruki Phase 2"] = new EncounterIdCollection<Encounter>(857);
        this["bosses/Maruki Phase 3"] = new EncounterIdCollection<Encounter>(871);
        this["bosses/Maruki Ending Fight"] = new EncounterIdCollection<Encounter>(858);
        this["bosses/Maruki Fisticuffs"] = new EncounterIdCollection<Encounter>(858);

        // Unique/challenge battles.
        this["bosses/The Reaper"] = new BattleUnitCollection(BattleUnit.TheReaper);
        this["bosses/Caroline and Justine"] = new EncounterIdCollection<Encounter>(790);
        this["bosses/Lavenza"] = new BattleUnitCollection(BattleUnit.Lavenza);
        this["bosses/Jose"] = new BattleUnitCollection(BattleUnit.Jose);

        // Awakenings
        this["Awakenings"] = new EncounterIdCollection<Encounter>(this.awakenings);
        this["awakenings/Awakening Ren"] = new EncounterIdCollection<Encounter>(642);
        this["awakenings/Awakening Ryuji"] = new EncounterIdCollection<Encounter>(648);
        this["awakenings/Awakening Ann"] = new EncounterIdCollection<Encounter>(651);
        this["awakenings/Awakening Makoto"] = new EncounterIdCollection<Encounter>(663);
        this["awakenings/Awakening Futaba"] = new EncounterIdCollection<Encounter>(843);
        this["awakenings/Awakening Haru"] = new EncounterIdCollection<Encounter>(669);
        this["awakenings/Awakening Sumire"] = new EncounterIdCollection<Encounter>(855);
        this["awakenings/Awakening Yusuke"] = new EncounterIdCollection<Encounter>(658);

        // Backwards compatability.
        this["bosses/Wakaba"] = new BattleUnitCollection(new BattleUnit[] { BattleUnit.CognitiveWakabaIsshiki, BattleUnit.CognitiveWakabaIsshiki2 });
        this["bosses/Shido"] = new BattleUnitCollection(this.shido);
        this["bosses/Sae"] = new BattleUnitCollection(this.sae);
        this["bosses/Kasumi"] = new BattleUnitCollection(BattleUnit.Kasumi2);
        this["bosses/Yaldabaoth"] = new BattleUnitCollection(BattleUnit.GodofControlYaldabaoth);
        this["bosses/Akechi"] = new BattleUnitCollection(this.akechi);
        this["bosses/Maruiki"] = new BattleUnitCollection(this.maruki);
        this["bosses/Holy Grail"] = new EncounterIdCollection<Encounter>(new int[] { 786, 787 });
    }
}
