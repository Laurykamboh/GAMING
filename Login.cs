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
    public partial class Login : Form
    {
        public List<Joueur> Donnees = new List<Joueur>();

        public Login()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Enabled = false;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
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

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
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

        private void txtId_Enter_1(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                pnl.BackColor = Color.Black;
                pbId.Location = new Point(0, 0);
                pbId.Size = new Size(29, 29);
                lblID.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblID.Location = new Point(28, 7);
                txtId.Focus();
                label1.Text = "Saisir votre adresse myIUC";
            }

            if (txtPassword.Text.Trim(' ') == "")
            {
                label3.Text = "";
                txtPassword.Text = "";
                pbPassword.Location = new Point(1, 27);
                pbPassword.Size = new Size(30, 30);
                lblPassword.Location = new Point(33, 35);
                lblPassword.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtPseudo.Text.Trim(' ') == "")
            {
                label2.Text = "";
                txtPseudo.Text = "";
                pbPseudo.Location = new Point(1, 27);
                pbPseudo.Size = new Size(30, 30);
                lblPseudo.Location = new Point(35, 35);
                lblPseudo.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void pbId_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                pnl.BackColor = Color.Black;
                pbId.Location = new Point(0, 0);
                pbId.Size = new Size(29, 29);
                lblID.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblID.Location = new Point(28, 7);
                txtId.Focus();
                label1.Text = "Saisir votre adresse myIUC";
            }

            if (txtPassword.Text.Trim(' ') == "")
            {
                label3.Text = "";
                txtPassword.Text = "";
                pbPassword.Location = new Point(1, 27);
                pbPassword.Size = new Size(30, 30);
                lblPassword.Location = new Point(33, 35);
                lblPassword.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtPseudo.Text.Trim(' ') == "")
            {
                label2.Text = "";
                txtPseudo.Text = "";
                pbPseudo.Location = new Point(1, 27);
                pbPseudo.Size = new Size(30, 30);
                lblPseudo.Location = new Point(35, 35);
                lblPseudo.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void txtPseudo_KeyDown(object sender, KeyEventArgs e)
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

        private void txtPseudo_Enter(object sender, EventArgs e)
        {
            if (txtPseudo.Text == "")
            {
                pnl.BackColor = Color.Black;
                pbPseudo.Location = new Point(0, 0);
                pbPseudo.Size = new Size(29, 29);
                lblPseudo.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblPseudo.Location = new Point(28, 7);
                txtPseudo.Focus();
                label2.Text = "Saisir votre nom de joueur";
            }

            if (txtPassword.Text.Trim(' ') == "")
            {
                label3.Text = "";
                txtPassword.Text = "";
                pbPassword.Location = new Point(1, 27);
                pbPassword.Size = new Size(30, 30);
                lblPassword.Location = new Point(33, 35);
                lblPassword.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtId.Text.Trim(' ') == "")
            {
                label1.Text = "";
                txtId.Text = "";
                pbId.Location = new Point(1, 27);
                pbId.Size = new Size(30, 30);
                lblID.Location = new Point(33, 35);
                lblID.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void pbPseudo_Click(object sender, EventArgs e)
        {
            if (txtPseudo.Text == "")
            {
                pnl.BackColor = Color.Black;
                pbPseudo.Location = new Point(0, 0);
                pbPseudo.Size = new Size(29, 29);
                lblPseudo.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblPseudo.Location = new Point(28, 7);
                txtPseudo.Focus();
                label2.Text = "Saisir votre nom de joueur";
            }

            if (txtPassword.Text.Trim(' ') == "")
            {
                label3.Text = "";
                txtPassword.Text = "";
                pbPassword.Location = new Point(1, 27);
                pbPassword.Size = new Size(30, 30);
                lblPassword.Location = new Point(33, 35);
                lblPassword.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtId.Text.Trim(' ') == "")
            {
                label1.Text = "";
                txtId.Text = "";
                pbId.Location = new Point(1, 27);
                pbId.Size = new Size(30, 30);
                lblID.Location = new Point(33, 35);
                lblID.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void pbPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim(' ') == "")
            {
                pnl.BackColor = Color.Blue;
                pbPassword.Location = new Point(0, 0);
                pbPassword.Size = new Size(29, 29);
                lblPassword.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblPassword.Location = new Point(28, 7);
                txtPassword.Focus();
                label3.Text = "Saisir votre matricule";
            }

            if (txtPseudo.Text.Trim(' ') == "")
            {
                label2.Text = "";
                txtPseudo.Text = "";
                pbPseudo.Location = new Point(1, 27);
                pbPseudo.Size = new Size(30, 30);
                lblPseudo.Location = new Point(35, 35);
                lblPseudo.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtId.Text.Trim(' ') == "")
            {
                label1.Text = "";
                txtId.Text = "";
                pbId.Location = new Point(1, 27);
                pbId.Size = new Size(30, 30);
                lblID.Location = new Point(33, 35);
                lblID.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                pnl.BackColor = Color.Black;
                pbId.Location = new Point(0, 0);
                pbId.Size = new Size(29, 29);
                lblID.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblID.Location = new Point(28, 7);
                txtId.Focus();
                label1.Text = "Saisir votre adresse myIUC";
            }

            if (txtPassword.Text.Trim(' ') == "")
            {
                label3.Text = "";
                txtPassword.Text = "";
                pbPassword.Location = new Point(1, 27);
                pbPassword.Size = new Size(30, 30);
                lblPassword.Location = new Point(33, 35);
                lblPassword.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtPseudo.Text.Trim(' ') == "")
            {
                label2.Text = "";
                txtPseudo.Text = "";
                pbPseudo.Location = new Point(1, 27);
                pbPseudo.Size = new Size(30, 30);
                lblPseudo.Location = new Point(35, 35);
                lblPseudo.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void lblPseudo_Click(object sender, EventArgs e)
        {
            if (txtPseudo.Text == "")
            {
                pnl.BackColor = Color.Black;
                pbPseudo.Location = new Point(0, 0);
                pbPseudo.Size = new Size(29, 29);
                lblPseudo.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblPseudo.Location = new Point(28, 7);
                txtPseudo.Focus();
                label2.Text = "Saisir votre nom de joueur";
            }

            if (txtPassword.Text.Trim(' ') == "")
            {
                label3.Text = "";
                txtPassword.Text = "";
                pbPassword.Location = new Point(1, 27);
                pbPassword.Size = new Size(30, 30);
                lblPassword.Location = new Point(33, 35);
                lblPassword.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtId.Text.Trim(' ') == "")
            {
                label1.Text = "";
                txtId.Text = "";
                pbId.Location = new Point(1, 27);
                pbId.Size = new Size(30, 30);
                lblID.Location = new Point(33, 35);
                lblID.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim(' ') == "")
            {
                pnl.BackColor = Color.Blue;
                pbPassword.Location = new Point(0, 0);
                pbPassword.Size = new Size(29, 29);
                lblPassword.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblPassword.Location = new Point(28, 7);
                txtPassword.Focus();
                label3.Text = "Saisir votre matricule";
            }

            if (txtPseudo.Text.Trim(' ') == "")
            {
                label2.Text = "";
                txtPseudo.Text = "";
                pbPseudo.Location = new Point(1, 27);
                pbPseudo.Size = new Size(30, 30);
                lblPseudo.Location = new Point(35, 35);
                lblPseudo.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtId.Text.Trim(' ') == "")
            {
                label1.Text = "";
                txtId.Text = "";
                pbId.Location = new Point(1, 27);
                pbId.Size = new Size(30, 30);
                lblID.Location = new Point(33, 35);
                lblID.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
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

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim(' ') == "")
            {
                pnl.BackColor = Color.Blue;
                pbPassword.Location = new Point(0, 0);
                pbPassword.Size = new Size(29, 29);
                lblPassword.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblPassword.Location = new Point(28, 7);
                txtPassword.Focus();
                label3.Text = "Saisir votre matricule";
            }

            if (txtPseudo.Text.Trim(' ') == "")
            {
                label2.Text = "";
                txtPseudo.Text = "";
                pbPseudo.Location = new Point(1, 27);
                pbPseudo.Size = new Size(30, 30);
                lblPseudo.Location = new Point(35, 35);
                lblPseudo.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtId.Text.Trim(' ') == "")
            {
                label1.Text = "";
                txtId.Text = "";
                pbId.Location = new Point(1, 27);
                pbId.Size = new Size(30, 30);
                lblID.Location = new Point(33, 35);
                lblID.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void pbPassword_MouseEnter(object sender, EventArgs e)
        {
            pnl.BackColor = Color.Blue;
        }

        private void pbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Focused == false)
            {
                pnl.BackColor = Color.Black;
            }
        }

        private void lblPassword_MouseEnter(object sender, EventArgs e)
        {
            pnl.BackColor = Color.Blue;
        }

        private void lblPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Focused == false)
            {
                pnl.BackColor = Color.Black;
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            pnl.BackColor = Color.Blue;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Focused == false)
            {
                pnl.BackColor = Color.Black;
            }
        }

        private void pnl_MouseEnter(object sender, EventArgs e)
        {
            pnl.BackColor = Color.Blue;
        }

        private void pnl_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Focused == false)
            {
                pnl.BackColor = Color.Black;
            }
        }

        private void txtPseudo_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPseudo.Text == "")
            {
                label2.Text = "Saisir votre nom de joueur";
            }

            else
            {
                label2.Text = "";
                lblErrorPseudo.Visible = false;
                pbErrorPseudo.Visible = false;
            }
        }

        private void txtId_OnValueChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                label1.Text = "Saisir votre adresse myIUC";
            }

            else
            {
                label1.Text = "";
                lblErrorIdentifiant.Visible = false;
                pbErrorId.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                label3.Text = "Saisir votre matricule";

            }

            else
            {
                label3.Text = "";
                lblErrorPassword.Visible = false;
                pbErrorPassword.Visible = false;
            }
        }

        private void pnl_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim(' ') == "")
            {
                pnl.BackColor = Color.Blue;
                pbPassword.Location = new Point(0, 0);
                pbPassword.Size = new Size(29, 29);
                lblPassword.Font = new Font("Microsoft Yi Baiti", 12, FontStyle.Regular);
                lblPassword.Location = new Point(28, 7);
                txtPassword.Focus();
                label3.Text = "Saisir votre matricule";
            }

            if (txtPseudo.Text.Trim(' ') == "")
            {
                label2.Text = "";
                txtPseudo.Text = "";
                pbPseudo.Location = new Point(1, 27);
                pbPseudo.Size = new Size(30, 30);
                lblPseudo.Location = new Point(35, 35);
                lblPseudo.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }

            if (txtId.Text.Trim(' ') == "")
            {
                label1.Text = "";
                txtId.Text = "";
                pbId.Location = new Point(1, 27);
                pbId.Size = new Size(30, 30);
                lblID.Location = new Point(33, 35);
                lblID.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
            }
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            txtPassword.UseSystemPasswordChar = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}