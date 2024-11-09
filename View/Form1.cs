using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string emailLogin = txtLogin.Text;
                string senhaLogin = txtSenha.Text;

                if (string.IsNullOrWhiteSpace(emailLogin) || string.IsNullOrWhiteSpace(senhaLogin))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                    return;
                }

                if (!EmailValido(emailLogin))
                {
                    MessageBox.Show("O email inserido não é válido.");
                    return;
                }

                string caminhoArquivo = @"C:\Users\ramos\source\repos\WinFormsApp1\data\cadastros.txt"; 
                bool loginValido = false;

                string[] cadastros = File.ReadAllLines(caminhoArquivo);

                foreach (string cadastro in cadastros)
                {
                    string[] dados = cadastro.Split(',');

                    if (dados.Length == 3 && dados[1] == emailLogin && dados[2] == senhaLogin)
                    {
                        loginValido = true;
                        break;
                    }
                }

                if (loginValido)
                {
                    var menu = new Form_Home();
                    menu.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtLogin.Clear();
                    txtSenha.Clear();
                    btnLogin.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar o login: {ex.Message}");
            }
        }

        bool EmailValido(string email)
        {
            string padraoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padraoEmail);
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkShowPass_CheckedChange(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }

        }

        private void txtCadastro_Click(object sender, EventArgs e)
        {
            var cad = new Form_Cad();
            cad.Show();

            this.Visible = false;

        }
    }
}
