using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCS
{
    class ClassPersPrinc : ClassPers
    {
        public int abs;
        public int ord;
        public int Exp;
        public int End;
        public int EndMax;
        public ClassItemEpee Epee;
        public int Argent;
        public int VieMax;
        public int NbCocaV;
        public int NbCocaR;
        public int NbCocaB;

        public ClassPersPrinc(string ValNom,int ab, int or,int ValVie,int ValAtk,int ValDef,int ValExp, int ValEnd,ClassItemEpee ValEpee,int ValLvl, int ValArg, int nbV, int nbr, int nbb)
        {
            abs = ab;
            ord = or;
            Nom = ValNom;
            Vie = ValVie;
            VieMax = ValVie;
            Atk = ValAtk;
            Def = ValDef;
            Exp = ValExp;
            End = ValEnd;
            EndMax = ValEnd;
            Epee = ValEpee;
            Lvl = ValLvl;
            Argent = ValArg;
            NbCocaV = nbV;
            NbCocaR = nbr;
            NbCocaB = nbb;
        }
        public void ModifNbCocaV(int a)
        {
            NbCocaV = NbCocaV + a;
        }
        public void ModifNbCocaR(int a)
        {
            NbCocaR = NbCocaR + a;
        }
        public void ModifNbCocaB(int a)
        {
            NbCocaB = NbCocaB + a;
        }
        public void CocaVert()
        {
            if (NbCocaV > 0)
            {
                Vie = Vie + (VieMax / 2);
                if (Vie > VieMax) { Vie = VieMax; }
                NbCocaV--;
                Console.WriteLine("Vous avez recupere la moitie de votre vie"); 
            }
            else { Console.WriteLine("Vous n'avez pas de Coca vert"); }
        }
        public void CocaRougeUp()
        {
            if (NbCocaR > 0)
            {
                Atk = Atk + 10;
                NbCocaR--;
                Console.WriteLine("Vous avez recupere pus 10 en attaque");
            }
            else { Console.WriteLine("Vous n'avez pas de Coca Rouge"); }
        }
        public void CocaBleuUp()
        {
            if (NbCocaB > 0)
            {
                Def = Def + 5;
                NbCocaB--;
                Console.WriteLine("Vous avez recupere plus 5 en defense");
            }
            else { Console.WriteLine("Vous n'avez pas de Coca bleu"); }
        }
        public void LvlUp()
        {
            Lvl = Lvl + 1;
            Vie = Vie + 50;
            VieMax = VieMax + 50;
            Atk = Atk + 10;
            Def = Def + 5;
            End = End + 1;
            EndMax = EndMax + 1;
            Console.WriteLine("Vous avez monter de un Niveau");

        }
        
    }

}
