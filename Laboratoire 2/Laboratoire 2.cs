using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_2
{
    public enum Couleur { Coeur = 1, Pique = 2, Carreau = 3, Trèfle = 4 };
    class Program
    {
        static Random generateur = new Random();
        /*-----------------------------------------------------------------*/
        // structure Ordinateur (le jeu se déroule entre un joueur et un ordinateur)
        public struct Ordi
        {
            public Carte[] tabCarte;
            public int nbvie;

            public Ordi(int _nbvie) : this()
            {
                tabCarte = new Carte[3];
                tabCarte[0] = new Carte((Couleur)generateur.Next(1, 5), generateur.Next(1, 14));
                tabCarte[1] = new Carte((Couleur)generateur.Next(1, 5), generateur.Next(1, 14));
                tabCarte[2] = new Carte((Couleur)generateur.Next(1, 5), generateur.Next(1, 14));
                nbvie = _nbvie;
            }
        }
        /*----------------------------------------------------------------*/
        //  structure Carte
        public struct Carte
        {
            public Couleur couleur;
            public int valeur;

            public Carte(Couleur _couleur, int _valeur) : this()
            {
                couleur = _couleur;
                valeur = _valeur;
            }
        }
        /*-----------------------------------------------------------------*/
        // structure Joueur 
        public struct Joueur
        {
            public Carte[] tabCarte;
            public int nbvie;

            public Joueur(int _nbvie) : this()
            {
                tabCarte = new Carte[3];
                tabCarte[0] = new Carte((Couleur)generateur.Next(1, 5), generateur.Next(1, 14));
                tabCarte[1] = new Carte((Couleur)generateur.Next(1, 5), generateur.Next(1, 14));
                tabCarte[2] = new Carte((Couleur)generateur.Next(1, 5), generateur.Next(1, 14));
                nbvie = _nbvie;
            }
        }
        static void Main(string[] args)
        {
            Joueur lesCartes = new Joueur();

            int valeurCarte = generateur.Next(1, 14);
            switch (valeurCarte)
            {
                case 1: Console.WriteLine(valeurCarte.ToString()); break;
                case 2: Console.WriteLine(valeurCarte.ToString()); break;
                case 3: Console.WriteLine(valeurCarte.ToString()); break;
                case 4: Console.WriteLine(valeurCarte.ToString()); break;
                case 5: Console.WriteLine(valeurCarte.ToString()); break;
                case 6: Console.WriteLine(valeurCarte.ToString()); break;
                case 7: Console.WriteLine(valeurCarte.ToString()); break;
                case 8: Console.WriteLine(valeurCarte.ToString()); break;
                case 9: Console.WriteLine(valeurCarte.ToString()); break;
                case 10: Console.WriteLine("Valet"); break;
                case 11: Console.WriteLine("Dame"); break;
                case 12: Console.WriteLine("Roi"); break;
                case 13:  Console.WriteLine("As"); break;
            }
        }
    }
}
