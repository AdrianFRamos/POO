namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtCadastro = new Button();
            label4 = new Label();
            label5 = new Label();
            btnExit = new Button();
            pictureBox2 = new PictureBox();
            chkShowPass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(342, 194);
            label1.Name = "label1";
            label1.Size = new Size(13, 20);
            label1.TabIndex = 0;
            label1.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HighlightText;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 450);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(472, 100);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(253, 27);
            txtLogin.TabIndex = 2;
            txtLogin.Text = "Ex: teste@teste.com";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(472, 178);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(253, 27);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 77);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "E-mail";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 155);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(472, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(253, 54);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtCadastro
            // 
            txtCadastro.Location = new Point(472, 348);
            txtCadastro.Name = "txtCadastro";
            txtCadastro.Size = new Size(253, 54);
            txtCadastro.TabIndex = 7;
            txtCadastro.Text = "Cadastra-se";
            txtCadastro.UseVisualStyleBackColor = true;
            txtCadastro.Click += txtCadastro_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 325);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 8;
            label4.Text = "Ou";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(569, 35);
            label5.Name = "label5";
            label5.Size = new Size(52, 18);
            label5.TabIndex = 9;
            label5.Text = "Login";
            label5.Click += label5_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(759, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 35);
            btnExit.TabIndex = 10;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.HighlightText;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(50, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(270, 259);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Location = new Point(599, 211);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(126, 24);
            chkShowPass.TabIndex = 12;
            chkShowPass.Text = "Mostrar Senha";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += ChkShowPass_CheckedChange;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(chkShowPass);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCadastro);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button txtCadastro;
        private Label label4;
        private Label label5;
        private Button btnExit;
        private PictureBox pictureBox2;
        private CheckBox chkShowPass;
    }
}
