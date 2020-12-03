using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMING.cons
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "o";
            do
            {
                Console.WriteLine("..................Creer un etudiant..............");
                Console.Write("Entrer le matricule : \t");
                string Matricule = Console.ReadLine();
                Console.Write("Entrer le pseudo: \t");
                string Pseudo = Console.ReadLine();
                Console.Write("Entrer le score: \t");
                int Score = int.Parse(Console.ReadLine());
                Console.Write("Entrer le Highscore: \t");
                int Highscore = int.Parse(Console.ReadLine());

                UserBLO userBLO = new UserBLO(ConfigurationManager.AppSettings["DbFolder"]);
                User user = new User(Matricule, Pseudo, Score, Highscore);

                userBLO.CreateUser(user);

                IEnumerable<User> users = userBLO.GetAllUsers();
                foreach (User e in users)
                {
                    Console.WriteLine($"{e.Matricule}\t{e.Pseudo}");
                }

                Console.Write("Creer un autre utilisateur?[o/n]:");


                //etudiants = etudiantBLO.GetAllEtudiants();
                //foreach (Etudiant e in etudiants)
                //{
                //  Console.WriteLine($"{e.Matricule}\t{e.Nom}");
                //}

                choice = Console.ReadLine();
            } while (choice.ToLower() == "o");

            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
