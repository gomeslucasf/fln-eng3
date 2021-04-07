using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControlENG3.Models
{
    class QuantidadeProdutoUnidadeMedida
    {
        private int id;
        private UnidadeMedida unidadeMedida;
        private Produto produto;
        private float quantidade;

        public QuantidadeProdutoUnidadeMedida() { }

        public QuantidadeProdutoUnidadeMedida(int id, UnidadeMedida un, Produto pro, float qtd)
        {
            this.id = id;
            this.unidadeMedida = un;
            this.produto = pro;
            this.quantidade = qtd;
        }

        public int getId() {
            return this.id;
        }
        public void setId(int input) {
            this.id = input;
        }

        public UnidadeMedida getUnidadeMedida() { 
            return this.idUnidadeMedida;
        }
        public void setUnidadeMedida(UnidadeMedida input) {
            this.idUnidadeMedida = input;
        }
        public Produto getProduto() {
            return this.produto;
        }
        public void setProduto(Produto input) {
            this.produto = input;
        }
        public float getQuantidade() {
            return this.quantidade;
        }
        public void setQuantidade(float input) { }

        public List<QuantidadeProdutoUnidadeMedida> pesquisaPorCodigoUnidadeMedida(int codigoUnidadeMedida) {
            QuantidadeProdutoUnidadeMedidaDAL dal = new QuantidadeProdutoUnidadeMedidaDAL();
            return dal.pesquisaPorCodigoUnidadeMedida(codigoUnidadeMedida);
        }
        public List<QuantidadeProdutoUnidadeMedida> pesquisaPorCodigoProduto(int codigoProduto) {
            QuantidadeProdutoUnidadeMedidaDAL dal = new QuantidadeProdutoUnidadeMedidaDAL();
            return dal.pesquisaPorCodigoProduto(codigoProduto);
        }
        public bool gravarQuantidadeProdutoUnidadeMedida(QuantidadeProdutoUnidadeMedida novo) { 
            QuantidadeProdutoUnidadeMedidaDAL dal = new QuantidadeProdutoUnidadeMedidaDAL();
            return dal.gravarQuantidadeProdutoUnidadeMedida(novo);
        }
    }
}
