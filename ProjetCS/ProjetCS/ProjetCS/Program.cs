using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //definition des Armes

            ClassItemEpee Arme1 = new ClassItemEpee("Epée en bois", "Cet Epee est l'arme de départ elle vous aidera au debut de votre quete !", 15, 1.0f, "Coup Simple", "Frappe Regénératrice", "Attaque Lourde");
            ClassItemEpee Arme2 = new ClassItemEpee("Epée Robuste", "Epée ayant deja servi , son acier est fait de materiaux particulièrement résistants", 15, 1.25f, "Tranchant solide", "Lame de vie", "Epee Divine");
            ClassItemEpee Arme3 = new ClassItemEpee("MasterSword", "Cet Epée est la plus puissante du royame on dit qu'elle a été forgée par le Grand Jean", 15, 1.5f, "Jean tack", "Jean recupère", "Jean ai marre");

            ClassItemEpee[] Armes = new ClassItemEpee[] { Arme1, Arme2, Arme3 };

            bool Arme2pos = false;
            bool Arme3pos = false;
            bool crabe = false;
            //definition Hero de depard
            string ValNom;
            
            Console.WriteLine("Nom du Héros : ");
            ValNom = Console.ReadLine();
            Console.Clear();
            int ValVie = 150;
            int ValAbs = 1;
            int ValOrd = 1;
            int ValAtk = 3000;
            int ValDef = 15;
            int ValExp = 0;
            int ValEnd = 3;
            int ValLvl = 1;
            int ValArg = 100;
            ClassPersPrinc Hero = new ClassPersPrinc(ValNom, ValAbs, ValOrd, ValVie, ValAtk, ValDef, ValExp, ValEnd, Arme1, ValLvl, ValArg, 0, 0, 0);
            Console.WriteLine("\n");
            Console.WriteLine("La Légende raconte qu'un héros nommé"+" "+ValNom+" " +"réapparait tout les 1000 ans. Sa quête est de trouver les Herbes magiques ayant le pouvoir de soulager les âmes des mortels. Notre héros les recherches pour pouvoir soigner le cancer de sa grand-mère. Mais attention votre ennemi juré le BIAHM (Brigade d'Intervention Anti Herbes Lagiques) tentera de vous arrêter dans votre périple.");
            Console.WriteLine("\n");
            Console.WriteLine("Pour survivre dans ce monde vous devrez utiliser des Cocas qui vous ferons regagner de la vie ou qui augmenteront votre attaque et votre defense de façon permanente !");
            Console.WriteLine("\n");
            Console.WriteLine("Le fonctionnement du système de combat vous sera expliqué par la suite aventurier!");
            //definition des ennemis
            ClassPersEnnemi Ennemi1 = new ClassPersEnnemi(150, 24,10, 1, "Maurice le Truand", "Eh ! Vous là-bas ! Ces herbes sont à nous !", "Je suis bon perdant , tu trouveras les herbes en allant vers l'Est",120, 100);
            ClassPersEnnemi Ennemi2 = new ClassPersEnnemi(180, 29, 15, 1, "Barnabé le Tueur", "Vous n'auriez jamais mettre les pieds ici !", "Je ne vous dirais rien , partez.,",120, 120);
            ClassPersEnnemi Ennemi3 = new ClassPersEnnemi(280, 43, 20, 3, "René le Massacreur", "Mort aux ennemies du BIAHM!", "Oh zut , je suis mort !", 210, 150);
            ClassPersEnnemi Ennemi4 = new ClassPersEnnemi(350, 55, 25,4, "Dylan la Terreur", "Vous n'auriez jamais mettre les pieds ici !", "Je ne vous dirais rien , partez..", 350, 180);
            ClassPersEnnemi Ennemi5 = new ClassPersEnnemi(400, 60, 30, 4, "Robert le Méchant", "Je ne vous connais pas , mais je vais vous tuer !", "Les herbes sont versl'Est", 350, 210);
            ClassPersEnnemi Ennemi6 = new ClassPersEnnemi(650, 60, 30, 6, "Sandrine la Mort Incarnée", "Ennemi : Je vous tuerais !", "Vous ne trouverez jamais ces satanés herbes",600, 250);
            ClassPersEnnemi Timte = new ClassPersEnnemi(1200, 90, 30, 10, "Timté Chef du BIAHM", "ARRRRGH ! Ton histoire s'achève ici ! C'est le chef du BIAHM que tu affronte! Tu as insulté notre nom depuis bien trop longtemps , la prophécie ne se réalisera pas !", "NOOOOOOOOOOON!",0,0);

            //definition Lieux
            ClassLieux Lieux1 = new ClassLieux("Plaine Solitaire",false);
            ClassLieux Lieux2 = new ClassLieux("repère des voleurs", false);
            ClassLieux Lieux3= new ClassLieux("Le Coin Du Marchand", false);
            ClassLieux Lieux4 = new ClassLieux("Mc Donald's", false);
            ClassLieux Lieux5 = new ClassLieux("Desert", false);
            ClassLieux Lieux6 = new ClassLieux("O Tacos", false);
            ClassLieux Lieux7 = new ClassLieux("Burger King", false);
            ClassLieux Lieux8 = new ClassLieux("Guimguanp", false);
            ClassLieux Lieux9 = new ClassLieux("Kebab City", false);
            ClassLieux Lieux10 = new ClassLieux("Team Rocket", false);
            ClassLieux Lieux11 = new ClassLieux("Le Marais qui pue", false);
            ClassLieux Lieux12 = new ClassLieux("Starbucks", false);
            ClassLieux Lieux13 = new ClassLieux("La Grote de René", false);
            ClassLieux Lieux14 = new ClassLieux("Fan Club", false);
            ClassLieux Lieux15 = new ClassLieux("Subway", false);
            ClassLieux Lieux16 = new ClassLieux("Antre de la mort", false);
            ClassLieux Lieux17 = new ClassLieux("La Barque de Billy", false);
            ClassLieux Lieux18 = new ClassLieux("La Vallé du KO", false);
            ClassLieux Lieux19 = new ClassLieux("La Rue des Pommiers", false);
            ClassLieux Lieux20 = new ClassLieux("Domino's Pizza", false);
            ClassLieux Lieux21 = new ClassLieux("Destination finale", false);

            bool fin = false;

            while (fin == false)
            {
                //definition des niveaux
                if (Hero.Lvl == 1 & Hero.Exp > 100) { Hero.LvlUp(); }
                if (Hero.Lvl == 2 & Hero.Exp > 250) { Hero.LvlUp(); }
                if (Hero.Lvl == 3 & Hero.Exp > 450) { Hero.LvlUp(); }
                if (Hero.Lvl == 4 & Hero.Exp > 750) { Hero.LvlUp(); }
                if (Hero.Lvl == 5 & Hero.Exp > 1150) { Hero.LvlUp(); }
                if (Hero.Lvl == 6 & Hero.Exp > 1700) { Hero.LvlUp(); }

                //Lieux1
                if (Hero.abs == 1 & Hero.ord == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux1.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Nord ");
                    Console.WriteLine(" 2- Aller vers le Sud");
                    Console.WriteLine(" 3- Aller vers l'Est");
                    Console.WriteLine(" 4- Aller au Coin du marchand");
                    Console.WriteLine(" 5- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord++; }
                    else if (ChoixMenu == 2) { Hero.ord--; }
                    else if (ChoixMenu == 3) { Hero.abs++; }
                    else if (ChoixMenu == 4) { Hero.abs--; }
                    else if (ChoixMenu == 5) { ClassInventaire.Inventaire(Hero, Armes ,Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 5"); }

                }
                //Lieux2
                else if (Hero.abs == 2 & Hero.ord == 1)
                {
                    Console.Clear();
                    if (Lieux2.recup == false)
                    {
                        
                        Console.WriteLine("Voici votre premiere ennemi , vous pouez utiliser trois Atk :");
                        Console.WriteLine("\n");
                        Console.WriteLine(" 1- attaque basic ne consomme pas d'endurance");
                        Console.WriteLine(" 2- vous infligez des degats reduit mais vous recupere 20% de votre vie max et utilisez 2 endurance");
                        Console.WriteLine(" 3- vous utilisez 3 d'endurance et infligez deux fois plus de degats");
                        Thread.Sleep(10000);
                        ClassCombat.Combat(Ennemi1, Hero);
                        Lieux2.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux2.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("Que Faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Nord ");
                    Console.WriteLine(" 2- Aller vers le Sud");
                    Console.WriteLine(" 3- Aller vers l'Est");
                    Console.WriteLine(" 4- Aller vers l'Ouest");
                    Console.WriteLine(" 5- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord++; }
                    else if (ChoixMenu == 2) { Hero.ord--; }
                    else if (ChoixMenu == 3) { Hero.abs++; }
                    else if (ChoixMenu == 4) { Hero.abs--; }
                    else if (ChoixMenu == 5) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 5"); }
                }
                //Lieux3
                else if (Hero.abs == 0 & Hero.ord == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux3.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("Que Faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Parler au Marchand ");
                    Console.WriteLine(" 2- Aller vers l'Est");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1)
                    {
                        ClassMarchand m = new ClassMarchand();
                        m.Marchand(Hero, ref Arme2pos);
                    }
                    else if (ChoixMenu == 2) { Hero.abs++; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //lieux4
                else if (Hero.abs == 1 & Hero.ord == 2)
                {
                    Console.Clear();
                    if (Lieux4.recup == false)
                    {
                        ClassLieux.Recompense(Hero, 10, 5);
                        Lieux4.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux4.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("Que Faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Sud");
                    Console.WriteLine(" 2- Aller vers l'Est");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord--; }
                    else if (ChoixMenu == 2) { Hero.abs++; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux5
                else if (Hero.abs == 2 & Hero.ord == 2)
                {
                    Console.Clear();
                    ClassLieux.Rien();
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux5.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("Que Faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Sud");
                    Console.WriteLine(" 2- Aller vers l'Ouest");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord--; }
                    else if (ChoixMenu == 2) { Hero.abs--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux6
                else if (Hero.abs == 2 & Hero.ord == 0)
                {
                    Console.Clear();
                    if (Lieux6.recup == false)
                    {
                        ClassLieux.Recompense(Hero, 10, 5);
                        Lieux6.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux6.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("Que Faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Nord");
                    Console.WriteLine(" 2- Aller vers l'Est");
                    Console.WriteLine(" 3- Aller vers l'Ouest");
                    Console.WriteLine(" 4- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord++; }
                    else if (ChoixMenu == 2) { Hero.abs++; }
                    else if (ChoixMenu == 3) { Hero.abs--; }
                    else if (ChoixMenu == 4) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 4"); }
                }
                //Lieux7
                else if (Hero.abs == 1 & Hero.ord == 0)
                {
                    Console.Clear();
                    if (Lieux7.recup == false)
                    {
                        ClassLieux.Recompense(Hero, 10, 5);
                        Lieux7.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux7.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Nord");
                    Console.WriteLine(" 2- Aller vers l'Est");;
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord++; }
                    else if (ChoixMenu == 2) { Hero.abs++; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux8
                else if (Hero.abs == 3 & Hero.ord == 0)
                {
                    Console.Clear();
                    ClassLieux.Rien();
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux8.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Nord");
                    Console.WriteLine(" 2- Aller vers l'Ouest"); ;
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord++; }
                    else if (ChoixMenu == 2) { Hero.abs--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux9
                else if (Hero.abs == 3 & Hero.ord == 1)
                {
                    Console.Clear();
                    if (Lieux9.recup == false)
                    {
                        ClassLieux.Recompense(Hero, 10, 5);
                        Lieux9.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux9.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Sud");
                    Console.WriteLine(" 2- Aller vers l'Est");
                    Console.WriteLine(" 3- Aller vers l'Ouest"); 
                    Console.WriteLine(" 4- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord--; }
                    else if (ChoixMenu == 2) { Hero.abs++; }
                    else if (ChoixMenu == 3) { Hero.abs--; }
                    else if (ChoixMenu == 4) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 4"); }
                }
                //Lieux10
                else if (Hero.abs == 4 & Hero.ord == 1)
                {
                    Console.Clear();
                    if (Lieux10.recup == false)
                    {
                        ClassCombat.Combat(Ennemi2, Hero);
                        Lieux10.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux10.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Nord ");
                    Console.WriteLine(" 2- Aller vers l'Ouest");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord++; }
                    else if (ChoixMenu == 2) { Hero.abs--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux11
                else if (Hero.abs == 4 & Hero.ord == 3)
                {
                    Console.Clear();
                    if (Lieux11.recup == false)
                    {
                        ClassLieux.Recompense(Hero, 10, 5);
                        Console.WriteLine("Vous avez trouvé le crabe de Billy");
                        Thread.Sleep(1000);
                        crabe = true;
                        Lieux11.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux9.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Sud");
                    Console.WriteLine(" 2- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord--; }
                    else if (ChoixMenu == 2) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 2"); }
                }
                //Lieux12
                else if (Hero.abs == 4 & Hero.ord == 2)
                {
                    Console.Clear();
                    if (Lieux12.recup == false)
                    {
                        ClassLieux.Recompense(Hero, 10, 5);
                        Lieux12.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux12.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Sud");
                    Console.WriteLine(" 2- Aller vers l'Est");
                    Console.WriteLine(" 3- Aller vers le Nord");
                    Console.WriteLine(" 4- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord--; }
                    else if (ChoixMenu == 2) { Hero.abs++; }
                    else if (ChoixMenu == 3) { Hero.ord++; }
                    else if (ChoixMenu == 4) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 4"); }
                }
                //Lieux13
                else if (Hero.abs == 5 & Hero.ord == 2)
                {
                    Console.Clear();
                    if (Lieux13.recup == false)
                    {
                        ClassCombat.Combat(Ennemi3, Hero);
                        Lieux13.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux13.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers l'Est ");
                    Console.WriteLine(" 2- Aller vers l'Ouest");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.abs++; }
                    else if (ChoixMenu == 2) { Hero.abs--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux14
                else if (Hero.abs == 6 & Hero.ord == 2)
                {
                    Console.Clear();
                    ClassLieux.Rien();
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux14.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Sud");
                    Console.WriteLine(" 2- Aller vers l'Ouest"); ;
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord--; }
                    else if (ChoixMenu == 2) { Hero.abs--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux15
                else if (Hero.abs == 6 & Hero.ord == 1)
                {
                    Console.Clear();
                    if (Lieux15.recup == false)
                    {
                        ClassLieux.Recompense(Hero, 10, 5);
                        Lieux15.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux15.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Sud");
                    Console.WriteLine(" 2- Aller vers l'Est");
                    Console.WriteLine(" 3- Aller vers le Nord");
                    Console.WriteLine(" 4- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord--; }
                    else if (ChoixMenu == 2) { Hero.abs++; }
                    else if (ChoixMenu == 3) { Hero.ord++; }
                    else if (ChoixMenu == 4) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 4"); }
                }
                //Lieux16
                else if (Hero.abs == 6 & Hero.ord == 0)
                {
                    Console.Clear();
                    if (Lieux16.recup == false)
                    {
                        ClassCombat.Combat(Ennemi4, Hero);
                        Lieux16.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux16.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Nord ");
                    Console.WriteLine(" 2- Aller vers le Sud");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord++; }
                    else if (ChoixMenu == 2) { Hero.ord--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux17
                else if (Hero.abs == 6 & Hero.ord == -1)
                {
                    Console.Clear();
                    if (Lieux17.recup == false & crabe == false)
                    {
                        Console.WriteLine("Oh Jeune Homme pourriez-vous m'aider Je m'appelle Billy Le Pecheur...");
                        Thread.Sleep(5000);
                        Console.WriteLine("\n");
                        Console.WriteLine("J'ai égarer mon crabe vers le Marais qui pue mais je n'ai pas assez de force pour y aller , pourriez-vous le faire ? Vous aurez bien sur une récompense !");
                        Thread.Sleep(5000); 
                    }
                    else if(Lieux17.recup == false & crabe == true)
                    {
                        Console.WriteLine("Mon cher Crabe ! C'est bien toi HAHAHA !");
                        Thread.Sleep(5000);
                        Console.WriteLine("\n");
                        Console.WriteLine("Tenez mon ami , cette Lame appartient à mes ancêtres depuis Jacques Chirac.");
                        Console.WriteLine("\n");
                        Thread.Sleep(5000);
                        Console.WriteLine("La Master Sword est disponible dans votre inventaire");
                        Console.WriteLine("\n");
                        Thread.Sleep(5000);
                        Console.WriteLine("\n");
                        Console.WriteLine("Il s'agit d'une Lame encestrale forgé par le Dieu Jean le Gentil");
                        Thread.Sleep(5000);
                        Arme3pos = true;
                        Lieux17.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux17.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers le Nord ");
                    Console.WriteLine(" 2- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.ord++; }
                    else if (ChoixMenu == 2) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 2"); }
                }
                //Lieux18
                else if (Hero.abs == 7 & Hero.ord == 1)
                {
                    if (Lieux18.recup == false)
                    {
                        ClassCombat.Combat(Ennemi5, Hero);
                        Lieux18.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux18.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers l'Est ");
                    Console.WriteLine(" 2- Aller vers l'Ouest");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.abs++; }
                    else if (ChoixMenu == 2) { Hero.abs--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux19
                else if (Hero.abs == 8 & Hero.ord == 1)
                {
                    Console.Clear();
                    if (Lieux19.recup == false)
                    {
                        Console.WriteLine(" Gentille Dame : Bonjour charmant jeune homme vous ressemblez fortement à Olivier Giroud , que cherchez vous ? Ah oui les herbes magiques , elles sont juste à coté.  ...");
                        Thread.Sleep(5000);
                        Console.WriteLine("\n");
                        Console.WriteLine("Sandrine la Mort Incarnée : ces Informations sont confidentiels , La loi est stricte , vous devez mourir !");
                        Thread.Sleep(5000);
                        Console.WriteLine("\n");
                        Console.WriteLine(" Gentille Dame : S'il vous plait Olivier Giroud...euh je veux dire"+" "+ValNom+" "+"Sauvez moi la vie et je dirais où sont les herbes !");
                        ClassCombat.Combat(Ennemi6, Hero);
                        Lieux19.recup = true;
                        Console.WriteLine("Gentille Madame : Merci " + Hero.Nom + " les herbes magiques se trouve a L'est par rapport a nous !");
                        Thread.Sleep(10000);
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux19.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers l'Est ");
                    Console.WriteLine(" 2- Aller vers l'Ouest");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.abs++; }
                    else if (ChoixMenu == 2) { Hero.abs--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux20
                else if (Hero.abs == 9 & Hero.ord == 1)
                {
                    Console.Clear();
                    if (Lieux20.recup == false)
                    {
                        ClassLieux.Recompense(Hero, 100, 50);
                        Lieux20.recup = true;
                    }
                    else { ClassLieux.Rien(); }
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux20.name);
                    Console.WriteLine("\n");
                    Console.WriteLine("que voulez vous faire ?");
                    Console.WriteLine("\n");
                    Console.WriteLine(" 1- Aller vers l'Est");
                    Console.WriteLine(" 2- Aller vers l'Ouest");
                    Console.WriteLine(" 3- Inventaire");
                    int ChoixMenu = (int.Parse(Console.ReadLine()));

                    if (ChoixMenu == 1) { Hero.abs++; }
                    else if (ChoixMenu == 2) { Hero.abs--; }
                    else if (ChoixMenu == 3) { ClassInventaire.Inventaire(Hero, Armes, Arme2pos, Arme3pos); }
                    else { Console.WriteLine("Vous devez  entrer un nombre entre 1 et 3"); }
                }
                //Lieux21
                else if (Hero.abs == 10 & Hero.ord == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(Lieux21.name);
                    Console.WriteLine("\n");
                    if (Lieux21.recup == false)
                    {
                        ClassCombat.Combat(Timte, Hero);
                        Lieux21.recup = true;
                    }
                }

                if (Lieux21.recup == true)
                {
                    fin = true;
                    Thread.Sleep(5000);
                    Console.WriteLine("Félicitation vous avez gagné !");
                    Console.WriteLine("\n");
                    Thread.Sleep(5000);
                    Console.WriteLine("\n");
                    Console.WriteLine("Oups , Votre Grand mère est morte pendant votre périple , votre quête a été enfin de compte totalement inutile.");
                    Thread.Sleep(5000);
                    Console.WriteLine("\n");
                    Console.WriteLine("THE END");
                    Thread.Sleep(10000);
                }
                
            }
        }
    }
}
