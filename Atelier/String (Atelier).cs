using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Atelier
{
    class Program
    {
        static void AfficherMenu()
        {
            Console.WriteLine("1- Longueur de la chaîne de caractères");
            Console.WriteLine("2- Si phrase contient 'octopus'");
            Console.WriteLine("3- Position du premier 'e'");
            Console.WriteLine("4- Affiche une sous-phrase");
            Console.WriteLine("5- Affiche la chaîne en majuscules");
            Console.WriteLine("6- Affiche la chaîne en minuscules");
            Console.WriteLine("7- Fin programme");
        }

        static void Main(string[] args)
        {
            bool finProg = false;
            while (finProg==false)
            {
                AfficherMenu();

                int choix = Convert.ToInt32(Console.ReadLine());
                string messageTxt = "Je>vais>bien>cher>Octopus";

                switch (choix)
                {
                    case 1: Console.WriteLine("Le nombre de caractères est de " + messageTxt.Length); break;
                    case 2: if (messageTxt.Contains("octopus") == true)
                        {
                            Console.WriteLine("Le mot existe");
                        }
                        else
                        {
                            Console.WriteLine("Rien trouvé");
                        }
                        break;
                    case 3: int positionPremierePosition = messageTxt.IndexOf("e"); Console.WriteLine("Position n° " +positionPremierePosition);break;
                    case 4: string[] laSousPhrase = messageTxt.Split('>'); Console.WriteLine("La sous-phrase est : " + laSousPhrase[3] );break;
                    case 5: string messageMajuscule = messageTxt.ToUpper(); Console.WriteLine(messageMajuscule);break;
                    case 6: string messageMinuscule = messageTxt.ToLower(); Console.WriteLine(messageMinuscule); break;
                    case 7: finProg = true;break;
                }
            }
            Console.WriteLine("Adieu cher ami");
            Console.ReadKey();
        }
    }
}
