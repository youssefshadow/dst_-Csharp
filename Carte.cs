using System;
using System.Collections.Generic;

namespace Devoir_maison_Youssef_benslimane
{
    public class Carte
    {
        public string Valeur { get; set; }
        public string Couleur { get; set; }

        // Constructeur pour créer une carte avec une valeur et une couleur
        public Carte(string valeur, string couleur)
        {
            Valeur = valeur;
            Couleur = couleur;
        }

        // Méthode pour afficher une carte sous forme de chaîne avec des couleurs
        public override string ToString()
        {
            // Si la carte est un Joker, on ne met pas de couleur
            if (Valeur == "Joker")
            {
                // Utilisation d'une couleur distincte pour le Joker
                Console.ForegroundColor = ConsoleColor.Magenta;
                return Valeur; // Joker reste sans couleur spéciale
            }

            // Appliquer la couleur en fonction de la couleur de la carte
            if (Couleur == "Cœur" || Couleur == "Carreau") // Cartes rouges
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else // Cartes noires (Pique, Trèfle) avec une autre couleur pour les rendre distinctes
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            return $"{Valeur} de {Couleur}";
        }

        // Comparaison pour trouver la carte dans une liste
        public override bool Equals(object obj)
        {
            return obj is Carte carte && carte.Valeur == Valeur && carte.Couleur == Couleur;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Valeur, Couleur);
        }

        // Fonction pour construire le deck de cartes
        public static List<Carte> BuildDeck()
        {
            List<string> valeurs = new List<string> { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valet", "Reine", "Roi" };
            List<string> couleurs = new List<string> { "Cœur", "Pique", "Trèfle", "Carreau" };

            List<Carte> cartes = new List<Carte>();

            // Ajouter le Joker
            cartes.Add(new Carte("Joker", ""));

            // Ajouter les cartes avec les valeurs et couleurs
            foreach (var valeur in valeurs)
            {
                foreach (var couleur in couleurs)
                {
                    cartes.Add(new Carte(valeur, couleur));
                }
            }

            return cartes;
        }

        // Fonction pour obtenir la carte initiale de l'utilisateur
        public static Carte GetCarteInitiale(List<Carte> cartes)
        {
            string carteInitiale;
            while (true)
            {
                Console.WriteLine("Sélectionnez une carte parmi le jeu (ex: As de Cœur, Joker, 10 de Pique) : ");
                carteInitiale = Console.ReadLine();

                // Vérifier si la carte entrée est valide
                Carte carteTrouvee = cartes.Find(c => c.ToString().Equals(carteInitiale, StringComparison.OrdinalIgnoreCase));
                if (carteTrouvee != null)
                {
                    return carteTrouvee;
                }
                else
                {
                    Console.WriteLine("Carte invalide. Veuillez entrer une carte valide (ex: As de Cœur, Joker, 10 de Pique).");
                }
            }
        }

        // Fonction pour obtenir le nombre de cartes à passer
        public static int GetNombreDeCartes()
        {
            int nombreDeCartes;
            while (true)
            {
                Console.WriteLine("Entrez un nombre positif de cartes à passer : ");
                if (int.TryParse(Console.ReadLine(), out nombreDeCartes) && nombreDeCartes > 0)
                {
                    return nombreDeCartes;
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre valide et positif.");
                }
            }
        }
    }
}
