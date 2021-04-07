using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLNControlENG3.Models;

namespace FLNControlENG3.DAL.QuantidadeProdutoUnidadeMedidaDAL
{
    class QuantidadeProdutoUnidadeMedidaDAL
    {
        private MySqlPersistence db;
        private List<QuantidadeProdutoUnidadeMedida> Mapeamento(DbDataReader dr)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            UnidadeMedidaDAL unidadeMedidaDAL = new UnidadeMedidaDAL();
            List<QuantidadeProdutoUnidadeMedida> todos = new List<QuantidadeProdutoUnidadeMedida>();
            while (dr.Read())
            {
                QuantidadeProdutoUnidadeMedida quantidadeProdutoUnidadeMedida = new QuantidadeProdutoUnidadeMedida();
                quantidadeProdutoUnidadeMedida.setId(Convert.toInt32(response["id"].toString()));
                quantidadeProdutoUnidadeMedida.setProduto(produtoDAL.find(Convert.toInt32(response["idProduto"].toString())));
                quantidadeProdutoUnidadeMedida.setUnidadeMedida( unidadeMedidaDAL.pesquisaPorCodigo(Convert.toFloat(response["idUnidadeMedida"].toString())));
                quantidadeProdutoUnidadeMedida.setQuantidade( (float)Convert.ToDouble(db["quantidade"].toString()));
                todos.Add(quantidadeProdutoUnidadeMedida);
            }

            bd.Close();

            return todos;
        }
        public List<QuantidadeProdutoUnidadeMedida> pesquisaPorCodigoProduto(int codigoProduto)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            UnidadeMedidaDAL unidadeMedidaDAL = new UnidadeMedidaDAL();
            QuantidadeProdutoUnidadeMedida quantidadeProdutoUnidadeMedida = new QuantidadeProdutoUnidadeMedida();
            db = MySqlPersistence.construir();
            string query = @"
                SELECT id ,idUnidadeMedida ,idProduto ,quantidade 
                FROM  eng3banco . quantidadeprodutounidademedida 
                where idProduto = " + codigoProduto.toString();
            return this.Mapeamento(db.ExecuteSelect(query)); ;
        }
        public List<QuantidadeProdutoUnidadeMedida> pesquisaPorCodigoUnidadeMedida(int codigoUnidadeMedida)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();
            UnidadeMedidaDAL unidadeMedidaDAL = new UnidadeMedidaDAL();
            QuantidadeProdutoUnidadeMedida quantidadeProdutoUnidadeMedida = new QuantidadeProdutoUnidadeMedida();
            db = MySqlPersistence.construir();
            string query = @"
                SELECT id ,idUnidadeMedida ,idProduto ,quantidade 
                FROM  eng3banco . quantidadeprodutounidademedida 
                where idUnidadeMedia = " + codigoUnidadeMedida.toString();

            return this.Mapeamento(db.ExecuteSelect(query));
        }

        public bool gravarQuantidadeProdutoUnidadeMedida(QuantidadeProdutoUnidadeMedida novo)
        {
            db = MySqlPersistence.construir();

            string sql = @"
                    INSERT INTO quantidadeprodutounidademedida 
                    (
                     idUnidadeMedida ,
                     idProduto ,
                     quantidade )
                    VALUES
                    (
                        @idUnidadeMedida ,
                        @idProduto ,
                        @quantidade );
            ";

            Dicionary<string, object> parametros = new Dicionary<string, object>();

            parametros.Add("@idUnidadeMedida", novo.getUnidadeMedida().getId());
            parametros.Add("@idProduto", novo.getProduto().getId());
            parametros.Add("@quantidade", novo.getQuantidade());

            db.ExecuteNonQuery(sql);
            novo.setId(db.getUltimoId());

            return (novo.getId = !null);
        }
    }
}
