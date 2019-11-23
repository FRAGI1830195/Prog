using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] motsCrees = { "yucca", "execrer", "thai", "karma", "aulne", "dubitatif", "hermes", "saturne", "acceder", "glaner" };
            //Liste visuelle : Console.WriteLine(motsCrees[0]+"\n" +motsCrees[1]+"\n" + motsCrees[2] + "\n" + motsCrees[3] +"\n" + motsCrees[4] + "\n" + motsCrees[5] + "\n" + motsCrees[6] + "\n" + motsCrees[7] + "\n" + motsCrees[8] + "\n" + motsCrees[9]);
            int essai = 5;
            string motSecret = motsCrees[4];
            char[] motAffiche = new char[motSecret.Length];

            for (int i = 0; i < motAffiche.Length; i++)
            {
                motAffiche[i] = '_';
            }
            Console.WriteLine("=== BIENVENUE AU JEU DU PENDU ===\nVoici le mot à deviner :");

            bool finJeu = false;

            while (finJeu == false)
            {
                bool lettreTrouvee = false;

                for (int i = 0; i < motAffiche.Length; i++)
                {
                    Console.Write(motAffiche[i] + " ");
                }
                char lettre = ' ';
                lettre = Convert.ToChar(Console.ReadLine());


                for (int i = 0; i < motSecret.Length; i++)
                {
                    if (motSecret[i] == lettre)
                    {
                        motAffiche[i] = lettre;
                        lettreTrouvee = true;
                        Console.WriteLine("La lettre existe dans le mot");
                    }
                }

                if (lettreTrouvee == false)
                {
                    essai--;
                    Console.WriteLine("Cette lettre n'existe pas dans le mot\nIl vous reste " + essai + " essai(s)");

                }

                if (essai == 4)
                {
                    Console.WriteLine("  _______     ");
                    Console.WriteLine(" |       |    ");
                }

                if (essai == 3)
                {
                    Console.WriteLine("  _______     ");
                    Console.WriteLine(" |       |    ");
                    Console.WriteLine(" |       |    ");
                    Console.WriteLine(" |       _    ");
                }

                if (essai == 2)
                {
                    Console.WriteLine("  _______     ");
                    Console.WriteLine(" |       |    ");
                    Console.WriteLine(" |       |    ");
                    Console.WriteLine(" |       _    ");
                    Console.WriteLine(" |      / \\  ");
                    Console.WriteLine(" |      \\_/  ");
                }

                if (essai == 1)
                {
                    Console.WriteLine("  _______     ");
                    Console.WriteLine(" |       |    ");
                    Console.WriteLine(" |       |    ");
                    Console.WriteLine(" |       _    ");
                    Console.WriteLine(" |      / \\  ");
                    Console.WriteLine(" |      \\_/  ");
                    Console.WriteLine(" |      _|_   ");
                    Console.WriteLine(" |     /| |\\ ");
                    Console.WriteLine(" |    / |_| \\");
                }

                if (essai == 0)
                {
                        finJeu = true;
                        Console.WriteLine("Le mot à trouver était : " + motSecret + "\n=== GAME OVER  ===");
                        Console.WriteLine("  _______     ");
                        Console.WriteLine(" |       |    ");
                        Console.WriteLine(" |       |    ");
                        Console.WriteLine(" |       _    ");
                        Console.WriteLine(" |      / \\  ");
                        Console.WriteLine(" |      \\_/  ");
                        Console.WriteLine(" |      _|_   ");
                        Console.WriteLine(" |     /| |\\ ");
                        Console.WriteLine(" |    / |_| \\");
                        Console.WriteLine(" |       ^    ");
                        Console.WriteLine(" |      / \\  ");
                        Console.WriteLine(" |     /   \\ ");
                }                    
            }
        }
    }
}