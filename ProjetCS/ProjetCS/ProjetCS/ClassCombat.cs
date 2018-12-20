using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetCS
{
    class ClassCombat
    {
        public static void Combat(ProjetCS.ClassPersEnnemi Ennemi, ProjetCS.ClassPersPrinc Hero)
        {
            Console.WriteLine(Ennemi.DialogueDebut);
            Thread.Sleep(5000);

            Hero.End = Hero.EndMax;
            while (Hero.Vie>0)
            {
                while (Ennemi.Vie>0)
                {
                    if (Hero.End < 3) { Hero.End++; }
                    Console.Clear();
                    Console.WriteLine("Votre Vie : " + Hero.Vie + " / " + Hero.VieMax +"     " +Ennemi.Nom + " : " + Ennemi.Vie + " / " + Ennemi.VieMax);
                    Console.WriteLine("Votre Endurance : " + Hero.End + " / " + Hero.EndMax + "     Votre Attaque : " + Hero.Atk + "     Votre Defense : " + Hero.Def);
                    Console.WriteLine("\n");
                    Console.WriteLine("Que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Attaquer");
                    Console.WriteLine(" 2- Utiliser item");
                    int choixatk1 = (int.Parse(Console.ReadLine()));

                    if (choixatk1 == 1)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Que voulez vous faire ?");
                        Console.WriteLine("\n");
                        Console.WriteLine(" 1- " + Hero.Epee.Atk1);
                        Console.WriteLine(" 2- " + Hero.Epee.Atk2);
                        Console.WriteLine(" 3- " + Hero.Epee.Atk3);
                        int choixatk2= (int.Parse(Console.ReadLine()));

                        if (choixatk2 == 1)
                        {
                            int degat;
                            if ((Hero.Atk - Ennemi.Def) < 0) { degat = 1; }
                            else { degat = (Hero.Atk - Ennemi.Def); }
                            Ennemi.Vie = Convert.ToInt32((Ennemi.Vie - (degat * Hero.Epee.Taux)));
                        }
                        else if (choixatk2 == 2)
                        {
                            Hero.End = Hero.End - 2;
                            if (Hero.End >= 0)
                            {
                                int degat;
                                if ((Hero.Atk - Ennemi.Def) < 0) { degat = 1; }
                                else { degat = (Hero.Atk - Ennemi.Def); }
                                Ennemi.Vie = Convert.ToInt32(Ennemi.Vie - (degat / 2  * Hero.Epee.Taux));
                                Hero.Vie = Hero.Vie + Hero.VieMax / 5;
                                if (Hero.Vie > Hero.VieMax) { Hero.Vie = Hero.VieMax; }

                            }
                            else
                            {
                                Hero.End = Hero.End + 2;
                                Console.WriteLine("Vous n'avez pas assez d'endurance vous avez raté votre coup !");
                            }
                        }
                        else if (choixatk2 == 3)
                        {
                            Hero.End = Hero.End - 3;
                            if (Hero.End >= 0)
                            {
                                int degat;
                                if ((Hero.Atk - Ennemi.Def) < 0) { degat = 1; }
                                else { degat = (Hero.Atk - Ennemi.Def); }
                                Ennemi.Vie = Convert.ToInt32(Ennemi.Vie - (degat * 2 * Hero.Epee.Taux));
                            }
                            else
                            {
                                Hero.End = Hero.End + 3;
                                Console.WriteLine("Vous n'avez pas assez d'endurance vous avez raté votre coup !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("vous devez entrez un chiffre entre 1 et 3");
                        }
                    }
                    else if (choixatk1 == 2)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Que voulez vous faire ?");
                        Console.WriteLine("\n");
                        Console.WriteLine(" 1- Utiliser Coca Vert " + Hero.NbCocaV);
                        Console.WriteLine(" 2- Utiliser Coca Rouge " + Hero.NbCocaR);
                        Console.WriteLine(" 3- Utiliser Coca Bleu " + Hero.NbCocaB);
                        int choixatk2 = (int.Parse(Console.ReadLine()));

                        if (choixatk2 == 1)
                        {
                            Hero.CocaVert();
                        }
                        else if (choixatk2 == 2)
                        {
                            Hero.CocaRougeUp();
                        }
                        else if (choixatk2 == 3)
                        {
                            Hero.CocaBleuUp();
                        }
                        else
                        {
                            Console.WriteLine("vous devez entrez un chiffre entre 1 et 3");
                        }
                    }
                    else
                    {
                        Console.WriteLine("vous devez entrez un chiffre entre 1 et 2");
                    }
                    int degatEnnemi;
                    if ((Ennemi.Atk - Hero.Def) < 0) { degatEnnemi = 1; }
                    else { degatEnnemi = (Ennemi.Atk - Hero.Def); }
                    Hero.Vie = Hero.Vie - degatEnnemi;

                }
                Console.WriteLine(Ennemi.dialoguefin);
                break;
            }
            if (Hero.Vie < 0) { Console.WriteLine("GAME OVER !"); }
            if (Ennemi.Vie < 0)
            {
                Hero.Argent = Hero.Argent + Ennemi.RecompenseArg;
                Hero.Exp = Hero.Exp + Ennemi.RecompenseExp;
                Console.WriteLine("vous avez vaincu "+ Ennemi.Nom + " voici votre recompense"+ Ennemi.RecompenseArg +" $ et " + Ennemi.RecompenseExp + " exp");
                Thread.Sleep(10000);
                Console.Clear();
            }
            
        }

        
    }
}
