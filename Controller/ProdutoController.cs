using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Controller
{
    internal class ProdutoController
    {
        private string caminhoArquivo = @"C:\Users\ramos\source\repos\WinFormsApp1\data\cadastros.txt";

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
    }
}
