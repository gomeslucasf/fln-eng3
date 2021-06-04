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
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.Save(p);
        }

        public IEnumerable<Produto> BuscarProduto(string termo, string tipoBusca)
        {
            ProdutoDAO pDao = new ProdutoDAO();
            List<Produto> lp = null;

            switch(tipoBusca)
            {
                case "desc":
                    lp = pDao.FindByDescription(termo);
                    break;

                case "marca":
                    lp = pDao.FindByBrand(termo);
                    break;

                case "categ":
                    lp = pDao.FindByCategory(termo);
                    break;
            }

            return lp;
        }

        public Produto BuscarProduto(int id)
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.Find(id);
        }

        public List<Produto> ListarProdutos()
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.FindAll();
        }

        public bool DeletarProduto(int id)
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.Delete(id) > 0;
        }
    }
}
