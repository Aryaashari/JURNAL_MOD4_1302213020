using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302213020
{
    class KodeBuah
    {
        static Dictionary<string, string> Kamus = new Dictionary<string, string>() {
            {"Apel","A00"},
            {"Aprikot","B00"},
            {"Alpukat","C00"},
            {"Pisang","D00"},
            {"Paprika","E00"},
            {"Blackberry","F00"},
            {"Ceri","H00"},
            {"Kelapa","I00"},
            {"Jagung","J00"},
            {"Kurma","K00"},
            {"Durian","L00"},
            {"Anggur","M00"},
            {"Melon","N00"},
            {"Semangka","O00"},
        };

        public string getKodeBuah(string buah)
        {
            if (Kamus.ContainsKey(buah))
            {
                return Kamus[buah];
            }

            return "Kode buah not found!";
        }
    }
}
