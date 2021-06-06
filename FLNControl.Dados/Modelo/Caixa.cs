using System;
using System.Collections.Generic;
using System.Text;

namespace FLNControl.Dados.Modelo
{
    public class Caixa
    {
        private int codigo;
        private DateTime dataCadastro;
        private bool fechado;
        private List<ContasPagar> retiradas;
        private List<ContasReceber> recebidos;
        private static Caixa instance = null;

        private  Caixa(int codigo, DateTime dataCadastro, bool fechado, List<ContasPagar> retiradas, List<ContasReceber> recebidos)
        {
            this.codigo = codigo;
            this.dataCadastro = dataCadastro;
            this.fechado = fechado;
            this.retiradas = retiradas;
            this.recebidos = recebidos;
        }

        public static Caixa getInstance() {
            if (instance == null)
                instance = new Caixa(1, DateTime.Today, false, new List<ContasPagar>(), new List<ContasReceber>());
            return instance;
        }
        
        public int getCodigo() { return this.codigo; }
        public DateTime getDataCadastro() { return this.dataCadastro; }
        public bool getFechado() { return this.fechado; }

        public List<ContasPagar> getRetiradas() { return this.retiradas; }

        public List<ContasReceber> getRecebidos() { return this.recebidos; }

        public void setCodigo(int codigo) { this.codigo = codigo; }
        public void setDataCadastro(DateTime dataCadastro) { this.dataCadastro = dataCadastro; }
        public void setFechado(bool fechado) { this.fechado = fechado; }
        public void setRetiradas(List<ContasPagar> retiradas) { this.retiradas = retiradas; }

        public void setRecebidos(List<ContasReceber> recebidos) { this.recebidos = recebidos; }

        public bool CaixaFechado() { return this.fechado; }
        public bool RetirarCaixa(ContasPagar cp) {
            this.retiradas.Add(cp);
            return cp.getCodigo() > 0; 
        }

        public bool ReceberCaixa(ContasReceber cr) {
            this.recebidos.Add(cr);
            return cr.getCodigo() > 0; 
        }

    }
}
