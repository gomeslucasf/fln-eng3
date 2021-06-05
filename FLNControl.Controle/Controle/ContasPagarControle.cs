using System;
using System.Collections.Generic;
using System.Text;
using FLNControl.Dados.Modelo;

namespace FLNControl.Fachada.Controle
{
    class ContasPagarControle : ContaTemplateMethod
    {
        private Caixa caixaSessao;
        private static  ContasPagarControle singleton = null;
        private ContasPagar conta;
        private ContasPagarControle(Caixa caixaSessao)
        {
            this.caixaSessao = caixaSessao;
        }

        static ContasPagarControle getInstacia() {
            if(singleton == null)
                singleton = new ContasPagarControle(Caixa.getInstance());
            return singleton;
        }

        public bool QuitarContaPagar(int codigo) {
             conta = new ContasPagar();
            conta.setCodigo(codigo);
            conta.Buscar();
            this.PagarConta(caixaSessao);
            return true;
        }
        public List<ContasPagar> ListaContasReceber(int codigoFornecedor)
        {
            conta = new ContasPagar();
            conta.setCodigoFornecedor(codigoFornecedor);
            return conta.Listar();

        }
        public override void MovimentarCaixa()
        {
            this.caixaSessao.RetirarCaixa(this.conta);
        }
        public override void QuitarConta()
        {
            this.conta.Quitar();
        }
    }
}
