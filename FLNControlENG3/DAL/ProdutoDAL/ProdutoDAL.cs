using FLNControlENG3.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using FLNControlENG3.DAL;
using FLNControlENG3.DAL.ClienteDAL;

namespace FLNControlENG3.Models
{
    public class ProdutoDAL
    {
        public Produto find(int id)
        {
            Produto produto = null;
            MySqlPersistence database = MySqlPersistence.construir();
            string sql = @"SELECT id_prod, nome_prod FROM produto WHERE id_prod = @pProdId LIMIT 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pProdId", id);

            DbDataReader result = database.ExecuteSelect(sql, parameters);
            if (result.HasRows)
            {
                result.Read();

                produto = new Produto(
                    Convert.ToInt32(result["id_prod"]),
                    result["nome_prod"].ToString()
                );
            }

            Close();

            return produto;
        }

        private List<Observador> findObservers(int id)
        {
            MySqlPersistence database = MySqlPersistence.construir();
            string sql = @"SELECT idCliente FROM clientobservaproduto WHERE idProduto = @pProdId LIMIT 1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pProdId", id);

            ClienteDAL clienteDAL = new ClienteDAL();

            DbDataReader result = database.ExecuteSelect(sql, parameters);
            List<Observador> observadores = new List<Observador>();
            if(result.HasRows)
            {
                Cliente cliente;
                while(result.Read())
                {
                    cliente = clienteDAL.find(Convert.ToInt32(result["idCliente"]));
                    observadores.Add(cliente);
                }
            }

            database.Close();

            return observadores;
        }

        public int save(Produto produto)
        {
            MySqlPersistence database = MySqlPersistence.construir();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;
            if (produto.getId() > 0)
            {
                sql = @"UPDATE 
                    produto SET nome_prod = @pProdNome, 
                    WHERE id_prod = @pProdId";
                parameters.Add("@pProdId", produto.getId());
            }
            else
            {
                sql = @"INSERT INTO 
                    produto(nome_prod)
                        VALUES(@pProdCategoria)";
            }

            parameters.Add("@pProdNome", produto.getNome());
            database.ExecuteNonQuery(sql, parameters);

            int id = database.getUltimoId();

            saveObservers(id, produto.getObservadores());

            return id;
        }

        public void saveObservers(int id, List<Observador> observadores)
        {
            MySqlPersistence database = MySqlPersistence.construir();
            string sql = @"DELETE FROM clientobservaproduto WHERE idProduto = @pProdId";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pProdId", id);
            database.ExecuteNonQuery(sql, parameters);

            sql = @"INSERT INTO clientobservaproduto (idProduto, idCliente) VALUES";

            string sep = "";
            foreach(Cliente c in observadores)
            {
                sql += sep + "(" + id + "," + c.getId() + ")";
                sep = ",";
            }

            database.ExecuteNonQuery(sql, parameters);
        }
    }
}
