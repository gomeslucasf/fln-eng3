using FLNControl.Dados.Modelo;
using FLNControl.Dados.Persistencia;
using System;
using System.Collections.Generic;

namespace FLNControl.Fachada.Controle
{
    public class ProdutoControl
    {
        private static ProdutoControl _instancia;

        private ProdutoControl()
        {

        }

        public static ProdutoControl ObterInstancia()
        {
            if (_instancia is null)
                _instancia = new ProdutoControl();

            return _instancia;
        }

        public int InserirProduto(Produto p)
        {
            return p.Salvar();
        }

        public IEnumerable<Produto> BuscarProduto(string termo, string tipoBusca)
        {
            Produto p = new Produto();
            IEnumerable<Produto> lp = null;

            switch(tipoBusca)
            {
                case "desc":
                    lp = p.BuscarProdutosPorDescricao(termo);
                    break;

                case "marca":
                    lp = p.BuscarProdutosPorMarca(termo);
                    break;

                case "categ":
                    lp = p.BuscarProdutosPorCategoria(termo);
                    break;
            }

            return lp;
        }

        public Produto BuscarProduto(int id)
        {
            Produto p = new Produto();

            return p.BuscarProdutosPorId(id);
        }

        public IEnumerable<Produto> ListarProdutos()
        {
            Produto p = new Produto();

            return p.ListarTodos();
        }

        public bool DeletarProduto(Produto p)
        {
            return p.Deletar();
        }
    }
}
