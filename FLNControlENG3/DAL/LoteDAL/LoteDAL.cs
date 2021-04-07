using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLNControlENG3.Models;

namespace FLNControlENG3.DAL.LoteDAL
{
    class LoteDAL
    {
        private MySqlPersistence db;
        private List<Lote> Mapeamento(DbDataReader dr)
        {
           
            List<Lote> todos = new List<Lote>();
            while (dr.Read())
            {
                Lote lote = new Lote();
                lote.setId(Convert.toInt32(dr["id"].toString()));
                lote.setCodExterno(dr["cod_externo_lote"].toString());
                lote.setDataFabricacao(dr["data_fab_lote"].toString());
                lote.setCodigoDeBarras(dr["gtin_lote"].toString());
                todos.Add(lote);
            }

            bd.Close();

            return todos;
        }
        public List<Lote> retornaTodos()
        {
            UnidadeMedida unidadeMedida;
            db = MySqlPersistence.construir();

            string query = @"
                SELECT lote.id_lote,
                        lote.cod_externo_lote,
                        lote.data_fab_lote,
                        lote.gtin_lote
                FROM lote; ";
            return this.Mapeamento(db.ExecuteSelect(query));
        }
        public Lote pesquisaPorCodigo(int codigo)
        {

            Lote lote = new Lote();
            db = MySqlPersistence.construir();

            string query = @"
                SELECT lote.id_lote,
                    lote.cod_externo_lote,
                    lote.data_fab_lote,
                    lote.gtin_lote
                FROM eng3banco.lote;
                WHERE lote.id_lote = " + codigo.toString();

            DbDataReader response = db.ExecuteSelect(query);

            lote.setId(Convert.toInt32(dr["id"].toString()));
            lote.setCodExterno(dr["cod_externo_lote"].toString());
            lote.setDataFabricacao(dr["data_fab_lote"].toString());
            lote.setCodigoDeBarras(dr["gtin_lote"].toString());

            return lote;
        }
        public bool gravarQuantidadeProdutoUnidadeMedida(Lote novo)
        {
            db = MySqlPersistence.construir();

            string sql = @"
                    INSERT INTO lote
                            (
                            cod_externo_lote,
                            data_fab_lote,
                            gtin_lote)
                        VALUES
                            (
                            @cod_externo_lote,
                            @data_fab_lote,
                            @gtin_lote);

            ";

            Dicionary<string, object> parametros = new Dicionary<string, object>();

            parametros.Add("@cod_externo_lote", novo.getCodExterno());
            parametros.Add("@data_fab_lote", novo.getDataFabricacao());
            parametros.Add("@gtin_lote", novo.getCodigoDeBarras());

            db.ExecuteNonQuery(sql);
            novo.setId(db.getUltimoId());

            return (novo.getId = !null);
        }

    }
}
