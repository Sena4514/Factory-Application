using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    public class Fabrika
    {
        public string ad { get; set; }
        public string adres { get; set; }
        private List<Personel> Personeller { get; set; }

        public void PersonelEkle(List<Personel> Personeller, Personel per)
        {
            Personeller.Add(per);
        }

        public void PersonelCikartma(List<Personel> Personeller, long CikartTc)
        {
            for (int i = 0; i < Personeller.Count; i++)
            {
                Personel personel = Personeller[i];
                if (CikartTc == personel.kimlik.tcKimlikNo)
                    Personeller.RemoveAt(i);
            }
        }
    }
}
