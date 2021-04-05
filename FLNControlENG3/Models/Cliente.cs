using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControlENG3.Models
{
    public class Cliente : Observador
    {
        private int id;
        private string nome;
        private string endereco;
        private string cpf;
        private string telefone;
        private DateTime dataNascimento;

        public Cliente(int id, string nome, string endereco, string cpf, string telefone, DateTime dataNascimento)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getEndereco()
        {
            return endereco;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string getCPF()
        {
            return cpf;
        }

        public void setCPF(string CPF)
        {
            this.cpf = CPF;
        }

        public string getTelefone()
        {
            return telefone;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public DateTime getDataNascimento()
        {
            return dataNascimento;
        }

        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public void atualizar(string acao)
        {
            Console.WriteLine("Cliente "+ this.nome +" notificado!\n"+ acao);

            // Código de notificação para o cliente
        }
    }
}
