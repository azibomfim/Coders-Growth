sap.ui.define([
    "sap/ui/core/library",
    "sap/ui/core/format/DateFormat"
], function () {
    "use strict";

        const ENUM_1 = 1;
        const ENUM_2 = 2;
        const ENUM_3 = 3;
        const ENUM_4 = 4;
        const ENUM_5 = 5;
        const ENUM_6 = 6;
        const ENUM_7 = 7;
        const ENUM_8 = 8;
        const ENUM_9 = 9;
        const ENUM_10 = 10;
        const ENUM_11 = 11;
        const ENUM_12 = 12;
        const ENUM_13 = 13;
        const ENUM_14 = 14;
        const ENUM_15 = 15;
        const ENUM_16 = 16;
        const ENUM_17 = 17;
        const ENUM_18 = 18;
        const ENUM_19 = 19;
        const ENUM_20 = 20;
        const ENUM_21 = 21;
        const ENUM_22 = 22;
        const ENUM_23 = 23;
        const ENUM_24 = 24;
        const ENUM_25 = 25;
        const ENUM_26 = 26;
        const ENUM_27 = 27;
        const ENUM_28 = 28;
        const ENUM_29 = 29;
        const ENUM_30 = 30;
        const ENUM_31 = 31;
        const ENUM_32 = 32;
        const ENUM_33 = 33;
        const ENUM_34 = 34;
        const ENUM_35 = 35;
        const ENUM_36 = 36;
        const ENUM_37 = 37;
        const ENUM_38 = 38;
        const ENUM_39 = 39;
        const ENUM_40 = 40;
        const ENUM_41 = 41;
        const ENUM_42 = 42;
        const ENUM_43 = 43;
        const ENUM_44 = 44;
        const ENUM_45 = 45;
        const ENUM_46 = 46;
        const ENUM_47 = 47;
        const ENUM_48 = 48;
        const ENUM_49 = 49;
        const ENUM_50 = 50;
        const ENUM_51 = 51;
        const ENUM_52 = 52;
        const ENUM_53 = 53;
        const ENUM_54 = 54;
        const ENUM_55 = 55;
        const ENUM_56 = 56;
        const ENUM_57 = 57;
        const ENUM_58 = 58;
        const ENUM_59 = 59;
        const ENUM_60 = 60;
        const ENUM_61 = 61;
        const ENUM_62 = 62;
        const ENUM_63 = 63;
        const ENUM_64 = 64;
        const ENUM_65 = 65;
        const ENUM_66 = 66;
        const ENUM_67 = 67;
        const ENUM_68 = 68;
        const ENUM_69 = 69;
        const ENUM_70 = 70;
        const ENUM_71 = 71;
        const ENUM_72 = 72;
        const ENUM_73 = 73;
        const ENUM_74 = 74;
        const ENUM_75 = 75;
        const ENUM_76 = 76;
        const ENUM_77 = 77;
        const ENUM_78 = 78;
        const ENUM_79 = 79;
        const ENUM_80 = 80;
        const ENUM_81 = 81;
        const ENUM_82 = 82;
        const ENUM_83 = 83;
        const ENUM_84 = 84;
        const ENUM_85 = 85;
        const ENUM_86 = 86;
        const ENUM_87 = 87;
        const ENUM_88 = 88;
        const ENUM_89 = 89;
        const ENUM_90 = 90;

        const Albedo = "Albedo";
        const Alhaitham = "Alhaitham";
        const Aloy = "Aloy";
        const Amber = "Amber";
        const Arlecchino = "Arlecchino";
        const Ayaka = "Ayaka";
        const Ayato = "Ayato";
        const Baizhu = "Baizhu";
        const Barbara = "Barbara";
        const Beidou = "Beidou";
        const Bennett = "Bennett";
        const Candace = "Candace";
        const Charlotte = "Charlotte";
        const Chevreuse = "Chevreuse";
        const Chiori = "Chiori";
        const Chongyun = "Chongyun";
        const Clorinde = "Clorinde";
        const Collei = "Collei";
        const Cyno = "Cyno";
        const Dehya = "Dehya";
        const Diluc = "Diluc";
        const Diona = "Diona";
        const Dori = "Dori";
        const Eula = "Eula";
        const Faruzan = "Faruzan";
        const Fischl = "Fischl";
        const Freminet = "Freminet";
        const Furina = "Furina";
        const Gaming = "Gaming";
        const Ganyu = "Ganyu";
        const Gorou = "Gorou";
        const Heizou = "Heizou";
        const HuTao = "HuTao";
        const Itto = "Itto";
        const Jean = "Jean";
        const Kazuha = "Kazuha";
        const Kaeya = "Kaeya";
        const Kaveh = "Kaveh";
        const Keqing = "Keqing";
        const Kirara = "Kirara";
        const Klee = "Klee";
        const Kokomi = "Kokomi";
        const Layla = "Layla";
        const Lisa = "Lisa";
        const Lynette = "Lynette";
        const Lyney = "Lyney";
        const Mika = "Mika";
        const Mona = "Mona";
        const Nahida = "Nahida";
        const Navia = "Navia";
        const Neuvillette = "Neuvillette";
        const Nilou = "Nilou";
        const Ningguang = "Ningguang";
        const Noelle = "Noelle";
        const Qiqi = "Qiqi";
        const Raiden = "Raiden";
        const Razor = "Razor";
        const Rosaria = "Rosaria";
        const Sara = "Sara";
        const Sayu = "Sayu";
        const Sethos = "Sethos";
        const Shenhe = "Shenhe";
        const Shinobu = "Shinobu";
        const Sigewinne = "Sigewinne";
        const Sucrose = "Sucrose";
        const Tartaglia = "Tartaglia";
        const Thoma = "Thoma";
        const Tighnari = "Tighnari";
        const Traveler = "Traveler";
        const TravelerAnemo = "TravelerAnemo";
        const TravelerCryo = "TravelerCryo";
        const TravelerDendro = "TravelerDendro";
        const TravelerElectro = "TravelerElectro";
        const TravelerGeo = "TravelerGeo";
        const TravelerHydro = "TravelerHydro";
        const TravelerPyro = "TravelerPyro";
        const Venti = "Venti";
        const Wanderer = "Wanderer";
        const Wriothesley = "Wriothesley";
        const Xiangling = "Xiangling";
        const Xiao = "Xiao";
        const Xingqiu = "Xingqiu";
        const Xinyan = "Xinyan";
        const Yae = "Yae";
        const Yanfei = "Yanfei";
        const Yaoyao = "Yaoyao";
        const Yelan = "Yelan";
        const Yoimiya = "Yoimiya";
        const YunJin = "YunJin";
        const Zhongli = "Zhongli";

        const Anemo = "Anemo";
        const Cryo = "Cryo";
        const Dendro = "Dendro";
        const Electro = "Electro";
        const Geo = "Geo";
        const Hydro = "Hydro";
        const Pyro = "Pyro";

        const Espada = "Espada";
        const Espadao = "Espadao";
        const Catalisador = "Catalisador";
        const Arco = "Arco";
        const Lanca = "Lanca";


    return {
        formatarEnumNome(valorInteiroDoEnumNome){
            switch (valorInteiroDoEnumNome){
                case ENUM_1:
                    return Albedo;
                case ENUM_2:
                    return Alhaitham;
                case ENUM_3:
                    return Aloy;
                case ENUM_4:
                    return Amber;
                case ENUM_5:
                    return Arlecchino;
                case ENUM_6:
                    return Ayaka;
                case ENUM_7:
                    return Ayato;
                case ENUM_8:
                    return Baizhu;
                case ENUM_9:
                    return Barbara;
                case ENUM_10:
                    return Beidou;
                case ENUM_11:
                    return Bennett;
                case ENUM_12:
                    return Candace;
                case ENUM_13:
                    return Charlotte;
                case ENUM_14:
                    return Chevreuse;
                case ENUM_15:
                    return Chiori;
                case ENUM_16:
                    return Chongyun;
                case ENUM_17:
                    return Clorinde;
                case ENUM_18:
                    return Collei;
                case ENUM_19:
                    return Cyno;
                case ENUM_20:
                    return Dehya;
                case ENUM_21:
                    return Diluc;
                case ENUM_22:
                    return Diona;
                case ENUM_23:
                    return Dori;
                case ENUM_24:
                    return Eula;
                case ENUM_25:
                    return Faruzan;
                case ENUM_26:
                    return Fischl;
                case ENUM_27:
                    return Freminet;
                case ENUM_28:
                    return Furina;
                case ENUM_29:
                    return Gaming;
                case ENUM_30:
                    return Ganyu;
                case ENUM_31:
                    return Gorou;
                case ENUM_32:
                    return Heizou;
                case ENUM_33:
                    return HuTao;
                case ENUM_34:
                    return Itto;
                case ENUM_35:
                    return Jean;
                case ENUM_36:
                    return Kazuha;
                case ENUM_37:
                    return Kaeya;
                case ENUM_38:
                    return Kaveh;
                case ENUM_39:
                    return Keqing;
                case ENUM_40:
                    return Kirara;
                case ENUM_41:
                    return Klee;
                case ENUM_42:
                    return Kokomi;
                case ENUM_43:
                    return Layla;
                case ENUM_44:
                    return Lisa;
                case ENUM_45:
                    return Lynette;
                case ENUM_46:
                    return Lyney;
                case ENUM_47:
                    return Mika;
                case ENUM_48:
                    return Mona;
                case ENUM_49:
                    return Nahida;
                case ENUM_50:
                    return Navia;
                case ENUM_51:
                    return Neuvillette;
                case ENUM_52:
                    return Nilou;
                case ENUM_53:
                    return Ningguang;
                case ENUM_54:
                    return Noelle;
                case ENUM_55:
                    return Qiqi;
                case ENUM_56:
                    return Raiden;
                case ENUM_57:
                    return Razor;
                case ENUM_58:
                    return Rosaria;
                case ENUM_59:
                    return Sara;
                case ENUM_60:
                    return Sayu;
                case ENUM_61:
                    return Sethos;
                case ENUM_62:
                    return Shenhe;
                case ENUM_63:
                    return Shinobu;
                case ENUM_64:
                    return Sigewinne;
                case ENUM_65:
                    return Sucrose;
                case ENUM_66:
                    return Tartaglia;
                case ENUM_67:
                    return Thoma;
                case ENUM_68:
                    return Tighnari;
                case ENUM_69:
                    return Traveler;
                case ENUM_70:
                    return TravelerAnemo;
                case ENUM_71:
                    return TravelerCryo;
                case ENUM_72:
                    return TravelerDendro;
                case ENUM_73:
                    return TravelerElectro;
                case ENUM_74:
                    return TravelerGeo;
                case ENUM_75:
                    return TravelerHydro;
                case ENUM_76:
                    return TravelerPyro;
                case ENUM_77:
                    return Venti;
                case ENUM_78:
                    return Wanderer;
                case ENUM_79:
                    return Wriothesley;
                case ENUM_80:
                    return Xiangling;
                case ENUM_81:
                    return Xiao;
                case ENUM_82:
                    return Xingqiu;
                case ENUM_83:
                    return Xinyan;
                case ENUM_84:
                    return Yae;
                case ENUM_85:
                    return Yanfei;
                case ENUM_86:
                    return Yaoyao;
                case ENUM_87:
                    return Yelan;
                case ENUM_88:
                    return Yoimiya;
                case ENUM_89:
                    return YunJin;
                case ENUM_90:
                    return Zhongli;
            }},

            formatarEnumElemento(valorInteiroDoEnumElemento){
                switch (valorInteiroDoEnumElemento){
                    case ENUM_1:
                        return Anemo;
                    case ENUM_2:
                        return Cryo;
                    case ENUM_3:
                        return Dendro;
                    case ENUM_4:
                        return Electro;
                    case ENUM_5:
                        return Geo;
                    case ENUM_6:
                        return Hydro;
                    case ENUM_7:
                        return Pyro;
        }},

        formatarEnumArma(valorInteiroDoEnumArma){
            switch (valorInteiroDoEnumArma){
                case ENUM_1:
                    return Espada;
                case ENUM_2:
                    return Espadao;
                case ENUM_3:
                    return Candace;
                case ENUM_4:
                    return Arco;
                case ENUM_5:
                    return Lanca;
    }},
}
});