using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControl.Dados.Modelo
{
    public class Cor
    {
        private int id;
        private string nome;

        public Cor()
        {
        }

        public Cor(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
    }
}
