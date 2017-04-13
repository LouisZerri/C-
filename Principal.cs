using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Principal
    {
        public static void Main(String[] args)
        {
            int choix;
            int j = 5;

            Joueur joueur = new Joueur("Aventurier", 100, 30);

            Ennemi ennemi1 = new Ennemi("Balrog", 100, 10);

            Ennemi ennemi2 = new Ennemi("Squelette", 100, 10);

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("\n\n===== | AVENTURIER - (" + joueur.points_de_vie + "/100pv) | =====\n\n");
                Console.WriteLine("");
                Console.WriteLine("=====Tour n°" + i + "=====");
                Console.WriteLine("");
                Console.WriteLine("Quelle action effectuée ? ");

                if (j >= 1)
                {
                    Console.WriteLine("1 - Se soigner (encore " + j + " fois)");
                }
                else
                {
                    Console.WriteLine("1 - Vous ne pouvez plus vous soigner");
                }


                if (ennemi1.points_de_vie > 0)
                {
                    Console.WriteLine("2 - Attaquer " + ennemi1.nom + " - (" + ennemi1.points_de_vie + "/100pv)");
                }
                else
                {
                    Console.WriteLine("2 - " + ennemi1.nom + " est vaincu");
                }

                if (ennemi2.points_de_vie > 0)
                {
                    Console.WriteLine("3 - Attaquer " + ennemi2.nom + " - (" + ennemi2.points_de_vie + "/100pv)");
                }
                else
                {
                    Console.WriteLine("3 - " + ennemi2.nom + " est vaincu");
                }

                Console.WriteLine("4 - Quitter ");
                Console.WriteLine("Entrer votre choix : ");


                choix = (int.Parse(Console.ReadLine()));
                Console.WriteLine("");


                if (choix == 1)
                {

                    if (j >= 1)
                    {
                        joueur.soin();
                        Console.WriteLine("Vous pouvez vous soigner encore " + (j - 1) + " fois");
                    }
                    else
                    {
                        Console.WriteLine("Vous pouvez plus vous soigner !");
                    }
                    j--;

                }
                else if (choix == 2)
                {
                    ennemi1.attaque(joueur.nom);
                    ennemi1.subit_attaque();
                }
                else if (choix == 3)
                {
                    ennemi2.attaque(joueur.nom);
                    ennemi2.subit_attaque();
                }
                else if (choix == 4)
                {
                    Console.WriteLine("Game Over");
                    Console.ReadKey();
                }

                Console.WriteLine("\n===Les ennemis ripostent===\n");

                if (ennemi1.points_de_vie > 0)
                {
                    Console.WriteLine(ennemi1.nom + " attaque : \n");
                    joueur.attaque(ennemi1.nom); //le joueur se fait attaquer par balrog
                    joueur.subit_attaque();  //le joueur subit l'attaque de balrog
                }
                else
                {
                    Console.WriteLine(ennemi1.nom + " est mort");
                }

                if (ennemi2.points_de_vie > 0)
                {
                    Console.WriteLine("\n" + ennemi2.nom + " attaque : \n");
                    joueur.attaque(ennemi2.nom);
                    joueur.subit_attaque();
                }
                else
                {
                    Console.WriteLine(ennemi2.nom + " est mort");
                }

                if (joueur.points_de_vie == 0)
                {
                    Console.WriteLine("Game Over");
                    Console.ReadKey();
                }
                if ((ennemi1.points_de_vie == 0) && (ennemi2.points_de_vie == 0))
                {
                    Console.WriteLine("Vous avez gagné !");
                    Console.ReadKey();
                }

            }
        }
    }
}
