using FLNControl.Dados.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace FLNControl.Dados.Persistencia
{
    class ContaPagarDAO
    {
      
        public ContasPagar find(int id)
        {
            ContasPagar conta = null;

            MySqlPersistence conexao = MySqlPersistence.GetInstancia();
            string sql = @"SELECT   idContasPagar,
                                    DataVencimento,
                                    DataCadastro,
                                    ValorConta,
                                    CodigoFornecedor,
                                    Quitada
                                FROM eng3banco.contaspagar
                                where pidContasPagar = idContasPagar;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pidContasPagar", id);

            DbDataReader result = conexao.ExecutarSelect(sql, parameters);
            if (result.HasRows)
            {
                result.Read();

                double valor;
                Double.TryParse(result["ValorConta"].ToString(), out valor);

                conta = new ContasPagar(
                    Convert.ToInt32(result["idContasPagar"]),
                    Convert.ToDateTime(result["DataVencimento"]),
                    Convert.ToDateTime(result["DataCadastro"]),
                    valor,
                    Convert.ToInt32(result["CodigoFornecedor"]),
                        Convert.ToInt32(result["Quitada"])
                );
            }

            conexao.Fechar();
            return conta;
        }

        public List<ContasPagar> findByNome(int codigofornecedor)
        {
            MySqlPersistence conexao = MySqlPersistence.GetInstancia();
            string sql = @"SELECT   idContasPagar,
                                    DataVencimento,
                                    DataCadastro,
                                    ValorConta,
                                    CodigoFornecedor,
                                    Quitada
                                FROM eng3banco.contaspagar
                                ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (codigofornecedor != 0)
            {
                parameters.Add("@pCodigoFornecedor", codigofornecedor);
                sql += "where CodigoFornecedor = pCodigoFornecedor";
            }

            List<ContasPagar> contas = new List<ContasPagar>();
            DbDataReader result = conexao.ExecutarSelect(sql, parameters);
            if (result.HasRows)
            {
                ContasPagar conta;
                while (result.Read())
                {
                    result.Read();

                    double valor;
                    Double.TryParse(result["ValorConta"].ToString(), out valor);

                    conta = new ContasPagar(
                        Convert.ToInt32(result["idContasPagar"]),
                        Convert.ToDateTime(result["DataVencimento"]),
                        Convert.ToDateTime(result["DataCadastro"]),
                        valor,
                        Convert.ToInt32(result["CodigoFornecedor"]),
                        Convert.ToInt32(result["Quitada"])
                    );
                    contas.Add(conta);
                }
            }

            conexao.Fechar();
            return contas;
        }

        public int save(ContasPagar conta)
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;

            if (conta.getCodigo() > 0)
            {
                sql = @"UPDATE 
                    eng3banco.ContasPagar SET  
                        DataVencimento = @pDataVencimento, 
                        DataCadastro = @pDataCadastro, 
                        ValorConta = @pValorConta,
                        CodigoFornecedor = @pCodigoFornecedor,
                        Quitada = @pQuitada
                    WHERE idContasPagar = @pidContasPagar";
                parameters.Add("@pidContasPagar", conta.getCodigo());
            }
            else
            {
                sql = @"INSERT INTO 
                    eng3banco.contaspagar(DataVencimento, DataCadastro, ValorConta, CodigoFornecedor,Quitada)
                    VALUES(@pDataVencimento, @pDataCadastro, @pValorConta,@pCodigoFornecedor,@pQuitada)";
            }

            parameters.Add("@pDataVencimento", conta.getDatavencimento());
            parameters.Add("@pDataCadastro", conta.getDatacadastro());
            parameters.Add("@pValorConta", conta.getValorConta());
            parameters.Add("@pCodigoFornecedor", conta.getCodigoFornecedor());
            parameters.Add("@pQuitada", conta.getQuitado());
            database.ExecutarNonQuery(sql, parameters);

            return (int)database.GetUltimoId();
        }
    }
}
