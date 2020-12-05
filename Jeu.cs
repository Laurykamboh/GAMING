using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Guna.UI.WinForms;
using System.Threading;
using Newtonsoft.Json;

namespace Gaming
{
    public partial class Jeu : Form
    {
        public static List<Quizz> pers;
        Random ran = new Random();
        public int count = 15;
        public int point = 0;
        int i = 0, j = 0, a1;
        SoundPlayer s = new SoundPlayer
        ("rebours.wav");
        List<Button> buttons;
        Issue f = new Issue();
        public static int temp;


        public void Gagner(Button btn)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            count = 15;


            if(btn.Text == pers[a1].Reponse && btn.BackColor == ColorTranslator.FromHtml("#ACDFFF"))
            {
                btn.BackColor = Color.Chartreuse;
                point++;
                Point.Text = point.ToString();
                //btn.OnHoverBaseColor = Color.Chartreuse;
                s = new SoundPlayer("Applaudissement.wav");

                if(point > Bienvenue.Donnees[Bienvenue.temp].HighScore)
                {
                        Bienvenue.High.Add(point);

                        Bienvenue.Donnees[Bienvenue.temp].HighScore = Bienvenue.High.Max<int>();

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

                s.Load();
                s.Play();

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                timer6.Enabled = true;
            }

            else
            {
                btn.BackColor = Color.Red;
                //btn.OnHoverBaseColor = Color.OrangeRed;

                Thread.Sleep(500);
                for(i = 0; i < 4; i++)
                {
                    if(buttons[i].Text == pers[a1].Reponse)
                    {
                        buttons[i].BackColor = Color.Chartreuse;
                        //buttons[i].OnHoverBaseColor = Color.Chartreuse;
                    }
                }

                timer7.Enabled = true;

                s = new SoundPlayer("OVER.wav");
                s.Load();
                s.Play();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer4.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            pers.RemoveAt(a1);

            if (pers.Count >= 0)
            {
                count = 15;
                a1 = ran.Next(0, pers.Count);

                List<string> Mauvais = new List<string>() { pers[a1].MauvaiseReponse1, pers[a1].MauvaiseReponse2, pers[a1].MauvaiseReponse3 };

                label4.Text = pers[a1].Question;

                int index = ran.Next(0, 4);

                buttons[index].Text = pers[a1].Reponse;

                for (i = 0; i < 4; i++)
                {
                    if (buttons[i].Text != pers[a1].Reponse)
                    {
                        int Hasard = ran.Next(0, Mauvais.Count);
                        buttons[i].Text = Mauvais[Hasard];

                        Mauvais.RemoveAt(Hasard);
                    }

                    buttons[i].BackColor = ColorTranslator.FromHtml("#ACDFFF");
                    //buttons[i].OnHoverBaseColor = ColorTranslator.FromHtml("#E0E0E0");
                }

                timer1.Enabled = true;
                label1.Visible = true;
                label1.ForeColor = Color.White;
                timer5.Enabled = false;
                label1.Font = new Font("Microsoft Sans Serif", 15);
                Bienvenue.s1 = null;
            }

            else
            {
                Bienvenue.s1 = new Issue();
                Bienvenue.s1.Text = "Félicitations, vous avez gagné le jeu";
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gagner(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gagner(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gagner(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gagner(button4);
        }

        public Jeu()
        {            
            InitializeComponent();

            timer1.Enabled = true;
            label1.Text = count.ToString() + " s";
            buttons = new List<Button>() { button1, button2, button3, button4 };

            pers = new List<Quizz>();

            using (StreamReader sr = new StreamReader("Quizz.json"))
            {
                using (JsonReader jr = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();

                    pers = js.Deserialize<List<Quizz>>(jr);
                }
            }

            temp = Bienvenue.Donnees[Bienvenue.temp].HighScore;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            label1.Text = count.ToString() + " s";

            if(count == 10)
            {
                timer2.Enabled = true;
            }

             else if (count <= 5 && count > 0)
            {
                label1.ForeColor = Color.Red;
                label1.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                timer3.Enabled = true;
            }

            else if (count == 0)
            {
                label1.Visible = false;
                timer1.Enabled = false;

                for (i = 0; i < 4; i++)
                {
                    if (buttons[i].Text == pers[a1].Reponse)
                    {
                        buttons[i].BackColor = Color.Chartreuse;
                        //buttons[i].OnHoverBaseColor = Color.Chartreuse;
                    }
                }

                s = new SoundPlayer("OVER.wav");
                s.Load();
                s.Play();

                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                timer7.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a1 = ran.Next(0, pers.Count);

            List<string> Mauvais = new List<string>() { pers[a1].MauvaiseReponse1, pers[a1].MauvaiseReponse2, pers[a1].MauvaiseReponse3 };

            label4.Text = pers[a1].Question;

            int index = ran.Next(0, 4);

            buttons[index].Text = pers[a1].Reponse;

            for (i = 0; i < 4; i++)
            {
                if (buttons[i].Text != pers[a1].Reponse)
                {
                    int Hasard = ran.Next(0, Mauvais.Count);
                    buttons[i].Text = Mauvais[Hasard];

                    Mauvais.RemoveAt(Hasard);
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Enabled = false;
            timer5.Enabled = true;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            timer5.Enabled = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Bienvenue.High.Clear();

            if(temp < Bienvenue.Donnees[Bienvenue.temp].HighScore)
            {
                Bienvenue.s2 = new Issue();

                Bienvenue.s2.label1.Text =
                    "Félicitations, vous avez un nouveau meilleur score : \n \n" +
                    "Meilleur score : \n" +
                    Bienvenue.Donnees[Bienvenue.temp].HighScore.ToString();

            }

            else
            {
                Bienvenue.s2 = null;
            }

            this.Close();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timer7.Enabled = false;

            label4.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";

            button1.BackColor = ColorTranslator.FromHtml("#ACDFFF");
            button2.BackColor = ColorTranslator.FromHtml("#ACDFFF");
            button3.BackColor = ColorTranslator.FromHtml("#ACDFFF");
            button4.BackColor = ColorTranslator.FromHtml("#ACDFFF");


            point = 0;
            Point.Text = point.ToString();
            count = 15;
            label1.Text = count.ToString() + "s";

            bunifuTransition1.ShowSync(panel4);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s = new SoundPlayer("rebours.wav");

            s.Load();
            s.Play();
            j++;

            if (j == 2)
            {
                timer2.Enabled = false;
                s.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(label1.Font.Size == 15)
            {
                label1.Font = new Font("Microsoft Sans Serif", 18);
            }

            else if (label1.Font.Size == 18)
            {
                label1.Font = new Font("Microsoft Sans Serif", 15);
            }
        }
    }
}
