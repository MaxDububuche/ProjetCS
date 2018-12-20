using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCS
{
    class ClassMarchand
    {
        public void AchatCocaVert(ProjetCS.ClassPersPrinc Hero)
        {
            if (Hero.Argent >= 50) {
                Hero.NbCocaV++;
                Hero.Argent = Hero.Argent - 25;
            }
        }
        public void AchatCocaRouge(ProjetCS.ClassPersPrinc Hero)
        {
            if (Hero.Argent >= 75)
            {
                Hero.NbCocaR++;
                Hero.Argent = Hero.Argent - 50;
            }
        }
        public void AchatCocaBleu(ProjetCS.ClassPersPrinc Hero)
        {
            if (Hero.Argent >= 75)
            {
                Hero.NbCocaB++;
                Hero.Argent = Hero.Argent - 50;
            }
        }
        public bool AchatEpee(ProjetCS.ClassPersPrinc Hero, bool Arme2pos)
        {
            if (Hero.Argent >= 100)
            {
                Hero.Argent = Hero.Argent - 100;
                Arme2pos = true;
                return true;
            }
            return false;
        }
        public void Marchand(ProjetCS.ClassPersPrinc Hero, ref bool Arme2pos)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Argent :" + Hero.Argent);
            Console.WriteLine("\n");
            Console.WriteLine("Hello Mon ami ! J'ai tout ce qu'il faut ici , Regardez donc !");
            Console.WriteLine("\n");
            Console.WriteLine(" 1- Coca Vert :  25" );
            Console.WriteLine(" 2- Coca Rouge :  50");
            Console.WriteLine(" 3- Coca Bleu :  50");
            if (Arme2pos == false) { Console.WriteLine(" 4- Epee Robuste a :  100"); }
            int choixmarch = (int.Parse(Console.ReadLine()));

            if (choixmarch == 1) { AchatCocaVert(Hero); }
            else if(choixmarch ==2){ AchatCocaRouge(Hero); }
            else if (choixmarch == 3) { AchatCocaBleu(Hero); }
            else if (choixmarch == 4) {
                bool b = AchatEpee(Hero, Arme2pos);
                if (b == true){
                    Arme2pos = true;
                }
            }
            else { Console.WriteLine("vous devez entrez un chiffre entre 1 et 4"); }
            
        }
        
    }
}
