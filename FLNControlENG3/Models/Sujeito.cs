using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControlENG3.Models
{
    public interface Sujeito
    {
        void adicionarObservador(Observador o);
        void removerObservador(Observador o);
        void notificar();
    }
}
