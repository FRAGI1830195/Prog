using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_2
{
    public enum Couleur {Coeur = 1, Pique = 2, Carreau = 3, Trèfle = 4};
    class Program
    {
        static Random generateur = new Random();
    /*-----------------------------------------------------------------*/
        // structure Ordinateur
        public struct Ordi
        {
            public Carte [] tabCarte;
            public int nbvie;

          public Ordi (int _nbvie):this()
          {
            tabCarte = new Carte[3];
            tabCarte[0] = new Carte((Couleur)generateur.Next(1,5), generateur.Next(1,14));
            tabCarte[1] = new Carte((Couleur)generateur.Next(1,5), generateur.Next(1,14));
            tabCarte[2] = new Carte((Couleur)generateur.Next(1,5), generateur.Next(1,14));
            nbvie = _nbvie;
          }
        }
    /*----------------------------------------------------------------*/
        //  structure Carte
        public struct Carte
        {
            public Couleur couleur;
            public int valeur;

            public Carte (Couleur _couleur, int _valeur):this()
            {
                couleur = _couleur;
                valeur = _valeur;
            }
        }
    /*--------------------------------------------------------------*/
        static void Main(string[] args)
        {
            int carteJeu = 52, carteJoueur = 52, carteOrdi = 52;
            Console.WriteLine("\nNombres de carte du jeu : " + 52 + "\nCartes du joueur : " + 52 + "\nCartes de l'ordinateur : " + 52);
        }
    }
}
