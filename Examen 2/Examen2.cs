using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPratique
{
    class Program
    {
        static Random Generateur = new Random();
        public struct Vaisseau
        {
            public string Nom;
            public string Rareté;
            public int Vitesse;
            public int NiveauDeVie;
            public double Prix;
            public Vaisseau(string _Nom, string _Rareté, int _Vitesse, int _NiveauDeVie, double _Prix) : this()
            {
                Nom = _Nom;
                Rareté = _Rareté;
                Vitesse = _Vitesse;
                NiveauDeVie = _NiveauDeVie;
                Prix = _Prix;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string Liste = "";
            Console.WriteLine("Liste des vaisseaux");
            Liste = Console.ReadLine();
            bool finProgramme = false;
            Vaisseau ListeVaisseaux = new Vaisseau(Liste);

            while (finProgramme == false)
            {
                AfficherMenu();
                int choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1: AfficherInfoVaisseau(ref Vaisseau.tabVaisseau); break;
                    case 2: VerifierVaisseauExiste(ref Vaisseau.tabVaisseau); break;
                    case 3: TrouverVaisseauVieEleve(ref Vaisseau.tabVaisseau); break;
                    case 4: AfficherMoyennePrix(ref Vaisseau.tabVaisseau); break;
                    case 5: finProgramme = true; break;
                    default: Console.WriteLine("Ce choix n'existe pas"); break;
                }
            }
            Console.WriteLine("Au revoir");
            Console.ReadKey();
        }
        static void CreerTableau()
        {
            Vaisseau[] tabVaisseau = new Vaisseau[10];
            for (int i = 0; i < tabVaisseau.Length; i++)
            {
                tabVaisseau[i] = new Vaisseau (Generateur.Next(10, 16), Generateur.Next(12, 24), Generateur.Next(23, 44), Generateur.Next(40, 69));
            }
            AfficherInfoVaisseau(ref tabVaisseau);
        }
        static void CreerTableau2()
        {
            tabVaisseau[1] = new Vaisseau(Generateur.Next(10, 16), Generateur.Next(100, 151), Generateur.Next(2000);
            tabVaisseau[2] = new Vaisseau(Generateur.Next(12, 24), Generateur.Next(23,44), Generateur.Next(4500);

        }
        static void AfficherInfoVaisseau(ref Vaisseau[] tabVaisseau)
        {
            for (int i = 0; i < tabVaisseau.Length; i++)
            {
                Console.WriteLine("Vaisseau : " + tabVaisseau[i].Rareté);
            }
        }
        static void AfficherMenu()
        {
            Console.WriteLine("Quel est votre choix ? :");
            Console.WriteLine("1- Afficher les vaisseaux avec toutes les caractéristiques");
            Console.WriteLine("2- Vérifier si un vaisseau légendaire existe");
            Console.WriteLine("3- Trouver le vaisseau avec la vie la plus haute");
            Console.WriteLine("4- Afficher la moyenne des prix des vaisseaux");
            Console.WriteLine("5- Quitter le programme");
        }
        static void AfficherMoyennePrix(ref Vaisseau[] tabVaisseau)
        {
            int Moy = 0, Total = 0;
            for (int i = 0; i < tabVaisseau.Length; i++)
            {
                Total += tabVaisseau[i].Prix;
            }

            Moy = Total / tabVaisseau.Length;
            Console.WriteLine("La moyenne des prix des vaisseaux est de  " + Moy);
        }
        static void VerifierVaisseauExiste(ref Vaisseau[] tabVaisseau)
        {
            bool VaisseauExiste = false;
            int cpt = 0;
            int VaisseauLeg = 0;
            Console.WriteLine("Y a-t-il des vaisseaux légendaires ?");
            VaisseauLeg = Convert.ToInt32(Console.ReadLine());
            while (VaisseauExiste == false && cpt < tabVaisseau.Length)
            {
                if (tabVaisseau[cpt].Rareté == VaisseauLeg)
                {
                    VaisseauExiste = true;
                }
                else
                {
                    cpt++;
                }
            }

            if (VaisseauExiste)
            {
                Console.WriteLine("Il existe un vaisseau légendaire");
            }
            else
            {
                Console.WriteLine("Il n'y en a pas");
            }
        }
        static void TrouverVaisseauVieEleve(ref Vaisseau[] tabVaisseau)
        {
            int VieEleve = 0;
            int indice = 0;
            for (int i = 0; i < tabVaisseau.Length; i++)
            {
                if (tabVaisseau[i].NiveauDeVie > VieEleve)
                {
                    VieEleve = tabVaisseau[i].NiveauDeVie;
                    indice = i;
                }
            }
            Console.WriteLine("Le vaisseau ayant la vie la plus élevée se trouve à l'indice " + (indice + 1));
}   }   }
