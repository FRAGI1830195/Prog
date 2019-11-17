using System;
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
                nbvie = 3;
            }
        }

        static void AfficherOptions()
        {
            Console.WriteLine("OPTION 1 - Je prends une nouvelle carte et je m'en débarrasse d'une de mon jeu");
            Console.WriteLine("OPTION 2 - Je prends la carte retournée dans la pile et je me débarrasse d'une carte de mon jeu");
            Console.WriteLine("OPTION 3 - J'ai plus de 21 points, j'annonce donc que c'est le dernier tour");
        }
        static void CalculerScore(ref Carte [] tabCarte)
        {
            cpt = 0;
            pts = 0;

            cpt++;
        }
        static void InitialiserJeu(ref Carte[] tabCarte) 
        {
            int j,k, l = 0;
            for (int j=1; j<14;j++)
            {
                for (k=1;k<5;k++)
                {
                    tabCarte[l].valeur = j;
                    tabCarte[l].type = k;
                    l++;
                }
            }
        }
        static void Main(string[] args)
        {
            cpt, pts = 0;
            InitialiserJeu();
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

            int options = Convert.ToInt32(Console.ReadLine());

            switch (options)
            {
                case 1: ;break;
                case 2: ;break;
                case 3: ;break;
                default: Console.WriteLine("Option invalide"); break;
            }

            Console.WriteLine("Tour du Joueur 1");
            AfficherOptions();

            Console.WriteLine("Tour du Joueur 2");
            AfficherOptions();

            Console.WriteLine("Manche terminée");

            CalculerScore();
            string gagnant, perdant;
            Console.WriteLine("Le joueur " + gagnant + " a remporté la partie, et le joueur " + perdant + " a perdu");
        } 
    }
}
