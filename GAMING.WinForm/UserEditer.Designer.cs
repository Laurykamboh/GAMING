
namespace GAMING.WinForm
{
    partial class UserEditer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbmatricule = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtmatricule = new System.Windows.Forms.TextBox();
            this.lbscore = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.txtpseudo = new System.Windows.Forms.TextBox();
            this.lbpseudo = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txthighscore = new System.Windows.Forms.TextBox();
            this.lbhighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbmatricule
            // 
            this.lbmatricule.AutoSize = true;
            this.lbmatricule.Location = new System.Drawing.Point(95, 66);
            this.lbmatricule.Name = "lbmatricule";
            this.lbmatricule.Size = new System.Drawing.Size(50, 13);
            this.lbmatricule.TabIndex = 0;
            this.lbmatricule.Text = "Matricule";
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(146, 314);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtmatricule
            // 
            this.txtmatricule.Location = new System.Drawing.Point(53, 109);
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.Size = new System.Drawing.Size(139, 20);
            this.txtmatricule.TabIndex = 2;
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.Location = new System.Drawing.Point(464, 66);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(35, 13);
            this.lbscore.TabIndex = 3;
            this.lbscore.Text = "Score";
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(412, 109);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(144, 20);
            this.txtscore.TabIndex = 6;
            // 
            // txtpseudo
            // 
            this.txtpseudo.Location = new System.Drawing.Point(239, 109);
            this.txtpseudo.Name = "txtpseudo";
            this.txtpseudo.Size = new System.Drawing.Size(135, 20);
            this.txtpseudo.TabIndex = 8;
            // 
            // lbpseudo
            // 
            this.lbpseudo.AutoSize = true;
            this.lbpseudo.Location = new System.Drawing.Point(279, 66);
            this.lbpseudo.Name = "lbpseudo";
            this.lbpseudo.Size = new System.Drawing.Size(43, 13);
            this.lbpseudo.TabIndex = 7;
            this.lbpseudo.Text = "Pseudo";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(502, 314);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txthighscore
            // 
            this.txthighscore.Location = new System.Drawing.Point(599, 109);
            this.txthighscore.Name = "txthighscore";
            this.txthighscore.Size = new System.Drawing.Size(149, 20);
            this.txthighscore.TabIndex = 11;
            // 
            // lbhighscore
            // 
            this.lbhighscore.AutoSize = true;
            this.lbhighscore.Location = new System.Drawing.Point(644, 66);
            this.lbhighscore.Name = "lbhighscore";
            this.lbhighscore.Size = new System.Drawing.Size(57, 13);
            this.lbhighscore.TabIndex = 10;
            this.lbhighscore.Text = "HighScore";
            // 
            // UserEditer
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txthighscore);
            this.Controls.Add(this.lbhighscore);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtpseudo);
            this.Controls.Add(this.lbpseudo);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.txtmatricule);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lbmatricule);
            this.Name = "UserEditer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserEditer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmatricule;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtmatricule;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.TextBox txtpseudo;
        private System.Windows.Forms.Label lbpseudo;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txthighscore;
        private System.Windows.Forms.Label lbhighscore;
    }
}

