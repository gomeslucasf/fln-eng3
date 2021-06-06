using System;
using System.Collections.Generic;
using System.Text;
using FLNControl.Dados.Modelo;

namespace FLNControl.Fachada.Controle
{
    abstract class ContaTemplateMethod
    {
        protected bool PagarConta(Caixa cx) {
            if (!cx.getFechado())
            {
                this.MovimentarCaixa();
                this.QuitarConta();
            }
            else {
                return true;
            }

            return true;
        }

        abstract public void MovimentarCaixa();
        abstract public void QuitarConta();
    }
}
