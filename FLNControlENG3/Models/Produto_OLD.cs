namespace FLNControl.Models
{
    public class Produto_OLD
    {
        private int id;
        private string gtin;
        private decimal precoCompra;
        private int estoqueMinimo;
        private UnidadeMedida unidadeMedida;
        private ProdutoLote[] produtoLote;

        public Produto_OLD()
        {
        }

        public Produto_OLD(int id, string gtin, decimal precoCompra, int estoqueMinimo, UnidadeMedida unidadeMedida, ProdutoLote[] produtoLote)
        {
            this.id = id;
            this.gtin = gtin;
            this.precoCompra = precoCompra;
            this.estoqueMinimo = estoqueMinimo;
            this.unidadeMedida = unidadeMedida;
            this.produtoLote = produtoLote;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getGtin()
        {
            return gtin;
        }

        public void setGtin(string gtin)
        {
            this.gtin = gtin;
        }

        public decimal getPrecoCompra()
        {
            return precoCompra;
        }

        public void setPrecoCompra(decimal precoCompra)
        {
            this.precoCompra = precoCompra;
        }

        public int getEstoqueMinimo()
        {
            return estoqueMinimo;
        }

        public void setEstoqueMinimo(int estoqueMinimo)
        {
            this.estoqueMinimo = estoqueMinimo;
        }

        public UnidadeMedida getUnidadeMedida()
        {
            return unidadeMedida;
        }

        public void setUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            this.unidadeMedida = unidadeMedida;
        }

        public ProdutoLote[] getProdutoLote()
        {
            return produtoLote;
        }

        public void setProdutoLote(ProdutoLote[] produtoLote)
        {
            this.produtoLote = produtoLote;
        }
    }
}