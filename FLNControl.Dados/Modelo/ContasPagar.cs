using FLNControl.Dados.Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace FLNControl.Dados.Modelo
{
    public class ContasPagar
    {
        private int codigo;
        private DateTime datavencimento;
        private DateTime datacadastro;
        private double valorConta;
        private int codigoFornecedor;
        private int quitado;
        public ContasPagar()
        {

        }

        public ContasPagar(int codigo, DateTime datavencimento, DateTime datacadastro, double valorConta, int codigoFornecedor,int quitado)
        {
            this.codigo = codigo;
            this.datavencimento = datavencimento;
            this.datacadastro = datacadastro;
            this.valorConta = valorConta;
            this.codigoFornecedor = codigoFornecedor;
            this.quitado = quitado;
        }


        public int getCodigo() { return this.codigo; }
        public DateTime getDatavencimento() { return this.datavencimento; }
        public DateTime getDatacadastro() { return this.datacadastro; }
        public int getCodigoFornecedor() { return this.codigoFornecedor; }
        public double getValorConta() { return this.valorConta; }
        public int getQuitado() { return this.quitado; }
        public void setQuitado(int quitado) { this.quitado = quitado; }

        public void setCodigo(int codigo) { this.codigo = codigo; }
        public void setDatavencimento(DateTime datavencimento) { this.datavencimento = datavencimento; }
        public void setDatacadastro(DateTime datacadastro) { this.datacadastro = datacadastro; }
        public void setCodigoFornecedor(int CodigoFornecedor) { this.codigoFornecedor = CodigoFornecedor; }
        public void setValorConta(double valorConta) { this.valorConta = valorConta; }

        public bool Criar()
        {
            ContaPagarDAO conta = new ContaPagarDAO();
            int id = conta.save(this);
            this.setCodigo(id);
            return this.codigo > 0;
        }
        public ContasPagar Buscar()
        {
            ContaPagarDAO conta = new ContaPagarDAO();
            return conta.find(this.getCodigo());
        }
        public List<ContasPagar> Listar()
        {
            ContaPagarDAO conta = new ContaPagarDAO();
            return conta.findByNome(this.getCodigoFornecedor());
        }

        public bool Quitar()
        {
            ContaPagarDAO conta = new ContaPagarDAO();
            return conta.save(this)>=0;
        }
    }
}
