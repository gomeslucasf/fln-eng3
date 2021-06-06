using FLNControl.Dados.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace FLNControl.Dados.Persistencia
{
    class ContasReceberDAO
    {
        public ContasReceber find(int id)
        {
            ContasReceber conta = null;

            MySqlPersistence conexao = MySqlPersistence.GetInstancia();
            string sql = @"SELECT   idContasReceber,
                                    DataVencimento,
                                    DataCadastro,
                                    ValorConta,
                                    CodigoCliente,
                                    Quitada
                                FROM eng3banco.contasreceber
                                where pidContasReceber = idContasReceber;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pidContasReceber", id);

            DbDataReader result = conexao.ExecutarSelect(sql, parameters);
            if (result.HasRows)
            {
                result.Read();

                double valor; 
                Double.TryParse(result["ValorConta"].ToString(), out valor);

                conta = new ContasReceber(
                    Convert.ToInt32(result["idContasReceber"]),
                    Convert.ToDateTime(result["DataVencimento"]),
                    Convert.ToDateTime(result["DataCadastro"]),
                    valor,
                    Convert.ToInt32(result["CodigoCliente"]),
                    Convert.ToInt32(result["Quitada"])
                );
            }

            conexao.Fechar();
            return conta;
        }

        public List<ContasReceber> findByNome(int codigocliente)
        {
            MySqlPersistence conexao = MySqlPersistence.GetInstancia();
            string sql = @"SELECT   idContasReceber,
                                    DataVencimento,
                                    DataCadastro,
                                    ValorConta,
                                    CodigoCliente,
                                    Quitada
                                FROM eng3banco.contasreceber
                                ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (codigocliente != 0)
            {
                parameters.Add("@pCodigoCliente", codigocliente);
                sql+= "where CodigoCliente = pCodigoCliente";
            }

            List<ContasReceber> contas = new List<ContasReceber>();
            DbDataReader result = conexao.ExecutarSelect(sql, parameters);
            if (result.HasRows)
            {
                ContasReceber conta;
                while (result.Read())
                {
                    result.Read();

                    double valor;
                    Double.TryParse(result["ValorConta"].ToString(), out valor);

                    conta = new ContasReceber(
                        Convert.ToInt32(result["idContasReceber"]),
                        Convert.ToDateTime(result["DataVencimento"]),
                        Convert.ToDateTime(result["DataCadastro"]),
                        valor,
                        Convert.ToInt32(result["CodigoCliente"]),
                        Convert.ToInt32(result["Quitada"])
                    );
                    contas.Add(conta);
                }
            }

            conexao.Fechar();
            return contas;
        }

        public int save(ContasReceber conta)
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;

            if (conta.getCodigo() > 0)
            {
                sql = @"UPDATE 
                    eng3banco.contasreceber SET  
                        DataVencimento = @pDataVencimento, 
                        DataCadastro = @pDataCadastro, 
                        ValorConta = @pValorConta,
                        CodigoCliente = @pCodigoCliente,
                        Quitada = @pQuitada
                    WHERE idContasReceber = @pidContasReceber";
                parameters.Add("@pidContasReceber", conta.getCodigo());
            }
            else
            {
                sql = @"INSERT INTO 
                    eng3banco.contasreceber(DataVencimento, DataCadastro, ValorConta, CodigoCliente,Quitada)
                    VALUES(@pDataVencimento, @pDataCadastro, @pValorConta,@pCodigoCliente,@pQuitada)";
            }

            parameters.Add("@pDataVencimento", conta.getDatavencimento()) ;
            parameters.Add("@pDataCadastro", conta.getDatacadastro());
            parameters.Add("@pValorConta", conta.getValorConta());
            parameters.Add("@pCodigoCliente", conta.getCodigoCliente());
            parameters.Add("@pQuitada", conta.getQuitado());
            
            database.ExecutarNonQuery(sql, parameters);

            return (int)database.GetUltimoId();
        }
    }
}
