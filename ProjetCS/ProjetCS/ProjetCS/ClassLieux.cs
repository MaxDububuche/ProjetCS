using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCS
{
    class ClassLieux
    {
        public string name;
        public bool recup;

        public ClassLieux(string n, bool l)
        {
            name = n;
            recup = l;
        }
        public static void Recompense(ProjetCS.ClassPersPrinc Hero, int argent, int exp)
        {
            Hero.Argent = Hero.Argent + argent;
            Hero.Exp = Hero.Exp + exp;

            Random rnd = new Random();
            int indic = rnd.Next(1, 4);

            if (indic == 1)
            {
                Hero.NbCocaV++;
                Console.WriteLine("Félicitation vous venez de trouver 1 Coca Vert , " + argent + "$ et " + exp + " exp");
            }
            else if (indic == 2)
            {
                Hero.NbCocaR++;
                Console.WriteLine("Félicitation vous venez de trouver 1 Coca Rouge , " + argent + "$ et " + exp + " exp");
            }
            else if (indic == 3)
            {
                Hero.NbCocaB++;
                Console.WriteLine("Félicitation vous venez de trouver 1 Coca Bleu , " + argent + "$ et " + exp + " exp");
            }
        }
        public static void Rien()
        {
            Console.WriteLine("Il n'y a pas de recompense ou d'ennemi ici !");
        }
    }
}
