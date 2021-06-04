using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControl.Dados.Modelo
{
    public class Segmento
    {
        private int id;
        private string descricao;

        public Segmento()
        {
        }

        public Segmento(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getDescricao()
        {
            return descricao;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
    }
}
