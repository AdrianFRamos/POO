using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Form_Cad_Produto : Form
    {
        private Produto _produtoParaEditar;
        private bool _editando = false;
        private string caminhoArquivo = @"C:\Users\ramos\source\repos\WinFormsApp1\data\cadastros.txt";

        public Form_Cad_Produto()
        {
            InitializeComponent();
        }

        public Form_Cad_Produto(Produto produto) : this()
        {
            _produtoParaEditar = produto;
            _editando = true;
            PreencherCampos(produto);
        }

        private void PreencherCampos(Produto produto)
        {
            txtName.Text = produto.Nome;
            txtPreco.Text = produto.Preco.ToString();
            txtQuant.Text = produto.Quantidade.ToString();
            txtTrib.Text = produto.Tributacao.ToString();
            txtCateg.Text = produto.Categoria;
            txtDesc.Text = produto.Descricao;
        }

        // Botão 1: Cadastro de um novo produto
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtName.Text;
            decimal.TryParse(txtPreco.Text, out decimal preco);
            int.TryParse(txtQuant.Text, out int quantidade);
            decimal.TryParse(txtTrib.Text, out decimal tributacao);
            string categoria = txtCateg.Text;
            string descricao = txtDesc.Text;

            if (string.IsNullOrWhiteSpace(nome) || preco <= 0 || quantidade < 0 || tributacao < 0 || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
                return;
            }

            using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
            {
                sw.WriteLine($"produto,{nome},{preco},{quantidade},{tributacao},{categoria},{descricao}");
            }
            MessageBox.Show("Produto cadastrado com sucesso!");

            txtName.Clear();
            txtPreco.Clear();
            txtQuant.Clear();
            txtTrib.Clear();
            txtCateg.Clear();
            txtDesc.Clear();

            // Fecha o formulário após cadastro
            this.Close();
            var FormListProd = new Form_List_Prod();
            FormListProd.Show();
        }

        // Botão 2: Editar o produto existente
        private void button2_Click(object sender, EventArgs e)
        {
            if (!_editando)
            {
                MessageBox.Show("Nenhum produto selecionado para edição.");
                return;
            }

            string nome = txtName.Text;
            decimal.TryParse(txtPreco.Text, out decimal preco);
            int.TryParse(txtQuant.Text, out int quantidade);
            decimal.TryParse(txtTrib.Text, out decimal tributacao);
            string categoria = txtCateg.Text;
            string descricao = txtDesc.Text;

            if (string.IsNullOrWhiteSpace(nome) || preco <= 0 || quantidade < 0 || tributacao < 0 || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
                return;
            }

            AtualizarProduto(_produtoParaEditar.Nome, nome, preco, quantidade, tributacao, categoria, descricao);
            MessageBox.Show("Produto atualizado com sucesso!");

            // Fecha o formulário após edição
            this.Close();
            var FormListProd = new Form_List_Prod();
            FormListProd.Show();
        }

        // Método para atualizar o produto no arquivo
        private void AtualizarProduto(string nomeAntigo, string novoNome, decimal novoPreco, int novaQuantidade, decimal novaTributacao, string novaCategoria, string novaDescricao)
        {
            var linhasAtualizadas = new List<string>();

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var dados = linha.Split(',');

                if (dados[0] == "produto" && dados[1] == nomeAntigo)
                {
                    linhasAtualizadas.Add($"produto,{novoNome},{novoPreco},{novaQuantidade},{novaTributacao},{novaCategoria},{novaDescricao}");
                }
                else
                {
                    linhasAtualizadas.Add(linha);
                }
            }

            File.WriteAllLines(caminhoArquivo, linhasAtualizadas);
        }

        // Botão 3: Excluir o produto atual
        private void button3_Click(object sender, EventArgs e)
        {
            if (!_editando)
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.");
                return;
            }

            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ExcluirProduto(_produtoParaEditar.Nome);
                MessageBox.Show("Produto excluído com sucesso.");

                // Fecha o formulário após a exclusão
                this.Close();
                var FormListProd = new Form_List_Prod();
                FormListProd.Show();
            }
        }

        // Método para excluir um produto do arquivo
        private void ExcluirProduto(string nomeProduto)
        {
            var linhasAtualizadas = new List<string>();

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var dados = linha.Split(',');

                if (!(dados[0] == "produto" && dados[1] == nomeProduto))
                {
                    linhasAtualizadas.Add(linha);
                }
            }

            File.WriteAllLines(caminhoArquivo, linhasAtualizadas);
        }

    }
}
