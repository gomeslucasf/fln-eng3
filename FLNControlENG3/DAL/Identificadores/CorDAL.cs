using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLNControlENG3.Models;

namespace FLNControlENG3.DAL.Identificadores
{
    class CorDAL
    {
        public CorDAL find(int id)
        {
            Cor cor = null;

            MySqlPersistence conexao = MySqlPersistence.construir();
            string sql = @"SELECT id_cor, nome_cor 
                    FROM cor WHERE id_cor = @pCorId LIMIT 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pCorId", id);

            DbDataReader result = conexao.ExecuteSelect(sql, parameters);
            if (result.HasRows)
            {
                result.Read();

                cor = new Cor(
                    Convert.ToInt32(result["id_cor"]),
                    result["nome_cor"].ToString()
                );
            }

            conexao.Close();
            return cor;
        }

        public List<Cor> findByNome(string nome)
        {
            MySqlPersistence conexao = MySqlPersistence.construir();
            string sql = @"SELECT id_cor, nome_cor
                    FROM cor WHERE LOWER(nome_cor) = @pCorNome ORDER BY id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pCorNome", "LOWER(%" + nome + "%)");

            List<Cor> cores = new List<Cor>();
            DbDataReader result = conexao.ExecuteSelect(sql, parameters);
            if (result.HasRows)
            {
                Cor cor;
                while (result.Read())
                {
                    cor = new Cor(
                        Convert.ToInt32(result["id_cor"]),
                        result["nome_cor"].ToString());
                }
            }

            conexao.Close();
            return cores;
        }

        public int save(Cor cor)
        {
            MySqlPersistence database = MySqlPersistence.construir();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;

            if (cor.getId() > 0)
            {
                sql = @"UPDATE 
                    cor SET  
                        nome_cor = @pCorNome
                    WHERE id_cor = @pCorId";
                parameters.Add("@pCorId", cor.getId());
            }
            else
            {
                sql = @"INSERT INTO 
                    cor(nome_cor)
                    VALUES(@pCorNome)";
            }

            parameters.Add("@pCorNome", cor.getNome());
            database.ExecuteNonQuery(sql, parameters);

            return database.getUltimoId();
        }
    }
}
