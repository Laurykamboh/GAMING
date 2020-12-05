using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    public class Joueur
    {
        public string Id { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }
        public int HighScore { get; set; }
        public int Occurrence { get; set; }

        public override string ToString()
        {
            return Id + Pseudo + Password;

        }
    }
}
