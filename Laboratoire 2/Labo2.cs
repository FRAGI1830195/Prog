using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_2
{
    public enum Couleur { Coeur = 1, Pique = 2, Carreau = 3, Trèfle = 4 };
    public enum Valeur { Deux = 1, Trois = 2, Quatre = 3, Cinq = 4 , Six = 5, Sept = 6, Huit = 7, Neuf = 8, Dix = 9, Valet = 10, Dame = 11, Roi = 12, As = 13};
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
                tabCarte[0] = new Carte((Couleur)generateur.Next(1, 5), (Valeur)generateur.Next(1, 14));
                tabCarte[1] = new Carte((Couleur)generateur.Next(1, 5), (Valeur)generateur.Next(1, 14));
                tabCarte[2] = new Carte((Couleur)generateur.Next(1, 5), (Valeur)generateur.Next(1, 14));
                nbvie = _nbvie;
            }
        }
        /*----------------------------------------------------------------*/
        //  structure Carte
        public struct Carte
        {
            public Couleur couleur;
            public Valeur valeur;

            public Carte(Couleur _couleur, Valeur _valeur) : this()
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
                tabCarte[0] = new Carte((Couleur)generateur.Next(1, 5), (Valeur)generateur.Next(1, 14));
                tabCarte[1] = new Carte((Couleur)generateur.Next(1, 5), (Valeur)generateur.Next(1, 14));
                tabCarte[2] = new Carte((Couleur)generateur.Next(1, 5), (Valeur)generateur.Next(1, 14));
                nbvie = _nbvie;
            }
        }
        static void Main(string[] args)
        {
            Joueur lesCartes = new Joueur();
        }
    }
}
