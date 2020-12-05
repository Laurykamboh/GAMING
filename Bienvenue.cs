using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace Gaming
{
    public partial class Bienvenue : Form
    {
        public static List<Joueur> Donnees = new List<Joueur>();
        public Login l = new Login();
        public string Pseudo;
        //WindowsMediaPlayer fcg = new WindowsMediaPlayer();
        public static int temp;
        public static List<int> High = new List<int>();

        public static Issue s1;
        public static Issue s2;
        
        public Bienvenue()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = "bienvenue.mp3";
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;

            label2.Parent = pictureBox2;
            label2.BackColor = Color.Transparent;
            label2.Visible = false;

            gunbtn2.Parent = pictureBox2;
            gunbtn2.BackColor = Color.Transparent;
            gunbtn2.Visible = false;

            GunBtn1.Parent = pictureBox2;
            GunBtn1.BackColor = Color.Transparent;
            GunBtn1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            panel1.Height = this.Height;
            panel1.Width = this.Width;
            panel1.Location = new Point(0, 0);
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            panel1.Controls.Add(l.panel6);

            l.panel2.Visible = false;
            bunifuTransition1.ShowSync(panel1);
        }

        private void Bienvenue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    this.WindowState = FormWindowState.Normal;

                    panel1.Height = this.Height;
                    panel1.Width = this.Width;
                }

                else if (this.FormBorderStyle == FormBorderStyle.FixedSingle)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;

                    panel1.Height = this.Height;
                    panel1.Width = this.Width;
                }
            }
        }

        private void btnSign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    this.WindowState = FormWindowState.Normal;
                }

                else if (this.FormBorderStyle == FormBorderStyle.FixedSingle)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void btnConnect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    this.WindowState = FormWindowState.Normal;

                    panel1.Height = this.Height;
                    panel1.Width = this.Width;
                }

                else if (this.FormBorderStyle == FormBorderStyle.FixedSingle)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;

                    panel1.Height = this.Height;
                    panel1.Width = this.Width;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.White)
            {
                panel1.Controls.Clear();

                panel1.Controls.Add(btnJouer);
                panel1.Controls.Add(btnScore);
                panel1.Controls.Add(btnQuitter);
                panel1.Controls.Add(panel5);
                panel1.Controls.Add(panel3);
            }

            else
            {
                bunifuTransition1.HideSync(panel1);

                l.txtId.Text = "";
                l.txtPseudo.Text = "";
                l.txtPassword.Text = "";
                panel2.Visible = false;

                l.txtId.Focus();
            }
        }

        private void Bienvenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunbtn2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(l.panel6);

            btnConfirmer.Text = "Valider";

            bunifuTransition1.ShowSync(panel1);
        }

        private void GunBtn1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(l.panel6);

            btnConfirmer.Text = "Confirmer";

            bunifuTransition1.ShowSync(panel1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer2.Enabled = false;

                bunifuTransition2.ShowSync(label2);
                bunifuTransition2.ShowSync(GunBtn1);
                bunifuTransition2.ShowSync(gunbtn2);
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (l.txtPassword.Text.Trim(' ') == "")
            {
                l.pbErrorPassword.Visible = true;
                l.lblErrorPassword.Visible = true;
                l.txtPassword.Focus();
            }

            if (l.txtPseudo.Text.Trim(' ') == "")
            {
                l.pbErrorPseudo.Visible = true;
                l.lblErrorPseudo.Visible = true;
                l.txtPseudo.Focus();
            }

            if (l.txtId.Text.Trim(' ') == "")
            {
                l.pbErrorId.Visible = true;
                l.lblErrorIdentifiant.Visible = true;
                l.txtId.Focus();
            }



            if (l.txtId.Text.Trim(' ') != "" && l.txtPseudo.Text.Trim(' ') != "" && l.txtPassword.Text.Trim(' ') != "")
            {
                if (btnConfirmer.Text == "Confirmer")
                {
                    using (StreamReader sr = new StreamReader("Gaming.json"))
                    {
                        using (JsonReader jr = new JsonTextReader(sr))
                        {
                            JsonSerializer js = new JsonSerializer();

                            Donnees = js.Deserialize<List<Joueur>>(jr);
                        }
                    }

                    if (Donnees == null)
                        Donnees = new List<Joueur>();


                    int i, j = 0;
                    for (i = 0; i < Donnees.Count; i++)
                    {
                        if (
                            Donnees[i].ToString() ==
                            new Joueur { Id = l.txtId.Text, Pseudo = l.txtPseudo.Text, Password = l.txtPassword.Text, HighScore = 0, Occurrence = 0 }.ToString()
                           )
                        {
                            j++;
                        }
                    }

                    if (j == 0)
                    {
                        Donnees.Add(new Joueur { Id = l.txtId.Text, Pseudo = l.txtPseudo.Text, Password = l.txtPassword.Text, HighScore = 0, Occurrence = 0 });

                        using (StreamWriter sw = new StreamWriter("Gaming.json"))
                        {
                            using (JsonWriter jw = new JsonTextWriter(sw))
                            {
                                JsonSerializer js = new JsonSerializer();

                                jw.Formatting = Formatting.Indented;

                                js.Serialize(jw, JsonConvert.DeserializeObject(JsonConvert.SerializeObject(Donnees)));
                            }
                        }

                        bunifuTransition1.HideSync(panel1);

                        l.txtId.Text = "";
                        l.txtPseudo.Text = "";
                        l.txtPassword.Text = "";

                        l.txtId.Focus();
                    }

                    else
                    {
                        MessageBox.Show
                            (
                                "Cet identifiant existe déjà",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                        l.txtId.Focus();
                    }
                }

                else if(btnConfirmer.Text == "Valider")
                {
                    using (StreamReader sr = new StreamReader("Gaming.json"))
                    {
                        using (JsonReader jr = new JsonTextReader(sr))
                        {
                            JsonSerializer js = new JsonSerializer();

                            Donnees = js.Deserialize<List<Joueur>>(jr);
                        }
                    }

                    int i, j = 0;

                    if (Donnees == null)
                    {
                        Donnees = new List<Joueur>();
                    }

                    for(i = 0; i < Donnees.Count; i++)
                    {
                        if(
                            Donnees[i].ToString() ==
                            new Joueur { Id = l.txtId.Text, Pseudo = l.txtPseudo.Text, Password = l.txtPassword.Text, HighScore = 0, Occurrence = 0}.ToString()
                           )
                        {
                            j++;
                        }
                    }

                    if(j == 0)
                    {
                        panel2.Width = this.Width;
                        panel2.Location = new Point(0, panel2.Location.Y);
                        label2.Width = this.Width;
                        bunifuTransition3.ShowSync(panel2);
                        pictureBox4.Location = new Point(this.Width - pictureBox4.Width, pictureBox4.Location.Y);
                    }

                    else
                    {
                        this.Hide();
                        new Demo().ShowDialog();

                        panel3.Visible = true;
                        Pseudo = l.txtPseudo.Text;
                        panel1.Controls.Clear();
                        Thread.Sleep(1000);
                        panel1.Controls.Add(panel4);
                        panel1.Controls.Add(panel3);
                        Texte.Text = " Hé " + Pseudo + " pret à te plonger dans une nouvelle expérience Intellisense ?";
                        bunifuTransition4.ShowSync(panel4);

                        panel1.BackColor = Color.White;
                        this.Show();
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bunifuTransition3.HideSync(panel2);
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Jeu().ShowDialog();

            if(s1 != null)
            {
                s1.ShowDialog();
            }

            if(s2 != null)
            {
                s2.Hide();
                s2.ShowDialog();
            }

            this.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            btnJouer.Visible = false;
            btnQuitter.Visible = false;
            btnScore.Visible = false;

            bunifuTransition4.ShowSync(panel5);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            bunifuTransition4.HideSync(panel5);

            btnJouer.Visible = true;
            btnConfirmer.Visible = true;
            btnQuitter.Visible = true;
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            HighScore h = new HighScore();

            using (StreamReader sr = new StreamReader("Gaming.json"))
            {
                using (JsonReader jr = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();

                    Donnees = js.Deserialize<List<Joueur>>(jr);
                }
            }

            h.label1.Text =
                "Votre meilleur score est : \n \n"
                + Donnees[temp].HighScore.ToString();

            panel1.Controls.Add(h.panel1);
            panel1.Controls.Add(pictureBox3);
            pictureBox3.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            bunifuTransition4.HideSync(panel4);

            btnJouer.Visible = true;
            btnScore.Visible = true;
            btnQuitter.Visible = true;
            panel3.Visible = true;

            panel1.Controls.Add(btnJouer);
            panel1.Controls.Add(btnScore);
            panel1.Controls.Add(btnQuitter);
            panel1.Controls.Add(panel5);
        }
    }
}