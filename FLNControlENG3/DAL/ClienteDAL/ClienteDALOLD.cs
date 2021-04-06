/*using System;
using System.Collections.Generic;
using System.Data.Common;
using FLNControl.Models;
using FLNControlENG3.DAL;

namespace FLNControl.DAL.ClienteDAL
{
    public class ClienteDALOLD
    {
        MySqlPersistence bd = MySqlPersistence.construir();

        public List<Cliente_OLD> Mapeamento(DbDataReader dr)
        {
            List<Cliente_OLD> clientes = new List<Cliente_OLD>();

            while (dr.Read())
            {
                Cliente_OLD cliente = new Cliente_OLD();
                cliente.Codigo = Convert.ToInt32(dr["cli_codigo"].ToString());
                cliente.Nome = dr["cli_nome"].ToString();
                cliente.Cpf = dr["cli_cpf"].ToString();
                cliente.Telefone = dr["cli_telefone"].ToString();
                cliente.Email = dr["cli_email"].ToString();
                cliente.DataNascimento = dr["cli_data_nascimento"].ToString();
                cliente.Fiado = Convert.ToInt32(dr["cli_fiado"].ToString());
                cliente.ValorLimiteFiado = Convert.ToDouble(dr["cli_valor_limite_fiado"].ToString());
                cliente.DiasVencimento = Convert.ToInt32(dr["cli_data_vencimento"].ToString());

                clientes.Add(cliente);
            }
            bd.Close();

            return clientes;
        }
        public List<Cliente_OLD> ListarTodosCliente()
        {
            
            string sql = "select * from cliente";

            return this.Mapeamento(bd.ExecuteSelect(sql));
        }
        public List<Cliente_OLD> ListarClientesPorNome(string nome)
        {
            string sql = "select * from cliente where cli_nome like '"+nome+"%'";

            return this.Mapeamento(bd.ExecuteSelect(sql));
        }
        public List<Cliente_OLD> ListarClientesPorCPF(string cpf)
        {
            string sql = "select * from cliente where cli_cpf like '" + cpf +"%'";

            return this.Mapeamento(bd.ExecuteSelect(sql));
        }
        public List<Cliente_OLD> ListarClientesPorTelefone(string telefone)
        {
            string sql = "select * from cliente where cli_telefone like '" + telefone + "%'";

            return this.Mapeamento(bd.ExecuteSelect(sql));
        }
        public Cliente_OLD BuscarClientesPorCodigo(int codigo)
        {
            string sql = "select * from cliente where cli_codigo like '" + codigo + "'%";

            DbDataReader dr = bd.ExecuteSelect(sql);

            Cliente_OLD cliente = new Cliente_OLD();
            cliente.Codigo = Convert.ToInt32(dr["cli_codigo"].ToString());
            cliente.Nome = dr["cli_nome"].ToString();
            cliente.Cpf = dr["cli_cpf"].ToString();
            cliente.Telefone = dr["cli_telefone"].ToString();
            cliente.Email = dr["cli_email"].ToString();
            cliente.DataNascimento = dr["cli_data_nascimento"].ToString();
            cliente.Fiado = Convert.ToInt32(dr["cli_fiado"].ToString());
            cliente.ValorLimiteFiado = Convert.ToDouble(dr["cli_valor_limite_fiado"].ToString());
            cliente.DiasVencimento = Convert.ToInt32(dr["cli_data_vencimento"].ToString());

            return cliente;
        }
        public bool GravarClienteCompleto(Cliente_OLD novo)
        {
            MySqlPersistence bd = MySqlPersistence.construir();

            string sql = @"INSERT INTO cliente
                                        (cli_nome,
                                        cli_cpf,
                                        cli_telefone,
                                        cli_email,
                                        cli_data_nascimento,
                                        cli_fiado,
                                        cli_valor_limite_fiado,
                                        cli_data_vencimento)
                                        VALUES
                                        (@nome,
                                        @cpf,
                                        @telefone,
                                        @email,
                                        @dataNascimento,
                                        @Fiado,
                                        @valorLimiteFiado,
                                        @dataVencimento)";

            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@nome", novo.Nome);
            parameter.Add("@cpf", novo.Cpf);
            parameter.Add("@telefone", novo.Telefone);
            parameter.Add("@email", novo.Email);
            parameter.Add("@dataNascimento", novo.DataNascimento);
            parameter.Add("@Fiado", novo.Fiado);
            parameter.Add("@valorLimiteFiado", novo.ValorLimiteFiado);
            parameter.Add("@dataVencimento", novo.DiasVencimento);

            bd.ExecuteNonQuery(sql, parameter);

            novo.Codigo = bd.getUltimoId();

            return novo.Codigo == 0;
        }
        public bool ExcluirCliente(int codigo)
        {
            string sql = "delete cliente where cli_codigo" + codigo;

            return (bd.ExecuteNonQuery(sql) > 0);

        }
        public bool AlterarClienteCompleto(Cliente_OLD novo)
        {
            MySqlPersistence bd = MySqlPersistence.construir();

            string sql = @"UPDATE cliente SET
                                        cli_nome = @nome,
                                        cli_cpf = @cpf,
                                        cli_telefone = @telefone,
                                        cli_email = @email,
                                        cli_data_nascimento = @dataNascimento,
                                        cli_fiado = @Fiado,
                                        cli_valor_limite_fiado = @valorLimiteFiado,
                                        cli_data_vencimento = @dataVencimento
                                        WHERE cli_codigo = @codigo";

            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@codigo", novo.Codigo);
            parameter.Add("@nome", novo.Nome);
            parameter.Add("@cpf", novo.Cpf);
            parameter.Add("@telefone", novo.Telefone);
            parameter.Add("@email", novo.Email);
            parameter.Add("@dataNascimento", novo.DataNascimento);
            parameter.Add("@Fiado", novo.Fiado);
            parameter.Add("@valorLimiteFiado", novo.ValorLimiteFiado);
            parameter.Add("@dataVencimento", novo.DataNascimento);

            return bd.ExecuteNonQuery(sql, parameter) != 0;
        }
    }
}
*/