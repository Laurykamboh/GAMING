using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMING.WinForm
{
    class UserListPrint
    {
        public string Matricule { get; set; }
        public string Pseudo { get; set; }
        public int Score { get; set; }
        public int Highscore { get; set; }
     


        public UserListPrint(string matricule, string pseudo, int score, int highscore)
        {
            Matricule = matricule;
            Pseudo = pseudo;
            Score= score;
            Highscore = highscore;
           
        }
    }
}
