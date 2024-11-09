namespace WinFormsApp1
{
    partial class Form_List_Prod
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
            listBoxProdutos = new ListBox();
            SuspendLayout();
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.Location = new Point(136, 38);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new Size(517, 324);
            listBoxProdutos.TabIndex = 0;
            listBoxProdutos.SelectedIndexChanged += listBoxProdutos_SelectedIndexChanged_1;
            // 
            // Form_List_Prod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxProdutos);
            Name = "Form_List_Prod";
            Text = "Form_List_Prod";
            Load += Form_List_Prod_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProdutos;
    }
}