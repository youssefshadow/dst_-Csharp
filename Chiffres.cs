using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoir_maison_Youssef_benslimane
{

    public class Chiffres
    {
        private HashSet<int> chiffresEntres; // Ensemble pour stocker les chiffres déjà rentrés
        private List<int> chiffresPairs; // Liste pour stocker les chiffres pairs
        private List<int> chiffresImpairs; // Liste pour stocker les chiffres impairs

        public Chiffres()
        {
            chiffresEntres = new HashSet<int>();
            chiffresPairs = new List<int>();
            chiffresImpairs = new List<int>();
        }

        public void DemanderEtCalculer()
        {
            while (true)
            {
                Console.WriteLine("Entrez un chiffre : ");
                string entree = Console.ReadLine();

                try
                {
                    int chiffre = int.Parse(entree);

                    if (chiffresEntres.Contains(chiffre))
                    {
                        // Si un doublon est détecté, on calcule et affiche la somme
                        int sommePairs = 0;
                        int sommeImpairs = 0;

                        // Calcul de la somme des chiffres pairs et impairs sans inclure le doublon
                        foreach (int c in chiffresPairs)
                        {
                            if (c != chiffre) sommePairs += c;
                        }

                        foreach (int c in chiffresImpairs)
                        {
                            if (c != chiffre) sommeImpairs += c;
                        }

                        // Calcul final : somme des pairs - somme des impairs
                        int resultat = sommePairs - sommeImpairs;
                        Console.WriteLine($"Le résultat est : {resultat}");
                        break; // On quitte après un doublon
                    }
                    else
                    {
                        // Si ce n'est pas un doublon, on l'ajoute
                        chiffresEntres.Add(chiffre);

                        if (chiffre % 2 == 0) // Si le chiffre est pair
                            chiffresPairs.Add(chiffre);
                        else // Si le chiffre est impair
                            chiffresImpairs.Add(chiffre);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un chiffre valide.");
                }
            }
        }



    }
}


