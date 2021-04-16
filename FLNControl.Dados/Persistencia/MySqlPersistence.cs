using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FLNControl.Dados.Persistencia
{
    public class MySqlPersistence
    {
        private static MySqlPersistence _instancia;
        private MySqlConnection _conexao;
        private MySqlCommand _comando;
        private long _ultimoId;
        private string _strConexao;

        private MySqlPersistence()
        {
            _strConexao = Environment.GetEnvironmentVariable("StrConexao");
            _conexao = new MySqlConnection(_strConexao);
        }

        public static MySqlPersistence GetInstancia()
        {
            if (_instancia == null)
                _instancia = new MySqlPersistence();

            return _instancia;
        }

        public void Abrir()
        {
            try
            {
                _conexao.Open();
                _comando = _conexao.CreateCommand();
            }
            catch (Exception e)
            {
                throw new Exception($"Ocorreu um erro ao se conectar com banco de dados: {e.Message}");
            }
        }

        public void Fechar()
        {
            _conexao.Close();
        }

        public int ExecutarNonQuery(string sql, Dictionary<string, object> parametros = null)
        {
            _comando.CommandText = sql;

            if (parametros != null)
                foreach (var p in parametros)
                    _comando.Parameters.AddWithValue(p.Key, p.Value);

            int qtdLinhasAfetadas = _comando.ExecuteNonQuery();
            _ultimoId = _comando.LastInsertedId;

            return qtdLinhasAfetadas;
        }

        public object ExecutarSelectScalar(string sql, Dictionary<string, object> parametros = null)
        {
            _comando.CommandText = sql;

            if (parametros != null)
                foreach (var p in parametros)
                    _comando.Parameters.AddWithValue(p.Key, p.Value);

            object resultado = _comando.ExecuteScalar();

            return resultado;
        }

        public bool ExistemLinhas(string sql, Dictionary<string, object> parameter = null)
        {
            _comando.CommandText = sql;

            if (parameter != null)
                foreach (var p in parameter)
                    _comando.Parameters.AddWithValue(p.Key, p.Value);

            MySqlDataReader dr = _comando.ExecuteReader();

            return dr.HasRows;
        }

        public MySqlDataReader ExecutarSelect(string sql, Dictionary<string, object> parameter = null)
        {
            _comando.CommandText = sql;

            if (parameter != null)
                foreach (var p in parameter)
                    _comando.Parameters.AddWithValue(p.Key, p.Value);

            MySqlDataReader leitorDados = _comando.ExecuteReader();

            return leitorDados;
        }

        public long GetUltimoId()
        {
            return _ultimoId;
        }

        public MySqlCommand GetComando()
        {
            return _comando;
        }

        public MySqlConnection GetConexao()
        {
            return _conexao;
        }
    }
}
