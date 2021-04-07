using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLNControlENG3.Models;

namespace FLNControlENG3.DAL.Identificadores
{
    class MarcaDAL
    {
        public Marca find(int id)
        {
            Marca marca = null;

            MySqlPersistence conexao = MySqlPersistence.construir();
            string sql = @"SELECT id_marca, nome_marca 
                    FROM marca WHERE id_marca = @pMarcaId LIMIT 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pMarcaId", id);

            DbDataReader result = conexao.ExecuteSelect(sql, parameters);
            if (result.HasRows)
            {
                result.Read();

                marca = new Marca(
                    Convert.ToInt32(result["id_marca"]),
                    result["nome_marca"].ToString()
                );
            }

            conexao.Close();
            return marca;
        }

        public List<Marca> findByNome(string nome)
        {
            MySqlPersistence conexao = MySqlPersistence.construir();
            string sql = @"SELECT id_marca, nome_marca
                    FROM marca WHERE LOWER(nome_marca) = @pMarcaNome ORDER BY id_marca";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pMarcaNome", "LOWER(%" + nome + "%)");

            List<Marca> marcas = new List<Marca>();
            DbDataReader result = conexao.ExecuteSelect(sql, parameters);
            if (result.HasRows)
            {
                Marca marca;
                while (result.Read())
                {
                    marca = new Marca(
                        Convert.ToInt32(result["id_marca"]),
                        result["nome_marca"].ToString());
                }
            }

            conexao.Close();
            return marcas;
        }

        public int save(Marca marca)
        {
            MySqlPersistence database = MySqlPersistence.construir();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;

            if (marca.getId() > 0)
            {
                sql = @"UPDATE 
                    marca SET  
                        nome_marca = @pMarcaNome
                    WHERE id_marca = @pMarcaId";
                parameters.Add("@pMarcaId", marca.getId());
            }
            else
            {
                sql = @"INSERT INTO 
                    marca(nome_marca)
                    VALUES(@pMarcaNome)";
            }

            parameters.Add("@pMarcaNome", marca.getNome());
            database.ExecuteNonQuery(sql, parameters);

            return database.getUltimoId();
        }
    }
}
