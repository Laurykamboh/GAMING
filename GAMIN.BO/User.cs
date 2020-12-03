using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMIN.BO
{
    public class User
    {
        public string Matricule { get; set; }
        public string Pseudo { get; set; }
        public int Score
        {
            get; set;
        }
            public int Highscore { get; set; }

        public User()
        {

        }
        public User(string matricule, string pseudo, int score, int highscore)
        {
            Matricule = matricule;
            Pseudo = pseudo;
            Score = score;
            Highscore = highscore;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   User.Equals(user.Matricule, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }

    }
}
