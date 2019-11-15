﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_2
{
    public enum Type { Coeur = 1, Pique = 2, Carreau = 3, Trèfle = 4 };
    class Program
    {
        static Random generateur = new Random();
        /*----------------------------------------------------------------*/
        //  structure Carte
        public struct Carte
        {
            public Type type;
            public int valeur;

            public Carte(Type _type, int _valeur) : this()
            {
                type = _type;
                valeur = _valeur;
            }
        }
        /*-----------------------------------------------------------------*/
        // structure Joueur
        public struct Joueur
        {
            public Carte[] tabCarte;
            public int nbvie ;

            public Joueur(int _nbvie) : this()
            {
                tabCarte = new Carte[3];
                tabCarte[0] = new Carte((Type)generateur.Next(1, 5), generateur.Next(1, 14));
                tabCarte[1] = new Carte((Type)generateur.Next(1, 5), generateur.Next(1, 14));
                tabCarte[2] = new Carte((Type)generateur.Next(1, 5), generateur.Next(1, 14));
                nbvie = _nbvie = 3;
            }
        }
        static void Main(string[] args)
        {
            string valeur = Convert.ToString(Console.ReadLine());
            switch (valeur)
            {
                case 1: Console.WriteLine(valeur.ToString()); break;
                case 2: Console.WriteLine(valeur.ToString()); break;
                case 3: Console.WriteLine(valeur.ToString()); break;
                case 4: Console.WriteLine(valeur.ToString()); break;
                case 5: Console.WriteLine(valeur.ToString()); break;
                case 6: Console.WriteLine(valeur.ToString()); break;
                case 7: Console.WriteLine(valeur.ToString()); break;
                case 8: Console.WriteLine(valeur.ToString()); break;
                case 9: Console.WriteLine(valeur.ToString()); break;
                case 10: Console.WriteLine("Valet"); break;
                case 11: Console.WriteLine("Dame"); break;
                case 12: Console.WriteLine("Roi"); break;
                case 13: Console.WriteLine("As"); break;
            }

            Joueur CartesJ1 = new Joueur { CartesJ1.tabCarte[] };
            Console.WriteLine(CartesJ1, CartesJ1.nbvie);

            Joueur CartesJ2 = new Joueur { cartesJ2.tabcarte[] };
            Console.WriteLine(CartesJ2, CartesJ2.nbvie);

            int cartesTot = 46;
            Console.WriteLine("(Il reste " + cartesTot + " cartes disponibles)");
        }
    }
}