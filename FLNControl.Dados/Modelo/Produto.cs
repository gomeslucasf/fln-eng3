using FLNControl.Dados.Modelo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLNControl.Dados.Modelo
{
    public class Produto : ISujeito
    {
        private int id;
        private string nome;
        private Cor cor;
        private Marca marca;
        private Segmento segmento;
        // Lucas vai implementar o restante do codigo do produto

        private List<IObservador> observadores;

        public Produto(int id, string nome, List<IObservador> observadores)
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

        public List<IObservador> getObservadores()
        {
            return this.observadores;
        }

        public void setObservadores(List<IObservador> observadores)
        {
            this.observadores = observadores;
        }

        public Marca getMarca()
        {
            return marca;
        }

        public void setMarca(Marca marca)
        {
            this.marca = marca;
        }

        public Cor getCor()
        {
            return cor;
        }

        public void setCor(Cor cor)
        {
            this.cor = cor;
        }

        public Segmento getSegmento()
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

            notificar();
        }

        public void adicionarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void notificar()
        {
            foreach (IObservador o in observadores)
            {
                o.Atualizar("Atualização de estoque");
                removerObservador(o);
            }
        }

        public void removerObservador(IObservador o)
        {
            observadores.Remove(o);
        }
    }
}
