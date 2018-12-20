using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCS
{
    class ClassPersEnnemi : ClassPers
    {
        public string DialogueDebut;
        public string dialoguefin;
        public int RecompenseExp;
        public int RecompenseArg;
        public int VieMax;

        public ClassPersEnnemi(int v, int a, int d, int l, string n, string dd, string df, int rExp, int rArg)
        {
            Vie = v;
            VieMax = v;
            Atk = a;
            Def = d;
            Lvl = l;
            Nom = n;
            DialogueDebut = dd;
            dialoguefin = df;
            RecompenseExp = rExp;
            RecompenseArg = rArg;
        }
    }
}
