using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Exo1
{
    class Program
    {   static string message = "manger est mieux que de faire la cuisine";
        static string[] tabMessage = message.Split(' ');
        static int[] tabAlphabet = new int[26];
        static int plusGrand = 0;
        
        static void AfficherMenu()
        {
            Console.WriteLine("1 - Afficher le nombre de mots contenus dans la phrase");
            Console.WriteLine("2 - Afficher combien de fois chaque lettre apparaît");
            Console.WriteLine("3 - Afficher la lettre qui apparaît le plus souvent");
            Console.WriteLine("4 - Encoder la phrase en utilisant une clé de +2 et afficher le résultat");
        }

        static void AfficherNombreMots(string[] tabMessage)
        {
            
            Console.WriteLine("Il y a " + tabMessage.Length + " mots dans la phrase");
        }

        static void AfficherFrequenceLettres(string[] tabMessage)
        {
            for (int i = 0; i < message.Length; i++)
            {
                int indice = (int)message[i] - 97;
                if (indice >= 0 && indice < 26)
                    tabAlphabet[indice]++;
            }

            for (int i = 0; i < tabAlphabet.Length; i++)
            {
                Console.WriteLine("La lettre " + (char)(i + 97) + " apparaît " + tabAlphabet[i] + " fois");
            }
        }

        static void AfficherLaLettre(string[] tabMessage)
        {
            for (int i = 0; i < message.Length; i++)
            {
                int indice = (int)message[i] - 97;
                if (indice >= 0 && indice < 26)
                    tabAlphabet[indice]++;
            }
            for (int i = 0; i < tabAlphabet.Length; i++)
            {
                if (tabAlphabet[i] > plusGrand)
                    plusGrand = tabAlphabet[i];
            }
            Console.WriteLine("La lettre apparaissant le plus souvent est la lettre '" + (char)(101) + "' car elle apparaît " + plusGrand + " fois");
        }

        static void CoderMessage()
        {
            string nouveauMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                int valeurAsc = (int)message[i];
                nouveauMessage += Char.ConvertFromUtf32(valeurAsc + 2);
            }
            Console.WriteLine("Voici le message codé : " + nouveauMessage);
        }
        static void Main(string[] args)
        {
            AfficherMenu();
            int choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1: AfficherNombreMots(tabMessage);break;
                case 2: AfficherFrequenceLettres(tabMessage);break;
                case 3: AfficherLaLettre(tabMessage);break;
                case 4: CoderMessage();break;
            }
        }        
    }
}

