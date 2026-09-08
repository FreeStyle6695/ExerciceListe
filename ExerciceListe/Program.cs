using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceListe
{
    internal class Program
    {
        //Exercice 1, 2 & 5 : Créez une liste de prénoms et affichez-les à l'écran. Ensuite,
        //demandez à l'utilisateur d'ajouter un prénom à la liste et affichez la liste mise à jour + retour de position si présent.
        static void Main(string[] args)
        {
            var program = new Program();
            program.Exercice125();
            //program.Exercice34();
        }

        public void Exercice125()
        {
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Jacques");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("entrez un prénom à ajouter à la liste");
            string newName = Console.ReadLine();
            if (!names.Contains(newName))
            {
                names.Add(newName);
                Console.WriteLine("Liste mise à jour :");
            }
            else
            {
                Console.WriteLine("Prénom déjà dans la liste");
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("tapez un prénom à rechercher dans la liste");
            string nameToSearch = Console.ReadLine();
            if (names.Contains(nameToSearch))
            {
                int position = names.IndexOf(nameToSearch) + 1;

                Console.WriteLine($"Prénom {nameToSearch} trouvé dans la liste à la position {position} ");
            }
            else
            {
                Console.WriteLine($"Prénom {nameToSearch} introuvable dans la liste : ");
            }
        }

        //Exercice 3 & 4
        public void Exercice34()
        {
            Random myObject = new Random();
            List<int> randomNumber = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int ranNum = myObject.Next(1, 101);
                //int ranNum = Random.Shared.Next(1, 101);
                if (!randomNumber.Contains(ranNum))
                {
                    randomNumber.Add(ranNum);
                    Console.WriteLine($"numéro ajouté à la liste : {ranNum}");
                }
                else
                {
                    Console.WriteLine($"numéro déjà dans la liste : {ranNum}");
                }
            }
            foreach (int number in randomNumber)
            {
                Console.WriteLine(number);
            }
            randomNumber.Sort();
            Console.WriteLine("Liste triée :");
            foreach (int number in randomNumber)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("entrez un numéro à supprimer de la liste");
            int numberToRemove = int.Parse(Console.ReadLine());
            if (randomNumber.Contains(numberToRemove))
            {
                randomNumber.Remove(numberToRemove);
                Console.WriteLine($"numéro supprimé de la liste : {numberToRemove}");
            }
            else
            {
                Console.WriteLine($"numéro non trouvé dans la liste : {numberToRemove}");
            }
            foreach (int number in randomNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}
