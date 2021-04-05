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
        public int  Mise 
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

    class Program
    {
        static void Main()
        {
            Joueur joueur1 = new Joueur("theo", 10, 5);
            Console.WriteLine("joueur1 Name = {0} Mise = {1} Gobelet = {3}", joueur1.Name, joueur1.Mise, joueur1.Gobelet);

            //On déclare un deuxieme joueur et on lui affect les paramètre du joueur numero 1 
            Joueur joueur2 = joueur1;

            joueur2.Name = "Bernard";
            joueur2.Mise = 40;
            joueur2.Gobelet = 4;

            Console.WriteLine("joueur2 Name = {0} Mise = {1} Gobelet = {3}", joueur2.Name, joueur2.Mise, joueur2.Gobelet);
            Console.WriteLine("joueur1 Name = {0} Mise = {1} Gobelet = {3}", joueur1.Name, joueur1.Mise, joueur1.Gobelet);

            Console.WriteLine("Appuyer sur une touche pour fermer le programme");
            Console.ReadKey();
        }
    }

}