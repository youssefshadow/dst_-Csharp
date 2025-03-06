using System;
using System.Collections.Generic;
using Devoir_maison_Youssef_benslimane;

namespace Devoir_maison_Youssef_benslimane
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                
                Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.BackgroundColor = ConsoleColor.Black; 

                // Afficher le menu pour choisir un exercice
                Console.Clear(); 
                Console.WriteLine("Sélectionnez un exercice à lancer :");

                // Réinitialiser la couleur du texte à la couleur par défaut
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1. Jeu de cartes");
                Console.WriteLine("2. Exercice des chiffres");
                Console.WriteLine("3. Exercice du carré évidé");
                Console.WriteLine("4. Exercice des chaînes de caractères");
                Console.WriteLine("0. Quitter");

                string choix = Console.ReadLine();

                // Vérifier si l'utilisateur a fait un choix valide
                switch (choix)
                {
                    case "1":
                        LancerJeuDeCartes();
                        break;

                    case "2":
                        LancerExerciceChiffres();
                        break;

                    case "3":
                        LancerExerciceCarreEvide();
                        break;

                    case "4":
                        LancerExerciceChainesDeCaracteres();
                        break;

                    case "0":
                        continuer = false;
                        Console.WriteLine("Fin du programme.");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.WriteLine("Choix invalide. Veuillez entrer un numéro valide.");
                        Console.ResetColor(); 
                        break;
                }

                // Demander à l'utilisateur s'il veut continuer après chaque exercice
                if (continuer)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; 
                    Console.WriteLine("Voulez-vous continuer ? (O/N)");
                    string reponse = Console.ReadLine().ToUpper();
                    if (reponse != "O")
                    {
                        continuer = false;
                        Console.WriteLine("Fin du programme.");
                    }
                }

                Console.ResetColor(); 
            }
        }

        static void LancerJeuDeCartes()
        {
            var cartes = Carte.BuildDeck();
            Console.WriteLine("Jeu de cartes complet :");
            foreach (var carte in cartes)
            {
                Console.WriteLine(carte.ToString());
            }

            Carte carteInitiale = Carte.GetCarteInitiale(cartes);
            int nombreDeCartes = Carte.GetNombreDeCartes();
            int positionInitiale = cartes.IndexOf(carteInitiale);
            int positionFinale = (positionInitiale + nombreDeCartes) % cartes.Count;

            Console.WriteLine($"La carte sur laquelle vous tomberez est : {cartes[positionFinale]}");
        }

        static void LancerExerciceChiffres()
        {
            var exerciceChiffres = new Chiffres();
            exerciceChiffres.DemanderEtCalculer();
        }

        static void LancerExerciceCarreEvide()
        {
            var exerciceCarre = new CarreEvide();
            exerciceCarre.DemanderDimensions();
        }

        static void LancerExerciceChainesDeCaracteres()
        {
            var exerciceChaines = new Exercice4ChainesDeCaracteres();
            exerciceChaines.DemanderEtTraiterMots();
        }
    }
}
