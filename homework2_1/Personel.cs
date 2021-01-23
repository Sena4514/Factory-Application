using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
     public class Personel
    {
        public long personelNo { get; set; }
        public string birim { get; set; }

        public KimlikBilgileri kimlik = new KimlikBilgileri();  
    }

}
