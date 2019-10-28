using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_Atelier2_Menu_Tableau_Avec_Rajout_Options
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
            Console.WriteLine("6- Un nombre est-il supérieur à 9995 ?");
            Console.WriteLine("7- Un nombre saisi revient-il plus de 3 fois ?");
            Console.WriteLine("8- Vérifier si un nombre saisi existe dans le tableau et donner sa position ?");
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
                case 6:
                    Console.WriteLine("Taper le nombre pour vérifier s'il est plus grand que 9995");
                    int NB = Convert.ToInt32(Console.ReadLine());
                    bool nbExist = myArray.Contains(NB);

                    if (nbExist == true && NB > 9995)
                    {
                        Console.WriteLine(NB + " est effectivement plus grand que 9995");
                    }
                    else
                    {
                        Console.WriteLine(NB + " n'existe pas ET/OU est inférieur à 9995");
                    }
                    break;
                case 7:
                    Console.WriteLine("Taper le nombre pour vérifier s'il apparaît à plus de 3 reprises dans le tableau");
                    int nombre = Convert.ToInt32(Console.ReadLine());
                    bool nbrevient = myArray.Contains(nombre);

                    if (nbrevient == true && nombre > 3)
                    {
                        Console.WriteLine(nombre + " apparaît plus de 3 fois dans le tableau");
                    }
                    else
                    {
                        Console.WriteLine(nombre + " n'apparaît pas plus de 3 fois dans le tableau");
                    }
                    break;
                case 8:
                    Console.WriteLine("Taper le nombre (pour trouver sa position s'il existe) ");
                    int nbr = Convert.ToInt32(Console.ReadLine());
                    bool nbRevient = myArray.Contains(nbr);

                    if (nbRevient == true)
                    {
                        Console.WriteLine(nbr + " existe et se trouve à l'indice " +myArray);
                    }
                    else
                    {
                        Console.WriteLine(nbr + " n'existe pas dans le tableau");
                    }
                    break;
            }
        }
    }
}
