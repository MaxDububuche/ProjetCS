using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetCS
{
    class ClassInventaire
    {

        public static void Inventaire(ProjetCS.ClassPersPrinc Hero ,ClassItemEpee[] Armes, bool Arme2pos ,bool Arme3pos )
        {
            Console.WriteLine("Votre Vie : " + Hero.Vie + " / " + Hero.VieMax );
            Console.WriteLine("Votre Endurance : " + Hero.End + " / " + Hero.EndMax + "     Votre Attaque : " + Hero.Atk + "     Votre Defense : " + Hero.Def);
            Console.WriteLine("\n");
            Console.WriteLine("Que voulez vous faire ?");
            Console.WriteLine("\n");
            Console.WriteLine(" 1- Liste Potion");
            Console.WriteLine(" 2- Utiliser Potion");
            Console.WriteLine(" 3- Changer Arme");
            Console.WriteLine(" 4- quitter inventaire");
            int choixinv1 = (int.Parse(Console.ReadLine()));

            if (choixinv1 == 1)
            {
                Console.WriteLine("Coca Vert : " + Hero.NbCocaV);
                Console.WriteLine("Coca Rouge : " + Hero.NbCocaR);
                Console.WriteLine("Coca Bleu : " + Hero.NbCocaB);
                Thread.Sleep(1000);
            }
            else if (choixinv1 == 2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Votre Vie : " + Hero.Vie + " / " + Hero.VieMax);
                Console.WriteLine("Votre Endurance : " + Hero.End + " / " + Hero.EndMax + "     Votre Attaque : " + Hero.Atk + "     Votre Defense : " + Hero.Def);
                Console.WriteLine("Que voulez vous faire ?");
                Console.WriteLine("\n");
                Console.WriteLine(" 1- Utiliser Coca Vert       ils vous en rest : " + Hero.NbCocaV);
                Console.WriteLine(" 2- Utiliser Coca Rouge       ils vous en rest : " + Hero.NbCocaR);
                Console.WriteLine(" 3- Utiliser Coca Bleu       ils vous en rest : " + Hero.NbCocaB);
                int choixinv2 = (int.Parse(Console.ReadLine()));

                if (choixinv2 == 1) { Hero.CocaVert(); }
                else if (choixinv2 == 2) { Hero.CocaRougeUp(); }
                else if (choixinv2 == 3) { Hero.CocaBleuUp(); }
                else { Console.WriteLine("vous devez entrez un chiffre entre 1 et 3"); }
            }
            else if (choixinv1 == 3)
            {

                Console.WriteLine(" 1-  Epee de Bois");
                if (Arme2pos == true ) { Console.WriteLine(" 2 - Epee Robuste"); }
                if (Arme3pos == true) { Console.WriteLine(" 3-  MasterSword"); }
                int choixinv2 = (int.Parse(Console.ReadLine()));

                if (choixinv2 == 1) { Hero.Epee = Armes[0]; }
                else if (choixinv2 == 2) { Hero.Epee = Armes[1]; }
                else if (choixinv2 == 3) { Hero.Epee = Armes[2]; }
                else { Console.WriteLine("vous devez entrez un chiffre entre 1 et 3"); }

            }
            else if (choixinv1 == 4) { }

            else
            {
                if(Arme2pos == false & Arme3pos == false) { Console.WriteLine("vous devez entrez un chiffre entre 1"); }
                else if ((Arme2pos == false & Arme3pos == true) && (Arme2pos == true & Arme3pos == false)) { Console.WriteLine("vous devez entrez un chiffre entre 1 et 2"); }
                if (Arme2pos == true & Arme3pos == true) { Console.WriteLine("vous devez entrez un chiffre entre 1 et 3"); }
            }
        }
    }
}
