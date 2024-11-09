using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Form_List_Prod : Form
    {
        private List<Produto> produtosList = new List<Produto>();

        public Form_List_Prod()
        {
            InitializeComponent();
        }

        private List<Produto> CarregarProdutos()
        {
            string caminhoArquivo = @"C:\Users\ramos\source\repos\WinFormsApp1\data\cadastros.txt";
            
            var produtos = new List<Produto>();

            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo de produtos não encontrado.");
                return produtos;
            }

            string[] linhas = File.ReadAllLines(caminhoArquivo);
            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');

                if (dados[0] == "produto")
                {
                    var produto = new Produto
                    {
                        Nome = dados[1],
                        Preco = decimal.Parse(dados[2]),
                        Quantidade = int.Parse(dados[3]),
                        Tributacao = decimal.Parse(dados[4]),
                        Categoria = dados[5],
                        Descricao = dados[6]
                    };
                    produtos.Add(produto);
                }
            }
            return produtos;
        }

        private void ListarProdutos()
        {
            produtosList = CarregarProdutos();
            listBoxProdutos.Items.Clear();

            foreach (var produto in produtosList)
            {
                listBoxProdutos.Items.Add($"{produto.Nome} - Preço: {produto.Preco} - Estoque: {produto.Quantidade}");
            }
        }

        private void Form_List_Prod_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void listBoxProdutos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxProdutos.SelectedIndex != -1)
            {
                Produto produtoSelecionado = produtosList[listBoxProdutos.SelectedIndex];

                Form_Cad_Produto formCadastro = new Form_Cad_Produto(produtoSelecionado);
                formCadastro.ShowDialog();

                ListarProdutos();
            }
        }
    }
}
