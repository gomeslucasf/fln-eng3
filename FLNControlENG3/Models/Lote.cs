using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControlENG3.Models
{
    class Lote
    {
        private int id;
        private string codExterno;
        private string dataFabricacao;
        private string codigoDeBarras;

        public int getId()
        {
            return this.id;
        }
        public void setId(int input)
        {
            this.id = input;
        }
        public string getCodExterno()
        {
            return this.codExterno;
        }
        public void setCodExterno(string input)
        {
            this.codExterno = input;
        }
        public string getDataFabricacao()
        {
            return this.dataFabricacao;
        }
        public void setDataFabricacao(string input)
        {
            this.dataFabricacao = input;
        }
        public string getCodigoDeBarras()
        {
            return this.codigoDeBarras;
        }
        public void setCodigoDeBarras(string input)
        {
            this.codigoDeBarras = input;
        }



    }
}
