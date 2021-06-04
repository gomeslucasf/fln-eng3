using FLNControl.Dados.Modelo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FLNControl.Dados.Modelo
{
    public class ClienteFidelizado : ITipoCliente
    {
        public double ObterDescontoAPrazo(double valor, int parcelas)
        {
            // 10% de desconto
            return valor * 0.1;
        }

        public double ObterDescontoAVista(double valor)
        {
            // 15% de desconto
            return valor * 0.15;
        }
    }
}
