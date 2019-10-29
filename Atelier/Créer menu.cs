using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2_MenuAvecTableau
{
    class Program
    {
        static void AfficherMenu()
        {
            Console.WriteLine("1- Trouver le nombre le plus grand");
            Console.WriteLine("2- Trouver le nombre le plus petit");
            Console.WriteLine("3- Vérifier si le nombre saisi existe");
            Console.WriteLine("4- Faire la moyenne");
            Console.WriteLine("5- Quitter le programme");
        }

        static void Main(string[] args)
        {
            int choix = 0;

            AfficherMenu();
            choix = Convert.ToInt32(Console.ReadLine());

            int[] myArray = new int[300];
            Random nbrandom = new Random();
            for (int i = 0; i < 300; i++)
            {
                myArray[i] = nbrandom.Next(1, 10000);
                Console.WriteLine(myArray[i]);
            }

            switch (choix)
            {
                case 1: int nbmax = myArray.Max(); Console.WriteLine("Le nombre le plus GRAND est " + nbmax); break;
                case 2: int nbmin = myArray.Min(); Console.WriteLine("Le nombre le plus PETIT est " + nbmin); break;
                case 3:
                    Console.WriteLine("Taper le nombre à vérifier");
                    int nb = Convert.ToInt32(Console.ReadLine());
                    bool nbexist = myArray.Contains(nb);

                    if (nbexist == true)
                    {
                        Console.WriteLine("Le nombre " + nb + " existe dans le tableau");
                    }
                    else
                    {
                        Console.WriteLine("Le nombre " + nb + " n'existe pas dans le tableau");
                    }
                    break;
                case 4: double moy = myArray.Average(); Console.WriteLine("La moyenne du tableau est " + moy); break;
                case 5: Console.WriteLine("Appuyer sur la touche P pour quitter le programme"); while (Console.ReadKey().Key != ConsoleKey.P) ; break;
            }
        }
    }
}
