using System;

namespace Devoir_maison_Youssef_benslimane
{
    public class CarreEvide
    {
        // Méthode pour demander les dimensions du carré et afficher le résultat
        public void DemanderDimensions()
        {
            Console.WriteLine("Entrez la longueur du carré : ");
            int longueur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez l'épaisseur du carré : ");
            int epaisseur = Convert.ToInt32(Console.ReadLine());

            // Vérifier si les dimensions sont valides
            if (longueur < 2 || epaisseur < 1 || epaisseur >= longueur)
            {
                Console.WriteLine("Dimensions invalides. La longueur doit être supérieure à l'épaisseur et l'épaisseur doit être positive.");
                return;
            }

            AfficherCarreEvide(longueur, epaisseur);
        }

        // Méthode pour afficher le carré évidé
        private void AfficherCarreEvide(int longueur, int epaisseur)
        {
            for (int i = 0; i < longueur; i++)
            {
                for (int j = 0; j < longueur; j++)
                {
                    // Vérifier si c'est un bord ou à l'intérieur du carré
                    if (i < epaisseur || i >= longueur - epaisseur || j < epaisseur || j >= longueur - epaisseur)
                    {
                        // Appliquer une couleur différente pour les bords
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                    else
                    {
                        // Appliquer une autre couleur pour l'intérieur
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Réinitialiser la couleur du texte après l'affichage du carré
            Console.ResetColor();
        }
    }
}
