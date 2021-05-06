using FLNControl.Dados.Modelo.Interface;
using System;

namespace FLNControl.Dados.Modelo
{
    public class Cliente : IObservador
    {
        private int _id;
        private string _nome;
        private string _endereco;
        private string _cpf;
        private string _telefone;
        private DateTime _dataNascimento;

        public Cliente(int id, string nome, string endereco, string cpf, string telefone, DateTime dataNascimento)
        {
            _id = id;
            _nome = nome;
            _endereco = endereco;
            _cpf = cpf;
            _telefone = telefone;
            _dataNascimento = dataNascimento;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetEndereco()
        {
            return _endereco;
        }

        public void SetEndereco(string endereco)
        {
            _endereco = endereco;
        }

        public string GetCPF()
        {
            return _cpf;
        }

        public void GetCPF(string CPF)
        {
            _cpf = CPF;
        }

        public string GetTelefone()
        {
            return _telefone;
        }

        public void SetTelefone(string telefone)
        {
            _telefone = telefone;
        }

        public DateTime GetDataNascimento()
        {
            return _dataNascimento;
        }

        public void SetDataNascimento(DateTime dataNascimento)
        {
            _dataNascimento = dataNascimento;
        }

        public void Atualizar()
        {
            // Código de notificação para o cliente
        }
    }
}
