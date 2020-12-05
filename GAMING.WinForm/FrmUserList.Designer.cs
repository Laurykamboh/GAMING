
namespace GAMING.WinForm
{
    partial class FrmUserList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbrowcount = new System.Windows.Forms.Label();
            this.btnediter = new System.Windows.Forms.Button();
            this.lbsearch = new System.Windows.Forms.Label();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.btnrafraichir = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datedenaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ecolecourante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbrowcount
            // 
            this.lbrowcount.AutoSize = true;
            this.lbrowcount.Location = new System.Drawing.Point(56, 409);
            this.lbrowcount.Name = "lbrowcount";
            this.lbrowcount.Size = new System.Drawing.Size(35, 13);
            this.lbrowcount.TabIndex = 20;
            this.lbrowcount.Text = "Count";
            // 
            // btnediter
            // 
            this.btnediter.Location = new System.Drawing.Point(681, 275);
            this.btnediter.Name = "btnediter";
            this.btnediter.Size = new System.Drawing.Size(72, 35);
            this.btnediter.TabIndex = 19;
            this.btnediter.Text = "Editer";
            this.btnediter.UseVisualStyleBackColor = true;
            this.btnediter.Click += new System.EventHandler(this.btnediter_Click);
            // 
            // lbsearch
            // 
            this.lbsearch.AutoSize = true;
            this.lbsearch.Location = new System.Drawing.Point(47, 28);
            this.lbsearch.Name = "lbsearch";
            this.lbsearch.Size = new System.Drawing.Size(41, 13);
            this.lbsearch.TabIndex = 18;
            this.lbsearch.Text = "Search";
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(681, 234);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(72, 35);
            this.btnannuler.TabIndex = 17;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnimprimer
            // 
            this.btnimprimer.Location = new System.Drawing.Point(681, 193);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(72, 35);
            this.btnimprimer.TabIndex = 16;
            this.btnimprimer.Text = "Imprimer";
            this.btnimprimer.UseVisualStyleBackColor = true;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
            // 
            // btnrafraichir
            // 
            this.btnrafraichir.Location = new System.Drawing.Point(681, 152);
            this.btnrafraichir.Name = "btnrafraichir";
            this.btnrafraichir.Size = new System.Drawing.Size(72, 35);
            this.btnrafraichir.TabIndex = 15;
            this.btnrafraichir.Text = "Rafraichir";
            this.btnrafraichir.UseVisualStyleBackColor = true;
            this.btnrafraichir.Click += new System.EventHandler(this.btnrafraichir_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(681, 111);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(72, 35);
            this.btnsupprimer.TabIndex = 14;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(50, 44);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(349, 20);
            this.txtsearch.TabIndex = 13;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(681, 70);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(72, 35);
            this.btnajouter.TabIndex = 12;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Nom,
            this.Prenom,
            this.Contact,
            this.Datedenaissance,
            this.Ecolecourante});
            this.dataGridView1.Location = new System.Drawing.Point(50, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 325);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Matricule
            // 
            this.Matricule.DataPropertyName = "Matricule";
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // Datedenaissance
            // 
            this.Datedenaissance.DataPropertyName = "Date de naissance";
            this.Datedenaissance.HeaderText = "Date de naissance";
            this.Datedenaissance.Name = "Datedenaissance";
            this.Datedenaissance.ReadOnly = true;
            // 
            // Ecolecourante
            // 
            this.Ecolecourante.DataPropertyName = "Ecole courante";
            this.Ecolecourante.HeaderText = "Ecole courante";
            this.Ecolecourante.Name = "Ecolecourante";
            this.Ecolecourante.ReadOnly = true;
            // 
            // FrmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbrowcount);
            this.Controls.Add(this.btnediter);
            this.Controls.Add(this.lbsearch);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.btnrafraichir);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUserList";
            this.Text = "FrmUserList";
            this.Load += new System.EventHandler(this.FrmUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbrowcount;
        private System.Windows.Forms.Button btnediter;
        private System.Windows.Forms.Label lbsearch;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.Button btnrafraichir;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datedenaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ecolecourante;
    }
}