using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCS
{
    class ClassItemEpee : ClassItem
    {
        public float Taux;
        public string Atk1;
        public string Atk2;
        public string Atk3;

        public ClassItemEpee(string n,string d, int p, float t, string a1, string a2, string a3)
        {
            Nom = n;
            Desc = d;
            Prix = p;
            Taux = t;
            Atk1 = a1;
            Atk2 = a2;
            Atk3 = a3;

        }
    }
}
