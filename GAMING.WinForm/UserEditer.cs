using GAMIN.BLL;
using GAMIN.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GAMING.WinForm
{
    public partial class UserEditer : Form
    {
        private Action callBack;
        private User oldUser;
        public UserEditer()
        {
            InitializeComponent();
        }
       

        public UserEditer(Action callBak) : this()
        {
            this.callBack = callBak;

        }
        public UserEditer(User user, Action callBak) : this(callBak)
        {
            this.oldUser = user;
            txtpseudo.Text = user.Pseudo;
           // txtscore.Text = user.Score;
          
        }


        private void UserEditer_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();
                User newUser = new User
               (
               txtmatricule.Text.ToUpper(),
               txtpseudo.Text, 
               int.Parse(txtscore.Text),
               int.Parse(txthighscore.Text)
            );

                UserBLO userBLO = new UserBLO(ConfigurationManager.AppSettings["DbFolder"]);
                if (this.oldUser == null)
                    userBLO.CreateUser(oldUser);
                else
                    userBLO.EditUser(oldUser, newUser);
                MessageBox.Show(
                    "save done!",
                    "confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (callBack != null)
                    callBack();

                if (oldUser != null)
                    Close();

                txtmatricule.Clear();
                txtpseudo.Clear();
                txtscore.Clear();
                txthighscore.Clear();
                txtmatricule.Focus();
                
            }
            catch (TypingException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erreur type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Duplicate error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }

            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    " Aucune erreur detecté",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show(
                    "Une erreur est survénu! Réessayez plutard. ",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

            
        }
        private void checkForm()
        {
            string text = string.Empty;
            txtmatricule.BackColor = Color.White;
            txtpseudo.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtmatricule.Text))
            {
                text += "  S'il vous plait entrez le matricule! ";
                txtmatricule.BackColor = Color.White;
            }
            if (string.IsNullOrWhiteSpace(txtpseudo.Text))
            {
                text += "  S'il vous plait entrez le pseudo ";
                txtpseudo.BackColor = Color.White;
            }

            if (!string.IsNullOrEmpty(text))
            {
                throw new TypingException(text);
            }
        }
    }
}
