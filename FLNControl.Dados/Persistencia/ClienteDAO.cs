using FLNControl.Dados.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControl.Dados.Persistencia
{
    class ClienteDAO
    {
        public Cliente find(int id)
        {
            Cliente cliente = null;

            MySqlPersistence conexao = MySqlPersistence.GetInstancia();
            string sql = @"SELECT id, nome, endereco, cpf, telefone, dataNascimento 
                    FROM clientes WHERE id = @pClienteId LIMIT 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pClienteId", id);

            DbDataReader result = conexao.ExecutarSelect(sql, parameters);
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

            conexao.Fechar();
            return cliente;
        }

        public List<Cliente> findByNome(string nome)
        {
            MySqlPersistence conexao = MySqlPersistence.GetInstancia();
            string sql = @"SELECT id, nome, endereco, cpf, telefone, dataNascimento 
                    FROM clientes WHERE LOWER(nome) = @pClienteNome ORDER BY id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pClienteNome", "LOWER(%"+nome+"%)");

            List<Cliente> clientes = new List<Cliente>();
            DbDataReader result = conexao.ExecutarSelect(sql, parameters);
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

            conexao.Fechar();
            return clientes;
        }

        public int save(Cliente cliente)
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;

            if (cliente.GetId() > 0)
            {
                sql = @"UPDATE 
                    clientes SET  
                        nome = @pClienteNome, 
                        endereco = @pClienteEndereco, 
                        cpf = @pClienteCPF,
                        telefone = @pClienteTelefone,
                        dataNascimento = @pClienteNascimento
                    WHERE id = @pClienteId";
                parameters.Add("@pClienteId", cliente.GetId());
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

            parameters.Add("@pClienteNome", cliente.GetNome());
            parameters.Add("@pClienteEndereco", cliente.GetEndereco());
            parameters.Add("@pClienteCPF", cliente.GetCPF());
            parameters.Add("@pClienteTelefone", cliente.GetTelefone());
            parameters.Add("@pClienteNascimento", cliente.GetDataNascimento());
            database.ExecutarNonQuery(sql, parameters);

            return (int)database.GetUltimoId();
        }
    }
}
