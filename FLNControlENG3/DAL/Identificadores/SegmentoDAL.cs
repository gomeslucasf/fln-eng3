using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLNControlENG3.Models;

namespace FLNControlENG3.DAL.Identificadores
{
    class SegmentoDAL
    {
        public SegmentoDAL find(int id)
        {
            Segmento segmento = null;

            MySqlPersistence conexao = MySqlPersistence.construir();
            string sql = @"SELECT id_seg, descricao_seg 
                    FROM segmento WHERE id_seg = @pSegId LIMIT 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pSegId", id);

            DbDataReader result = conexao.ExecuteSelect(sql, parameters);
            if (result.HasRows)
            {
                result.Read();

                segmento = new Segmento(
                    Convert.ToInt32(result["id_seg"]),
                    result["descricao_seg"].ToString()
                );
            }

            conexao.Close();
            return segmento;
        }

        public int save(Segmento segmento)
        {
            MySqlPersistence database = MySqlPersistence.construir();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;

            if (segmento.getId() > 0)
            {
                sql = @"UPDATE 
                    segmento SET  
                        descricao_seg = @pSegDescricao
                    WHERE id_seg = @pSegId";
                parameters.Add("@pSegId", segmento.getId());
            }
            else
            {
                sql = @"INSERT INTO 
                    segmento(descricao_seg)
                    VALUES(@pSegDescricao)";
            }

            parameters.Add("@pSegDescricao", segmento.getDescricao());
            database.ExecuteNonQuery(sql, parameters);

            return database.getUltimoId();
        }
    }
}
