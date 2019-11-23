using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Exo3
{
    class Program
    {
        static String[] grilleMorpion = new String[9];
        static String jouerEncore = "o";                    // "o" pour "oui" et "n" pour "non"
        static int cpt = 0;

        static void AfficherIntro()
        {
            Console.WriteLine("=== BIENVENUE AU JEU DU TIC-TAC-TOE (MORPION) ===");
            Console.WriteLine("(Appuyer sur la touche ENTRÉE pour continuer)");
            Console.ReadLine();
            Console.Clear();
        }

        static void InitialiserGrille()
        {
            for (int i = 0; i < 9; i++)
            {
                grilleMorpion[i] = i.ToString();
            }
        }

        static void DessinerGrille()
        {
            for (int i = 0; i < 7; i += 3)
                Console.WriteLine(grilleMorpion[i] + "|" + grilleMorpion[i + 1] + "|" + grilleMorpion[i + 2]);
        }

        static void signe(String joueur)
        {
            Console.Clear();
            Console.WriteLine("Joueur: " + joueur);
            int selection;

            while (true)
            {
                Console.WriteLine("Veuillez sélectionner une case");
                DessinerGrille();
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection < 0 || selection > 8 || (grilleMorpion[selection].Equals("X") || grilleMorpion[selection].Equals("O")))
                {
                    Console.WriteLine("Cette case a déjà été utilisée ou n'existe pas !");
                }
                else
                {
                    break;
                }
            }
            grilleMorpion[selection] = joueur;
        }

        static Boolean aGagne()
        {
            for (int i = 0; i < 7; i += 3)
            {
                if (grilleMorpion[i].Equals(grilleMorpion[i + 1]) && grilleMorpion[i + 1].Equals(grilleMorpion[i + 2]))
                {
                    return true;
                }
            }
            if (grilleMorpion[0].Equals(grilleMorpion[3]) && grilleMorpion[3].Equals(grilleMorpion[6]))
                return true;
            if (grilleMorpion[1].Equals(grilleMorpion[4]) && grilleMorpion[4].Equals(grilleMorpion[7]))
                return true;
            if (grilleMorpion[2].Equals(grilleMorpion[5]) && grilleMorpion[3].Equals(grilleMorpion[8]))
                return true;
            if (grilleMorpion[2].Equals(grilleMorpion[4]) && grilleMorpion[4].Equals(grilleMorpion[6]))
                return true;
            if (grilleMorpion[0].Equals(grilleMorpion[4]) && grilleMorpion[4].Equals(grilleMorpion[8]))
                return true;
            return false;
        }

        static void jouerEncoreMsg(String message)
        {
            Console.WriteLine(message + "\nRejouer ?");
            if (Console.ReadLine().Equals("o"))
            { 
                jouerEncore.Equals("o");              
            }
            else
            {
                jouerEncore.Equals("n");
                AfficherQuitter();               
            }               
        }

        static void AfficherQuitter()
        {
            Console.WriteLine("Merci d'avoir joué");
            Environment.Exit(0);          
        }

        static void Main(string[] args)
        {
            AfficherIntro();
            while (jouerEncore.Equals("o"))
            {
                InitialiserGrille();
                while (aGagne() == false && cpt < 9)
                {
                    signe("X");
                    if (aGagne() == true)
                    {
                        break;
                    }                        
                    signe("O");
                }
                if (aGagne() == true)
                {
                    jouerEncoreMsg("Félicitations, tu as gagné !");
                }
                else if (aGagne() == false)
                {
                    jouerEncoreMsg("Match nul !");
                }                 
            }
        }
    }
}