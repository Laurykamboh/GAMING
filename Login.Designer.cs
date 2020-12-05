namespace Gaming
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbErrorId = new System.Windows.Forms.PictureBox();
            this.lblErrorIdentifiant = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbId = new System.Windows.Forms.PictureBox();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbErrorPseudo = new System.Windows.Forms.PictureBox();
            this.lblErrorPseudo = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPseudo = new System.Windows.Forms.PictureBox();
            this.txtPseudo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbErrorPassword = new System.Windows.Forms.PictureBox();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbId)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorPseudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPseudo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.pbErrorId);
            this.panel1.Controls.Add(this.lblErrorIdentifiant);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbId);
            this.panel1.Controls.Add(this.txtId);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(431, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 113);
            this.panel1.TabIndex = 13;
            // 
            // pbErrorId
            // 
            this.bunifuTransition1.SetDecoration(this.pbErrorId, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pbErrorId, BunifuAnimatorNS.DecorationType.None);
            this.pbErrorId.Image = ((System.Drawing.Image)(resources.GetObject("pbErrorId.Image")));
            this.pbErrorId.Location = new System.Drawing.Point(4, 74);
            this.pbErrorId.Name = "pbErrorId";
            this.pbErrorId.Size = new System.Drawing.Size(20, 20);
            this.pbErrorId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbErrorId.TabIndex = 19;
            this.pbErrorId.TabStop = false;
            this.pbErrorId.Visible = false;
            // 
            // lblErrorIdentifiant
            // 
            this.lblErrorIdentifiant.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblErrorIdentifiant, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblErrorIdentifiant, BunifuAnimatorNS.DecorationType.None);
            this.lblErrorIdentifiant.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIdentifiant.ForeColor = System.Drawing.Color.Red;
            this.lblErrorIdentifiant.Location = new System.Drawing.Point(28, 77);
            this.lblErrorIdentifiant.Name = "lblErrorIdentifiant";
            this.lblErrorIdentifiant.Size = new System.Drawing.Size(206, 16);
            this.lblErrorIdentifiant.TabIndex = 17;
            this.lblErrorIdentifiant.Text = "Vous avez oublié de remplir ce champ";
            this.lblErrorIdentifiant.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.lblID, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblID, BunifuAnimatorNS.DecorationType.None);
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(38, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 21);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "Identifiant";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 16;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbId
            // 
            this.pbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.pbId, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pbId, BunifuAnimatorNS.DecorationType.None);
            this.pbId.Image = ((System.Drawing.Image)(resources.GetObject("pbId.Image")));
            this.pbId.Location = new System.Drawing.Point(4, 38);
            this.pbId.Name = "pbId";
            this.pbId.Size = new System.Drawing.Size(30, 30);
            this.pbId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbId.TabIndex = 7;
            this.pbId.TabStop = false;
            this.pbId.Click += new System.EventHandler(this.pbId_Click);
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.txtId, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.txtId, BunifuAnimatorNS.DecorationType.None);
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.HintForeColor = System.Drawing.Color.Empty;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtId.LineIdleColor = System.Drawing.Color.Black;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtId.LineThickness = 1;
            this.txtId.Location = new System.Drawing.Point(4, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(445, 35);
            this.txtId.TabIndex = 9;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.OnValueChanged += new System.EventHandler(this.txtId_OnValueChanged);
            this.txtId.Enter += new System.EventHandler(this.txtId_Enter_1);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMaterialTextbox1_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.pbErrorPseudo);
            this.panel2.Controls.Add(this.lblErrorPseudo);
            this.panel2.Controls.Add(this.lblPseudo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbPseudo);
            this.panel2.Controls.Add(this.txtPseudo);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(431, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 113);
            this.panel2.TabIndex = 14;
            // 
            // pbErrorPseudo
            // 
            this.bunifuTransition1.SetDecoration(this.pbErrorPseudo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pbErrorPseudo, BunifuAnimatorNS.DecorationType.None);
            this.pbErrorPseudo.Image = ((System.Drawing.Image)(resources.GetObject("pbErrorPseudo.Image")));
            this.pbErrorPseudo.Location = new System.Drawing.Point(4, 74);
            this.pbErrorPseudo.Name = "pbErrorPseudo";
            this.pbErrorPseudo.Size = new System.Drawing.Size(20, 20);
            this.pbErrorPseudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbErrorPseudo.TabIndex = 20;
            this.pbErrorPseudo.TabStop = false;
            this.pbErrorPseudo.Visible = false;
            // 
            // lblErrorPseudo
            // 
            this.lblErrorPseudo.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblErrorPseudo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblErrorPseudo, BunifuAnimatorNS.DecorationType.None);
            this.lblErrorPseudo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPseudo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPseudo.Location = new System.Drawing.Point(28, 77);
            this.lblErrorPseudo.Name = "lblErrorPseudo";
            this.lblErrorPseudo.Size = new System.Drawing.Size(206, 16);
            this.lblErrorPseudo.TabIndex = 18;
            this.lblErrorPseudo.Text = "Vous avez oublié de remplir ce champ";
            this.lblErrorPseudo.Visible = false;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.lblPseudo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblPseudo, BunifuAnimatorNS.DecorationType.None);
            this.lblPseudo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.ForeColor = System.Drawing.Color.Black;
            this.lblPseudo.Location = new System.Drawing.Point(38, 45);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(66, 21);
            this.lblPseudo.TabIndex = 8;
            this.lblPseudo.Text = "Pseudo";
            this.lblPseudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPseudo.Click += new System.EventHandler(this.lblPseudo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 17;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPseudo
            // 
            this.pbPseudo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.pbPseudo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pbPseudo, BunifuAnimatorNS.DecorationType.None);
            this.pbPseudo.Image = ((System.Drawing.Image)(resources.GetObject("pbPseudo.Image")));
            this.pbPseudo.Location = new System.Drawing.Point(3, 38);
            this.pbPseudo.Name = "pbPseudo";
            this.pbPseudo.Size = new System.Drawing.Size(30, 30);
            this.pbPseudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPseudo.TabIndex = 7;
            this.pbPseudo.TabStop = false;
            this.pbPseudo.Click += new System.EventHandler(this.pbPseudo_Click);
            // 
            // txtPseudo
            // 
            this.txtPseudo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.txtPseudo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.txtPseudo, BunifuAnimatorNS.DecorationType.None);
            this.txtPseudo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPseudo.HintForeColor = System.Drawing.Color.Empty;
            this.txtPseudo.HintText = "";
            this.txtPseudo.isPassword = false;
            this.txtPseudo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPseudo.LineIdleColor = System.Drawing.Color.Black;
            this.txtPseudo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPseudo.LineThickness = 1;
            this.txtPseudo.Location = new System.Drawing.Point(4, 37);
            this.txtPseudo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(445, 35);
            this.txtPseudo.TabIndex = 9;
            this.txtPseudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPseudo.OnValueChanged += new System.EventHandler(this.txtPseudo_OnValueChanged);
            this.txtPseudo.Enter += new System.EventHandler(this.txtPseudo_Enter);
            this.txtPseudo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPseudo_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pbErrorPassword);
            this.panel3.Controls.Add(this.lblErrorPassword);
            this.panel3.Controls.Add(this.pbPassword);
            this.panel3.Controls.Add(this.lblPassword);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pnl);
            this.panel3.Controls.Add(this.txtPassword);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(431, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 113);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Voir le mot de passe");
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pbErrorPassword
            // 
            this.bunifuTransition1.SetDecoration(this.pbErrorPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pbErrorPassword, BunifuAnimatorNS.DecorationType.None);
            this.pbErrorPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbErrorPassword.Image")));
            this.pbErrorPassword.Location = new System.Drawing.Point(4, 75);
            this.pbErrorPassword.Name = "pbErrorPassword";
            this.pbErrorPassword.Size = new System.Drawing.Size(20, 20);
            this.pbErrorPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbErrorPassword.TabIndex = 20;
            this.pbErrorPassword.TabStop = false;
            this.pbErrorPassword.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblErrorPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblErrorPassword, BunifuAnimatorNS.DecorationType.None);
            this.lblErrorPassword.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(28, 78);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(206, 16);
            this.lblErrorPassword.TabIndex = 19;
            this.lblErrorPassword.Text = "Vous avez oublié de remplir ce champ";
            this.lblErrorPassword.Visible = false;
            // 
            // pbPassword
            // 
            this.pbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.pbPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pbPassword, BunifuAnimatorNS.DecorationType.None);
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(4, 40);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(30, 30);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 7;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pbPassword_Click);
            this.pbPassword.MouseEnter += new System.EventHandler(this.pbPassword_MouseEnter);
            this.pbPassword.MouseLeave += new System.EventHandler(this.pbPassword_MouseLeave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.lblPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lblPassword, BunifuAnimatorNS.DecorationType.None);
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(38, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            this.lblPassword.MouseEnter += new System.EventHandler(this.lblPassword_MouseEnter);
            this.lblPassword.MouseLeave += new System.EventHandler(this.lblPassword_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 17;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Black;
            this.pnl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition2.SetDecoration(this.pnl, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnl, BunifuAnimatorNS.DecorationType.None);
            this.pnl.Location = new System.Drawing.Point(4, 72);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(445, 1);
            this.pnl.TabIndex = 10;
            this.pnl.Click += new System.EventHandler(this.pnl_Click);
            this.pnl.MouseEnter += new System.EventHandler(this.pnl_MouseEnter);
            this.pnl.MouseLeave += new System.EventHandler(this.pnl_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(248)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.txtPassword, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.txtPassword, BunifuAnimatorNS.DecorationType.None);
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(4, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(445, 26);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "visible_black_30px.png");
            this.imageList1.Images.SetKeyName(1, "visible_30px.png");
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 90;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel3);
            this.bunifuTransition2.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1330, 650);
            this.panel6.TabIndex = 19;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            this.bunifuTransition2.Interval = 20;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1330, 650);
            this.Controls.Add(this.panel6);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intellisense";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbId)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorPseudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPseudo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.PictureBox pbId;
        public System.Windows.Forms.Label lblPseudo;
        public System.Windows.Forms.PictureBox pbPseudo;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPseudo;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.PictureBox pbErrorId;
        public System.Windows.Forms.Label lblErrorIdentifiant;
        public System.Windows.Forms.PictureBox pbErrorPseudo;
        public System.Windows.Forms.Label lblErrorPseudo;
        public System.Windows.Forms.PictureBox pbErrorPassword;
        public System.Windows.Forms.Label lblErrorPassword;
    }
}