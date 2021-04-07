using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Threading.Tasks;
using FLNControlENG3.Models;

namespace FLNControlENG3.DAL.UnidadeMedidaDAL
{
    class UnidadeMedidaDAL
    {

        private MySqlPersistence db;
        private List<UnidadeMedida> Mapeamento(DbDataReader dr) {

            List<UnidadeMedida> todos = new List<UnidadeMedida>();
            while(dr.Read())
            {
                UnidadeMedida unidadeMedida = new UnidadeMedida();
                unidadeMedida.setId ( Convert.toInt32(response["id_lote"].toString()));
                unidadeMedida.setDescricao ( response["id_lote"].toString());
                unidadeMedida.setMetragem ( (float)Convert.ToDouble(response["id_lote"].toString()));
                todos.Add(unidadeMedida);
            }

            bd.Close();

            return todos;
        }
        public UnidadeMedida pesquisaPorCodigo(int codigo) {

            UnidadeMedida unidadeMedida;
            db = MySqlPersistence.construir();

            string query = @"select id_un_medida, tipo_un_medida, metragem_un_medidal from un_medida where id_un_medida"+codigo.toString();

            DbDataReader response = db.ExecuteSelect(query);

            unidadeMedida.setId ( Convert.toInt32(response["id_lote"].toString()));
            unidadeMedida.setDescricao (response["id_lote"].toString());
            unidadeMedida.setMetragem ( (float)Convert.ToDouble(response["id_lote"].toString()));

            return unidadeMedida;
        }
        public List<UnidadeMedida> retornaTodas() {

            db = MySqlPersistence.construir();
            string query = @"select id_un_medida, tipo_un_medida, metragem_un_medidal from un_medida";

            return this.Mapeamento(db.ExecuteSelect(sql));
        }
        public bool gravarUnidadeMedida(UnidadeMedida novo)
        { 
            db = MySqlPersistence.construir();

            string sql = @"
                    INSERT INTO eng3banco.un_medida
                    (
                    tipo_un_medida,
                    metragem_un_medidal)
                    VALUES
                    (
                    @tipo_un_medida,
                    @metragem_un_medidal);
            ";

            Dicionary<string, object> parametros = new Dicionary<string, object>();

            parametros.Add("@tipo_un_medida", novo.getDescricao());
            parametros.Add("@metragem_un_medidal", novo.getMetragem());

            db.ExecuteNonQuery(sql);
            novo.setId(db.getUltimoId());

            return (novo.getId =! null);
        }

    }
}
