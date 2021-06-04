using FLNControl.Dados.Modelo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FLNControl.Dados.Modelo
{
    public class ClienteNormal : ITipoCliente
    {
        public double ObterDescontoAPrazo(double valor, int parcelas)
        {
            // 5% de desconto
            return valor * 0.05;
        }

        public double ObterDescontoAVista(double valor)
        {
            // 10% de desconto
            return valor * 0.1;
        }
    }
}
