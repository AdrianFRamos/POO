namespace WinFormsApp1
{
    partial class Form_Cad_Produto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtDesc = new TextBox();
            txtPreco = new TextBox();
            txtQuant = new TextBox();
            txtTrib = new TextBox();
            txtCateg = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 49);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 84);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 119);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 157);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Tributacao";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 199);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 232);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 5;
            label6.Text = "Descricao";
            // 
            // txtName
            // 
            txtName.Location = new Point(334, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(351, 27);
            txtName.TabIndex = 6;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(334, 232);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(351, 27);
            txtDesc.TabIndex = 7;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(334, 79);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(351, 27);
            txtPreco.TabIndex = 8;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(334, 119);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(351, 27);
            txtQuant.TabIndex = 9;
            // 
            // txtTrib
            // 
            txtTrib.Location = new Point(334, 157);
            txtTrib.Name = "txtTrib";
            txtTrib.Size = new Size(351, 27);
            txtTrib.TabIndex = 10;
            // 
            // txtCateg
            // 
            txtCateg.Location = new Point(334, 196);
            txtCateg.Name = "txtCateg";
            txtCateg.Size = new Size(351, 27);
            txtCateg.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(334, 291);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(462, 291);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(581, 291);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Deletar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form_Cad_Produto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCateg);
            Controls.Add(txtTrib);
            Controls.Add(txtQuant);
            Controls.Add(txtPreco);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Cad_Produto";
            Text = "Form_Cad_Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtDesc;
        private TextBox txtPreco;
        private TextBox txtQuant;
        private TextBox txtTrib;
        private TextBox txtCateg;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}