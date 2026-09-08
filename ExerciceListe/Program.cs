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
            //program.Exercice125();
            //program.Exercice34();
            //program.Exercice67();
            //program.Exercice8();
            //program.Exercice9();
            program.Exercice10();
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
        public void Exercice67()
        {
            Dictionary<string, string> myLand = new Dictionary<string, string>();
            myLand.Add("FR", "France");
            myLand.Add("DE", "Allemagne");
            myLand.Add("IT", "Italie");
            myLand.Add("ES", "Espagne");
            myLand.Add("PT", "Portugal");
            myLand.Add("BE", "Belgique");
            myLand.Add("NL", "Pays-Bas");
            myLand.Add("CH", "Suisse");

            foreach (var land in myLand)
            {
                Console.WriteLine($"Code pays : {land.Key} - Pays : {land.Value}");
            } Console.WriteLine();

            Console.WriteLine("entrez un code pays à rechercher dans la liste");
            string codeToSearch = Console.ReadLine().ToUpper();

            if (myLand.ContainsKey(codeToSearch))
            {
                Console.WriteLine($"le pays correspondant au code {codeToSearch} est {myLand[codeToSearch]}");
            }
        }
        public void Exercice8()
        {
            Dictionary<string, decimal> myProducts = new Dictionary<string, decimal>();
            myProducts.Add("Pomme", 0.5m);
            myProducts.Add("Banane", 0.3m);
            myProducts.Add("Orange", 0.4m);
            myProducts.Add("Cerise", 0.2m);

            foreach (var product in myProducts)
            {
                Console.WriteLine($"{product.Key} est dans le panier");
            }

            Console.WriteLine("Tapez un produit à rechercher dans la liste");
            string productToSearch = Console.ReadLine();

            if (myProducts.ContainsKey(productToSearch))
            {
                Console.WriteLine($"Le produit {productToSearch} est disponible au prix de {myProducts[productToSearch]} euros.");
            }
        }

        public void Exercice9()
        {
            decimal totalPrice = 0;
            Dictionary<string, decimal> myProducts = new Dictionary<string, decimal>();
            myProducts.Add("pomme", 0.5m);
            myProducts.Add("banane", 0.3m);
            myProducts.Add("orange", 0.4m);
            myProducts.Add("cerise", 0.2m);

            foreach (var product in myProducts)
            {
                Console.WriteLine($"{product.Key} est dans le panier");
            }

            while (true)
            {
                Console.WriteLine($"choisissez un produit à ajouter au panier - \"STOP\" pour arrêter");
                string productToAdd = Console.ReadLine();
                if (productToAdd.ToUpper() == "STOP")
                {
                    break;
                }
                totalPrice = totalPrice + myProducts[productToAdd];
            }
            Console.WriteLine($"Le prix total du panier est de {totalPrice} euros.");
        }

        public  void Exercice10()
        {
            Dictionary<string, int> dico = new Dictionary<string, int>();
            Console.WriteLine("entrez un mot ou une phrase");
            string input = Console.ReadLine();
            foreach (var letter in input)
            {
                if (dico.ContainsKey(letter.ToString()))
                {
                    dico[letter.ToString()]++;
                }
                else
                {
                    dico[letter.ToString()] = 1;
                }
            }
            
            foreach (var item in dico.Keys)
            {
                Console.WriteLine($"il y a {dico[item]} fois le mot '{item}'");
            }
        }
    }
}
