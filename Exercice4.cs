using System;
using System.Collections.Generic;

namespace Devoir_maison_Youssef_benslimane
{
    public class Exercice4ChainesDeCaracteres
    {
        public void DemanderEtTraiterMots()
        {
            List<string> mots = new List<string>();
            string mot;

            // Demander à l'utilisateur de saisir des mots jusqu'à ce qu'il appuie sur Echap
            Console.WriteLine("Entrez des mots (appuyez sur Echap pour quitter) :");

            while ((mot = Console.ReadLine()) != null && mot != "")
            {
                if (mot == "\u001b") // Vérifier si la touche Échap est appuyée
                    break;

                mots.Add(mot);
            }

            // Afficher les mots dans l'ordre inverse avec les traitements
            Console.WriteLine("\nMots traités dans l'ordre inverse :");

            for (int i = mots.Count - 1; i >= 0; i--)
            {
                string motTraite = TraiterMot(mots[i]);
                Console.WriteLine(motTraite);
            }
        }

        // Méthode pour traiter chaque mot selon les règles spécifiées
        private string TraiterMot(string mot)
        {
            // Suppression des "?"
            mot = mot.Replace("?", "");

            // Si la longueur du mot est paire, remplacer les "E" par "!"
            if (mot.Length % 2 == 0)
            {
                mot = mot.Replace("E", "!");
            }

            // Remplacer les chiffres par des "#"
            char[] caracteres = mot.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (Char.IsDigit(caracteres[i]))
                {
                    caracteres[i] = '#';
                }
            }

            return new string(caracteres);
        }
    }
}
