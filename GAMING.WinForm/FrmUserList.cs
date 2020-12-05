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

namespace GAMING.WinForm
{
    public partial class FrmUserList : Form
    {
        private UserBLO userBLO;
        public FrmUserList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            userBLO = new UserBLO(ConfigurationManager.AppSettings["DbFolder"]);
            dataGridView1.ClearSelection();
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadData(  )
        {
            
               string value = txtsearch.Text.ToLower();
            var users = userBLO.GetBy(
                x =>
                 x.Matricule.ToLower()
                             .Contains(value) ||
                  x.Pseudo.ToLower().Contains(value)
                    ).OrderBy(x => x.Matricule).ToArray();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
            lbrowcount.Text = $"{dataGridView1.RowCount} rows";
           dataGridView1.ClearSelection();

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            Form f = new UserEditer(loadData);
            f.Show();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           
            loadData();
            
        }

        private void btnrafraichir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsearch.Text))
                loadData();
            else
                txtsearch.Clear();
        }

        private void btnediter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new UserEditer(dataGridView1.SelectedRows[i].DataBoundItem as User,
                        loadData
                        );
                    f.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnediter_Click(sender, e);
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(
                    "Voulez-vous vraiment supprimer cet etudiant?",
                    "Erreur", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes
                    )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        userBLO.DeleteUser(dataGridView1.SelectedRows[i].DataBoundItem as User);

                    }
                    loadData();
                }
            }
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            List<UserListPrint> items = new List<UserListPrint>();
            IEnumerable<User> etudiants = userBLO.GetAllUsers();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                User p = dataGridView1.Rows[i].DataBoundItem as User;
                items.Add(
                    new UserListPrint(
                        p.Matricule,
                         p.Pseudo,
                          p.Score,
                           p.Highscore
                          
                      )
                    );
            }
            Form f = new FrmPreview("EtudiantListRp.rdlc", items);
            f.Show();
        }
    }
}
