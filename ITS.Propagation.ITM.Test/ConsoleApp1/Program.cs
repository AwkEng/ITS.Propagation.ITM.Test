using ITS.Propagation;

var elevationProfile = new double[]
{
        101,
        1000,
        925.0175954346166,
        714.2022923116966,
        606.0331005220214,
        645.2770435506263,
        862.8407724546482,
        641.9299118323328,
        535.0525761329701,
        533.0152216915587,
        557.2723488455349,
        709.6182126575213,
        624.5815366161407,
        578.1194510928127,
        537.7687138810415,
        543.3000194154276,
        492.3138656286398,
        474.0966560239421,
        484.9599629661665,
        523.7151695021371,
        518.3270180734249,
        562.5460418075862,
        667.9576855405902,
        712.5242153862413,
        686.5338542432387,
        639.2856932991158,
        727.9311494361866,
        871.8972086311601,
        931.2980979705496,
        751.2974998511559,
        651.5859856820553,
        601.7058393049228,
        780.2954812300331,
        604.2435222681916,
        557.5324744531557,
        518.356673083154,
        611.6277944404395,
        475.67717163616237,
        437.9362965964223,
        459.94142686331963,
        540.2242564285795,
        611.4617471035056,
        644.800392372276 ,
        705.8731140300583,
        842.045008941379 ,
        725.0841807886741,
        795.3849275259192,
        737.6709983683087,
        746.6395981235476,
        654.691121738355,
        848.5832413852655,
        775.4154549776924,
        531.714253329035,
        520.8670652164462,
        600.461782705121,
        643.1283186338972,
        724.8720653634991,
        702.0814935755348,
        628.0130551679445,
        618.2364073181093,
        638.7472996597336,
        726.1742864271273,
        751.156846584599,
        880.8598097258988,
        870.3417990080604,
        1004.5220437386319,
        1169.218896976792,
        1188.2104814687043,
        1242.988770482277,
        1242.227824786681,
        1073.6987196693342,
        1010.1589616804024,
        1255.7907118983399,
        1135.5425714002329,
        1135.3416396481819,
        990.4079721960838,
        948.182880928749,
        1076.0493114529345,
        828.6760203702789,
        984.0673286525409,
        1068.215583681304,
        1192.9531575422845,
        1073.7759434282445,
        1048.9953145065556,
        1008.7105947542675,
        1092.7486218523002,
        1129.218433792026 ,
        1176.8696425920793,
        1156.241600002003,
        1189.627516869247,
        1135.871776029332,
        1218.6496607824754,
        1219.6083601690673,
        1207.5540378722308,
        1115.9023036418223,
        1004.4812709002524,
        924.6649330094724,
        910.6304980052971,
        855.9594673337976,
        838.4334900690073,
        812.6044924393871,
        819.059146877016,
        823.8384850399448,
        806.8049169921911,
};

var returnCodeValue = ITM.ITM_P2P_CR_Ex(
                h_tx__meter: 44.5,
                h_rx__meter: 139.6,
                pfl: elevationProfile,
                climate: 5, //continental temperate
                N_0: 300.9, //continental temperate
                f__mhz: 453.6125,
                pol: 1, //vertical
                epsilon: 15, //average groud
                sigma: 0.005, //average groud
                mdvar: 12, //mobile
                confidence: 10,
                reliability: 10,
                out var A__db,
                out var warningFlag,
                out var interValues
            );

Console.WriteLine($"Return Code: {returnCodeValue}");
Console.WriteLine($"Warning Flag: {warningFlag}");
Console.WriteLine($"Model Loss: {A__db}dB");
Console.WriteLine($"Mode: {interValues.Mode}");
Console.WriteLine($"Free Space Loss: {interValues.A_fs__db}dB");
Console.WriteLine($"Distance: {interValues.d__km}km");
Console.WriteLine($"Tx Effective Height: {interValues.h_e__meter[0]}m");
Console.WriteLine($"Rx Effective Height: {interValues.h_e__meter[1]}m");
Console.WriteLine($"Terrain Roughness: {interValues.delta_h__meter}m");