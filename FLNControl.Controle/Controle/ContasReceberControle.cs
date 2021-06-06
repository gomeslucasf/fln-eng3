using System;
using System.Collections.Generic;
using System.Text;
using FLNControl.Dados.Modelo;

namespace FLNControl.Fachada.Controle
{
    class ContasReceberControle: ContaTemplateMethod
    {
        private Caixa caixaSessao;
        private static ContasReceberControle singleton = null;
        private ContasReceber conta;
        private ContasReceberControle(Caixa caixaSessao)
        {
            this.caixaSessao = caixaSessao;
        }

        static ContasReceberControle getInstacia()
        {
            if (singleton == null)
                singleton = new ContasReceberControle(Caixa.getInstance());
            return singleton;
        }

        public bool QuitarContaReceber(int codigo) {
            conta = new ContasReceber();
            conta.setCodigo(codigo);

            this.PagarConta(caixaSessao);

            return true;
        }

        public List<ContasReceber> ListaContasReceber(int codigoCliente) {
            conta = new ContasReceber();
            conta.setCodigoCliente(codigoCliente);
            return conta.Listar();
            
        }
        public override void MovimentarCaixa()
        {
            this.caixaSessao.ReceberCaixa(conta);
        }

        public override void QuitarConta()
        {
            this.conta.Quitar();
        }
    }
}
