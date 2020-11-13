using System;

namespace Projet_B1.C2.Séq1_S3
{
    class Programm
    {
        static void Main(string[] args)
        {

            // Taille du tableau 
            int taille = 365;
            

            // Tableaud des température
            float[] t = new float[taille];

            // daidie des températures et cumul
            float moyenne = 0;
            
            for (int k = 0; k < taille; k++)
            
            {
                Console.Write("Entrez la température n°" + (k + 1) + "=");
                t[k] = float.Parse(Console.ReadLine());
                moyenne += t[k];


            }
            // calcule de la moyenne 
            moyenne = moyenne / taille;

            // calcule du nombre de températures au dessus de la moyenne 
            int nbsup = 0;
            for (int k = 0; k < taille; k++)
            {
                if (t[k] > moyenne)
                {
                    nbsup++;
                }
            }
            // affichage du résultat 
            Console.WriteLine("Voici le nombre de témperature au dessus de la moyenne :"
                + nbsup);
        }
    }
}