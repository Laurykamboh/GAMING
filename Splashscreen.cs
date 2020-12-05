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
using Guna.UI.WinForms;
using System.Threading;

namespace Gaming
{
    public partial class Splashscreen : Form
    {
        public Random ran = new Random();
        public int index1, index2, i = 0;
        public List<PictureBox> pb;
        SoundPlayer s = new SoundPlayer
        ("Rebours.wav");

        public Splashscreen()
        {
            InitializeComponent();
            pb = new List<PictureBox>()
            {
                pictureBox1,pictureBox2,pictureBox3,pictureBox4,
                pictureBox5,pictureBox6,pictureBox7,pictureBox8,
                pictureBox9,pictureBox10,pictureBox11,pictureBox12,
                pictureBox13,pictureBox14,pictureBox15,pictureBox16,
                pictureBox17,pictureBox18,pictureBox19,pictureBox20,
                pictureBox21,pictureBox22,pictureBox23,pictureBox24,
                pictureBox25
            };

            s.Load();
            s.PlayLooping();
          
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                index1 = ran.Next(pb.Count);
                index2 = ran.Next(imageList1.Images.Count);

                while (pb[index1].Image != null)
                {
                    index1 = ran.Next(pb.Count);
                }

                pb[index1].Image = imageList1.Images[index2];

                imageList1.Images.RemoveAt(index2);
                timer1.Stop();
                bunifuTransition2.ShowSync(pb[index1]);
                timer1.Start();
            }

            else
            {
                this.BackColor = Color.Black;
                if(panel1.Visible == true)
                {
                    bunifuTransition3.HideSync(panel1);
                }

                else
                {
                    if(inop.Visible == false)
                    {
                        bunifuTransition1.ShowSync(inop);
                    }
                    else
                    {
                        timer1.Interval = 70;
                        timer1.Stop();
                        Thread.Sleep(3000);
                        this.Hide();
                        s.Stop();
                        timer1.Start();

                        new Bienvenue().Show();
                        timer1.Stop();
                    }
                }
            }
        }
    }
}
