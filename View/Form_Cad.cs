using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form_Cad : Form
    {
        public Form_Cad()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtConfirmSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                txtConfirmSenha.UseSystemPasswordChar = true;
            }
        }

        private void lblVoltLogin_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();

            this.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string confirmSenha = txtConfirmSenha.Text;

            bool EmailValido(string email)
            {
                string padraoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, padraoEmail);
            } //true

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmSenha))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }

            if (!EmailValido(email))
            {
                MessageBox.Show("O email inserido não é válido.");
                return;
            }

            if (senha != confirmSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            string caminhoArquivo = @"C:\Users\ramos\source\repos\WinFormsApp1\data\cadastros.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
                {
                    sw.WriteLine($"usuario,{nome},{email},{senha}");
                }

                MessageBox.Show("Cadastro salvo com sucesso!");

                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtConfirmSenha.Clear();

                var Form1 = new Form1();
                Form1.Show();

                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o cadastro: {ex.Message}");
            }

        }

        private void Form_Cad_Load(object sender, EventArgs e)
        {

        }
    }
}
