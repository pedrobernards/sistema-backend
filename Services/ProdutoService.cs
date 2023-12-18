using ProgramacaoZero.Entities;
using ProgramacaoDoZero.Models;
using ProgramacaoZero.Repositories;

namespace ProgramacaoZero.Services
{
    public class ProdutoService
    {
        private string _connectionString;

        public ProdutoService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public CadastroProdutoResult Cadastro(string nome, string codigo, decimal preco, int qtdeEstoque)
        {
            var result = new CadastroProdutoResult();

            var repositorio = new ProdutoRepository(_connectionString);

            var produto = repositorio.ObterPorCodigo(codigo);

            if (produto != null)
            {
                result.sucesso = false;
                result.mensagem = "Produto já existe para esse código";
            }
            else
            {
                produto = new Produto();

                produto.Nome = nome;
                produto.Codigo = codigo;
                produto.Preco = preco;
                produto.QtdeEstoque = qtdeEstoque;

                var affectedRows = repositorio.Inserir(produto);

                if (affectedRows > 0)
                {
                    result.sucesso = true;
                }
                else
                {
                    result.sucesso = false;
                    result.mensagem = "Não foi possível inserir o produto";
                }
            }

            return result;
        }
    }
}