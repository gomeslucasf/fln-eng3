using FLNControlENG3.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControlENG3.DAL.ClienteDAL
{
    class ClienteDAL
    {
        public Cliente find(int id)
        {
            Cliente cliente = null;

            MySqlPersistence conexao = MySqlPersistence.construir();
            string sql = @"SELECT id, nome, endereco, cpf, telefone, dataNascimento 
                    FROM clientes WHERE id = @pClienteId LIMIT 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pClienteId", id);

            DbDataReader result = conexao.ExecuteSelect(sql, parameters);
            if (result.HasRows)
            {
                result.Read();

                cliente = new Cliente(
                    Convert.ToInt32(result["id"]),
                    result["nome"].ToString(),
                    result["endereco"].ToString(),
                    result["cpf"].ToString(),
                    result["telefone"].ToString(),
                    Convert.ToDateTime(result["dataNascimento"])
                );
            }

            conexao.Close();
            return cliente;
        }

        public List<Cliente> findByNome(string nome)
        {
            MySqlPersistence conexao = MySqlPersistence.construir();
            string sql = @"SELECT id, nome, endereco, cpf, telefone, dataNascimento 
                    FROM clientes WHERE LOWER(nome) = @pClienteNome ORDER BY id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pClienteNome", "LOWER(%"+nome+"%)");

            List<Cliente> clientes = new List<Cliente>();
            DbDataReader result = conexao.ExecuteSelect(sql, parameters);
            if (result.HasRows)
            {
                Cliente cliente;
                while (result.Read())
                {
                    cliente = new Cliente(
                        Convert.ToInt32(result["id"]),
                        result["nome"].ToString(),
                        result["endereco"].ToString(),
                        result["cpf"].ToString(),
                        result["telefone"].ToString(),
                        Convert.ToDateTime(result["dataNascimento"])
                    );
                }
            }

            conexao.Close();
            return clientes;
        }

        public int save(Cliente cliente)
        {
            MySqlPersistence database = MySqlPersistence.construir();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;

            if (cliente.getId() > 0)
            {
                sql = @"UPDATE 
                    clientes SET  
                        nome = @pClienteNome, 
                        endereco = @pClienteEndereco, 
                        cpf = @pClienteCPF,
                        telefone = @pClienteTelefone,
                        dataNascimento = @pClienteNascimento
                    WHERE id = @pClienteId";
                parameters.Add("@pClienteId", cliente.getId());
            }
            else
            {
                sql = @"INSERT INTO 
                    cliente(nome, endereco, cpf, 
                        telefone, dataNascimento)
                    VALUES(@pClienteNome, @pClienteEndereco, @pClienteCPF,
                        @pClienteTelefone, @pClienteNascimento
                    )";
            }

            parameters.Add("@pClienteNome", cliente.getNome());
            parameters.Add("@pClienteEndereco", cliente.getEndereco());
            parameters.Add("@pClienteCPF", cliente.getCPF());
            parameters.Add("@pClienteTelefone", cliente.getTelefone());
            parameters.Add("@pClienteNascimento", cliente.getDataNascimento());
            database.ExecuteNonQuery(sql, parameters);

            return database.getUltimoId();
        }
    }
}
