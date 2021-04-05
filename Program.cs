/*
Programme        : Program.cs
Date de création : 05/04/2021 TC 
Description      : Programme pour le jeux du gobelet
Dernière modif   : 05/04/2021 TC 
*/

using System;

namespace jeux_du_gobelet
{
    // Variable d'instance
    public class Joueur
    {
        // Variable pour le nom
        public string Name  
        {
            get; set;
        }
        
        // Variable pour la mise 
        public int Mise 
        {
            get; set;
        }

        // Variable pour le numero du gobelet
        public int Gobelet 
        {
            get; set;
        }


        // Constructeur de la class Joueur
        public Joueur(string name, int mise, int gobelet)
        {
            Name = name;
            Mise  = mise;
            Gobelet = gobelet;
        }
    }

    
    class Gobelet
    {
        private bool Jeton = false;

        public Gobelet()
        {
            Jeton = false;
        }
    }

    class Jeu
    {
        int[] tableau_joueur = new int[5];
        int[] tableau_gobelet = new int[5];
        
        public Jeu (int nombre_joueur, int nombre_gobelet)
        {
            this.tableau_gobelet = new Gobelet [nombre_gobelet];
            int win = new Random().Next(0, nombre_gobelet);

            for (int i=0; i<nombre_gobelet; i++)
            {
                this.gobelet[i] = i == win ? Gobelet.gagnant() : Gobelet.vide();
            }

            this.joueur = new Joueur [nombre_joueur];
            this.humain = new Random().Next(0, nombre_joueur);
            
            for (int i = 0; i < nombre_joueur; i++)
            {
                if (i != humain)
                {
                    this.Joueur[i] = new Joueur("Robot " + i.ToString(), new Random().Next(1, mise_max), new Random().Next(0, nombre_gobelet));
                }
                else
                {
                    this.joueur[i] = new Joueur("Temp", 0, -1);
                }
            }

            Console.WriteLine("Le montnatn du gro slot est de  " + GrosLot().ToString());
            Console.WriteLine("Paris par gobelets : " + StringParisParGobelets());
            
            int humain_mise = -1;
            int humain_gobelet = -1;

            Console.WriteLine("Quel est votre nom ?");
            string humain_nom = Console.ReadLine();

            while (humain_mise <0 || humain_mise > mise_max)
            {
                Console.WriteLine("Saisir votre mise: ");
                humain_mise = Convert.ToInt32(Console.ReadLine());
            } 

            while (humain_gobelet <0 || humain_gobelet > nombre_gobelet-1)
            {
                Console.WriteLine("choisir un gobelet: ");
                humain_gobelet = Convert.ToInt32(Console.ReadLine());
            } 

            this.joueur[huamin] = new Joueur(humain_nom, humain_mise, humain_gobelet);

            

    
        }
        public void Resultat()
        {
            bool [] gagnants = Gagnants();
            int [] parisârgobelet = ParisParGobelets();
            int gobelet_gagnants = gobelet_gagnants();
            int gain = GrosLot()/TotalParisGagnants();

            Console.WriteLine("Les gagnants ont joué le gobelet : " + gobelets_gagnant.ToString());
            
        }
    }

    class Program
    {
        static void Main()
        {
            Joueur joueur1 = new Joueur("Theo", 10, 5);
            Console.WriteLine("le joueur 1 s'appelle = {0} et mise = {1} sur le Gobelet = {2}", joueur1.Name, joueur1.Mise, joueur1.Gobelet);

            //On déclare un deuxieme joueur et on lui affect les paramètre du joueur numero 1 
            Joueur joueur2 = joueur1;

            joueur2.Name = "Bernard";
            joueur2.Mise = 40;
            joueur2.Gobelet = 4;

            Console.WriteLine("le joueur 2 s'appelle = {0} et mise = {1} sur le Gobelet = {2}", joueur2.Name, joueur2.Mise, joueur2.Gobelet);

            Console.WriteLine("Appuyer sur une touche pour fermer le programme");
            Console.ReadKey();
        }
    }

}