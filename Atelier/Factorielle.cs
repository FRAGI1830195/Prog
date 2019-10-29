using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_Factorielle 
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb, factorielle = 1, i;

            Console.WriteLine("Quel est le nombre ?");
            nb = int.Parse(Console.ReadLine());

            if (nb < 0)
            {
                Console.WriteLine("Il n'existe pas de factorielles pour les nombres négatifs");

            }
            else if (nb == 0)
            {
                Console.WriteLine("La factorielle de 0 est 1");
            }
            else
            {
                for(i = nb; i >= 1; i--)
                {
                    factorielle = factorielle * i; 
                }
                Console.WriteLine("Le factoriel de {0} est {1}", nb.ToString(), factorielle.ToString());
            }
            Console.ReadLine();



        }  

    }
}
