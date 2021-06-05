using FLNControl.Dados.Modelo.Interface;
using FLNControl.Dados.Persistencia;
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

        public Produto()
        {

        }

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

        public int Salvar()
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.Save(this);
        }

        public IEnumerable<Produto> BuscarProdutosPorDescricao(string descricao)
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.FindByDescription(descricao);
        }

        public IEnumerable<Produto> BuscarProdutosPorMarca(string marca)
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.FindByBrand(marca);
        }

        public IEnumerable<Produto> BuscarProdutosPorCategoria(string categoria)
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.FindByCategory(categoria);
        }

        public Produto BuscarProdutosPorId(int id)
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.Find(id);
        }

        public IEnumerable<Produto> ListarTodos()
        {
            ProdutoDAO pDao = new ProdutoDAO();

            return pDao.FindAll();
        }

        public bool Deletar()
        {
            ProdutoDAO p = new ProdutoDAO();

            return p.Delete(id) > 0;
        }
    }
}
