using System;
using System.Collections.Generic;
using System.Text;

namespace FLNControl.Dados.Modelo.Interface
{
    public interface ITipoCliente
    {
        public double ObterDescontoAVista(double valor);
        public double ObterDescontoAPrazo(double valor, int parcelas);
    }
}
