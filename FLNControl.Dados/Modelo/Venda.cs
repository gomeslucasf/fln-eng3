using System;
using System.Collections.Generic;
using System.Text;

namespace FLNControl.Dados.Modelo
{
    public class Venda
    {
        private int _id;
        private DateTime _dataVenda;
        private string _formaPagamento;
        private string _nomeCliente;
        private string _cpfCliente;
        private string _enderecoCliente;
        private string _numeroEndCliente;
        private string _bairroCliente;
        private string _cidadeCliente;
        private string _ufCliente;
        private List<Produto> _itensVenda;

        public Venda()
        {
            _itensVenda = new List<Produto>();
        }

        public Venda(int id, DateTime dataVenda, string formaPagamento,
            string nomeCliente, string cpfCliente, string enderecoCliente,
            string numeroEndCliente, string bairroCliente, string cidadeCliente,
            string ufCliente, List<Produto> itensVenda)
        {
            _id = id;
            _dataVenda = dataVenda;
            _formaPagamento = formaPagamento;
            _nomeCliente = nomeCliente;
            _cpfCliente = cpfCliente;
            _enderecoCliente = enderecoCliente;
            _numeroEndCliente = numeroEndCliente;
            _bairroCliente = bairroCliente;
            _cidadeCliente = cidadeCliente;
            _ufCliente = ufCliente;
            _itensVenda = itensVenda;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetDataVenda(DateTime DataVenda)
        {
            _dataVenda = DataVenda;
        }

        public DateTime SetDataVenda()
        {
            return _dataVenda;
        }

        public void SetFormaPagamento(string formaPagamento)
        {
            _formaPagamento = formaPagamento;
        }

        public string GetFormaPagamento()
        {
            return _formaPagamento;
        }

        public void SetNomeCliente(string nomeCliente)
        {
            _nomeCliente = nomeCliente;
        }

        public string GetNomeCliente()
        {
            return _nomeCliente;
        }
        public void SetCpfCliente(string cpfCliente)
        {
            _cpfCliente = cpfCliente;
        }

        public string GetCpfCliente()
        {
            return _cpfCliente;
        }
        public void SetEnderecoCliente(string enderecoCliente)
        {
            _enderecoCliente = enderecoCliente;
        }

        public string GetEnderecoCliente()
        {
            return _enderecoCliente;
        }
        public void SetNumeroEndCliente(string numeroEndCliente)
        {
            _numeroEndCliente = numeroEndCliente;
        }

        public string GetNumeroEndCliente()
        {
            return _numeroEndCliente;
        }
        public void SetBairroCliente(string bairroCliente)
        {
            _bairroCliente = bairroCliente;
        }

        public string GetBairroCliente()
        {
            return _bairroCliente;
        }
        public void SetCidadeCliente(string cidadeCliente)
        {
            _cidadeCliente = cidadeCliente;
        }

        public string GetCidadeCliente()
        {
            return _cidadeCliente;
        }
        public void SetUfCliente(string ufCliente)
        {
            _ufCliente = ufCliente;
        }

        public string GetUfCliente()
        {
            return _ufCliente;
        }
        public void SetItensVenda(List<Produto> itensVenda)
        {
            _itensVenda = itensVenda;
        }

        public List<Produto> GetItensVenda()
        {
            return _itensVenda;
        }

        public void AdicionarItemVenda(Produto p)
        {
            _itensVenda.Add(p);
        }

        public List<Venda> VendasPorCliente(string cpf)
        {
            VendasDAO vDAO = new VendasDAO();

            return VendasDAO.ListVendasByCPF();
        }
    }
}
