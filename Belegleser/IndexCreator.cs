using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Belegleser
{
    class IndexCreator
    {
        private Dictionary<string, string> keyValuePair;
        private enum BelArts { EKAnfrage = 01, EKAngebot = 02, EKBestellung = 03, EKLieferschein = 04, EKRechung = 05, EKKorrespondenz = 06, EKAuftragbestätigung = 07, VKAnfrage = 08, VKAngebot = 09, VKAuftrag = 10, VKBestellung = 11, VKRechnung = 12, VKKorrespondenz = 13, VKRechnungskorrektur = 14, VKRetour = 15, KorrespondenzAllgemein = 16, Mahnwesen = 17, Maßanfertigungformular = 18, Einlieferungsbelege = 19, EKRechnungskorrektur = 20, Kontoumsätze = 21, FIBU = 22, Verträge = 23  }
        private BelArts belArt;
        private string belNr;
        private string fileName;

        public IndexCreator()
        {
            keyValuePair = new Dictionary<string, string>();
        }

        public void addValue(string key, string value)
        {
            if (key.Equals("BelArt"))
            {
                int i = Convert.ToInt32(value);
                this.belArt = (BelArts)i;
            }
            else if (key.Equals("BelNr"))
            {
                this.belNr = value;
            }
            this.keyValuePair.Add(key, value);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (KeyValuePair<string, string> value in this.keyValuePair)
            {
                str.Append(value.Key);
                str.Append("=");
                str.Append(value.Value);
                str.Append(Environment.NewLine);
            }

            return str.ToString();
        }

        public void write(string fileName)
        {
            this.fileName = fileName;
            using (StreamWriter sw = new StreamWriter(this.getFileName() + ".idx"))
            {
                sw.Write(this.ToString());
            }
        }

        public string getFileName()
        {
            return Path.Combine(this.fileName, Enum.GetName(typeof(BelArts), this.belArt) + "_" + this.belNr);
        }

        //using (StreamWriter sw = new StreamWriter(Path.Combine(Auftrags_Pfad, "Auftrag_" + Belnr + ".idx")))
        //    {
        //        sw.WriteLine("Firma=01");
        //        sw.WriteLine("BelArt=10");
        //        sw.WriteLine("BelNr=" + Belnr);
        //        sw.WriteLine("BelDat=" + Beldat);
        //        sw.WriteLine("Betreff=Auftrag " + Belnr);
        //        sw.WriteLine("KuLiNr=" + KuLiNr);
        //        sw.WriteLine("KuLiNam=" + KuLiNam);
        //        sw.WriteLine("KuLiPLZ=" + KuLiPLZ);
        //        sw.WriteLine("KuLiOrt=" + KuliOrt);
        //        sw.WriteLine("Email=" + email);
        //        sw.WriteLine("KuLiLKZ=" + KuLiLKZ);
        //        sw.WriteLine("Betrag=" + Betrag);
        //        sw.WriteLine("Waehrung=" + Waehrung);
        //        sw.WriteLine("Info=Storniert am " +Info);
        //    }
    }
}
