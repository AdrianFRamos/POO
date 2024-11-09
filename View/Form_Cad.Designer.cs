namespace WinFormsApp1
{
    partial class Form_Cad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cad));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfirmSenha = new TextBox();
            chkShowPass = new CheckBox();
            btnCadastro = new Button();
            btnExit = new Button();
            lblVoltLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HighlightText;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.HighlightText;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(50, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(270, 259);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(569, 35);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 10;
            label5.Text = "Cadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 86);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 11;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 192);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 245);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 13;
            label3.Text = "Confirmar Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 139);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 14;
            label4.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(487, 109);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(233, 27);
            txtNome.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(487, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 27);
            txtEmail.TabIndex = 16;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(487, 215);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(233, 27);
            txtSenha.TabIndex = 17;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.Location = new Point(487, 268);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.Size = new Size(233, 27);
            txtConfirmSenha.TabIndex = 18;
            txtConfirmSenha.UseSystemPasswordChar = true;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Location = new Point(594, 301);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(126, 24);
            chkShowPass.TabIndex = 19;
            chkShowPass.Text = "Mostrar Senha";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(484, 347);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(236, 54);
            btnCadastro.TabIndex = 20;
            btnCadastro.Text = "Cadastra-se";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(758, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 35);
            btnExit.TabIndex = 21;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblVoltLogin
            // 
            lblVoltLogin.AutoSize = true;
            lblVoltLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblVoltLogin.Location = new Point(535, 404);
            lblVoltLogin.Name = "lblVoltLogin";
            lblVoltLogin.Size = new Size(136, 20);
            lblVoltLogin.TabIndex = 22;
            lblVoltLogin.Text = "Voltar para o Login";
            lblVoltLogin.Click += lblVoltLogin_Click;
            // 
            // Form_Cad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVoltLogin);
            Controls.Add(btnExit);
            Controls.Add(btnCadastro);
            Controls.Add(chkShowPass);
            Controls.Add(txtConfirmSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Cad";
            Text = "Form_Cad";
            Load += Form_Cad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmSenha;
        private CheckBox chkShowPass;
        private Button btnCadastro;
        private Button btnExit;
        private Label lblVoltLogin;
    }
}