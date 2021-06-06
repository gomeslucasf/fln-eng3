using FLNControl.Dados.Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace FLNControl.Dados.Modelo
{
    public class ContasReceber
    {
        private int codigo;
        private DateTime datavencimento;
        private DateTime datacadastro;
        private double valorConta;
        private int codigoCliente;
        private int quitado;
        public  ContasReceber() { 
        
        }

        public ContasReceber(int codigo, DateTime datavencimento, DateTime datacadastro, double valorConta, int codigoCliente, int quitado)
        {
            this.codigo = codigo;
            this.datavencimento = datavencimento;
            this.datacadastro = datacadastro;
            this.valorConta = valorConta;
            this.codigoCliente = codigoCliente;
            this.quitado = quitado;
        }

        public int getCodigo() { return this.codigo; }
        public DateTime getDatavencimento() { return this.datavencimento; }
        public DateTime getDatacadastro() { return this.datacadastro; }
        public int getCodigoCliente() { return this.codigoCliente; }
        public double getValorConta() { return this.valorConta; }
        public int getQuitado() { return this.quitado; }
        public void setQuitado(int quitado) { this.quitado = quitado; }

        public void setCodigo(int codigo) { this.codigo = codigo; }
        public void setDatavencimento(DateTime datavencimento) { this.datavencimento = datavencimento; }
        public void setDatacadastro(DateTime datacadastro) { this.datacadastro = datacadastro;  }
        public void setCodigoCliente(int codigoCliente) { this.codigoCliente = codigoCliente; }
        public void setValorConta(double valorConta) { this.valorConta = valorConta; }


        public bool Criar() {
            ContasReceberDAO conta = new ContasReceberDAO();
            int id = conta.save(this);
            this.setCodigo(id);
            return this.codigo >0 ;
        }
        public ContasReceber Buscar() {
            ContasReceberDAO conta = new ContasReceberDAO();
            return conta.find(this.getCodigo());
        }
        public List<ContasReceber> Listar() {
            ContasReceberDAO conta = new ContasReceberDAO();
            return conta.findByNome(this.getCodigoCliente());
        }

        
        public bool Quitar()
        {
            ContasReceberDAO conta = new ContasReceberDAO();
            return conta.save(this)>=0;
        }
    }
}
