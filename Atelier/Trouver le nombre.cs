using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trouver_le_nombre
{
    class Program
    {
        static void ChoisirNiveau()
        {
            Console.WriteLine("Facile - 1 à 100 [Taper 1]");
            Console.WriteLine("Moyen - 1 à 1000 [Taper 2]");
            Console.WriteLine("Difficile - 1 à 10000 [Taper 3]");
        }
        static void Main(string[] args)
        {
            ChoisirNiveau();
            int choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    int valeurATrouver = new Random().Next(1, 101);
                    int nombreDeCoups = 0;
                    bool trouve = false;
                    Console.WriteLine("Veuillez saisir un nombre compris entre 1 et 100 (100 inclus)");
                    while (!trouve)
                    {
                        string saisie = Console.ReadLine();
                        int valeurSaisie;
                        if (int.TryParse(saisie, out valeurSaisie))
                        {
                            if (valeurSaisie == valeurATrouver)
                                trouve = true;
                            else
                            {
                                if (valeurSaisie < valeurATrouver)
                                    Console.WriteLine("Trop petit ...");
                                else
                                    Console.WriteLine("Trop grand ...");
                            }
                            nombreDeCoups++;
                        }
                        else
                            Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
                    }   Console.WriteLine("Vous avez trouvé en " + nombreDeCoups + " coup(s)"); break;
                case 2:
                    int valeurATrouve = new Random().Next(1, 1001);
                    int nombreDeCoup = 0;
                    bool trouver = false;
                    Console.WriteLine("Veuillez saisir un nombre compris entre 1 et 1000 (1000 inclus)");
                    while (!trouver)
                    {
                        string saisie = Console.ReadLine();
                        int valeurSaisie;
                        if (int.TryParse(saisie, out valeurSaisie))
                        {
                            if (valeurSaisie == valeurATrouve)
                                trouver = true;
                            else
                            {
                                if (valeurSaisie < valeurATrouve)
                                    Console.WriteLine("Trop petit ...");
                                else
                                    Console.WriteLine("Trop grand ...");
                            }
                            nombreDeCoup++;
                        }
                        else
                            Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
                    }
                    Console.WriteLine("Vous avez trouvé en " + nombreDeCoup + " coup(s)"); break;

                case 3:
                    int valeurATrouV = new Random().Next(1, 10001);
                    int nombreDeCps = 0;
                    bool trouV = false;
                    Console.WriteLine("Veuillez saisir un nombre compris entre 1 et 10000 (10000 inclus)");
                    while (!trouV)
                    {
                        string saisie = Console.ReadLine();
                        int valeurSaisie;
                        if (int.TryParse(saisie, out valeurSaisie))
                        {
                            if (valeurSaisie == valeurATrouV)
                                trouV = true;
                            else
                            {
                                if (valeurSaisie < valeurATrouV)
                                    Console.WriteLine("Trop petit ...");
                                else
                                    Console.WriteLine("Trop grand ...");
                            }
                            nombreDeCps++;
                        }
                        else
                            Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
                    }
                    Console.WriteLine("Vous avez trouvé en " + nombreDeCps + " coup(s)"); break;
            } 

        }
    }
}
