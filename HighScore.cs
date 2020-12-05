using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Gaming
{
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            label1.Text =
                "Votre meilleur score est : \n \n"
                + "0";

            Bienvenue.Donnees[Bienvenue.temp].HighScore = 0;

            using (StreamWriter sw = new StreamWriter("Gaming.json"))
            {
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    JsonSerializer js = new JsonSerializer();

                    jw.Formatting = Formatting.Indented;

                    js.Serialize(jw, JsonConvert.DeserializeObject(JsonConvert.SerializeObject(Bienvenue.Donnees)));
                }
            }
        }
    }
}
