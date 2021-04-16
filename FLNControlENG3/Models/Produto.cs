/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControlENG3.Models
{
    public class Produto : Sujeito
    {
        private int id;
        private string nome;
        private Cor cor;
        private Marca marca;
        private Segmento segmento;
        // Lucas vai implementar o restante do codigo do produto

        private List<Observador> observadores;

        public Produto(int id, string nome, List<Observador> observadores)
        {
            this.id = id;
            this.nome = nome;
            this.observadores = observadores;
        }

        public Produto(int id, string nome)
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
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public List<Observador> getObservadores()
        {
            return this.observadores;
        }

        public void setObservadores(List<Observador> observadores)
        {
            this.observadores = observadores;
        }

        public int getMarca()
        {
            return marca;
        }

        public void setMarca(Marca marca)
        {
            this.marca = marca;
        }

        public int getCor()
        {
            return cor;
        }

        public void setCor(Cor cor)
        {
            this.cor = cor;
        }

        public int getSegmento()
        {
            return segmento;
        }

        public void setSegmento(Segmento segmento)
        {
            this.segmento = segmento;
        }

        public void inserirEstoque(int qtd)
        {
            // Logica de estoque/lote (LUCAS)

            notificar("Atualização de estoque: "+ qtd +" novas unidades do produto "+ this.nome);
        }

        public void adicionarObservador(Observador o)
        {
            observadores.Add(o);
        }

        public void notificar(string acao)
        {
            foreach (Observador o in observadores)
            {
                o.atualizar(acao);
                removerObservador(o);
            }
        }

        public void removerObservador(Observador o)
        {
            observadores.Remove(o);
        }
    }
}
*/