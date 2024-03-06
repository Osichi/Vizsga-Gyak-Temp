using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Books
    {
        public int sorszam;
        public string mufaj;
        public string cim;
        public int ar;
        public int mennyiseg;

        public Books(string sorszam, string mufaj, string cim, string ar, string mennyiseg)
        {
            this.sorszam = int.Parse(sorszam);
            this.mufaj = mufaj;
            this.cim = cim;
            this.ar = int.Parse(ar);
            this.mennyiseg = int.Parse(mennyiseg);
        }


    }
}
