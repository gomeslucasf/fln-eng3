using FLNControl.Dados.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace FLNControl.Dados.Persistencia
{
    public class ProdutoDAO
    {
        public Produto Find(int id)
        {
            Produto produto = null;
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            string sql = @"SELECT * FROM produto WHERE pro_codigo = @pProdId LIMIT 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pProdId", id);

            DbDataReader result = database.ExecutarSelect(sql, parameters);
            if (result.HasRows)
            {
                produto = new Produto();
                result.Read();

                produto.setId = Convert.ToInt32(result["pro_codigo"]);
                produto.Descricao = result["pro_descricao"].ToString();
                produto.Categoria = result["pro_categoria"].ToString();
                produto.Marca = result["pro_marca"].ToString();
                produto.ValorVenda = Convert.ToDecimal(result["pro_valor_venda"]);
                produto.ValorCompra = Convert.ToDecimal(result["pro_valor_compra"]);
            }

            database.Fechar();

            return produto;
        }

        public List<Produto> FindByDescription(string desc)
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            string sql = @"SELECT * FROM produto WHERE LOWER(pro_descricao) LIKE @pProdDesc";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pProdDesc", "%" + desc.ToLower() + "%");

            DbDataReader result = database.ExecutarSelect(sql, parameters);
            List<Produto> listaProduto = new List<Produto>();
            if (result.HasRows)
            {
                Produto produto;
                while (result.Read())
                {
                    produto = new Produto();
                    produto.Id = Convert.ToInt32(result["pro_codigo"]);
                    produto.Descricao = result["pro_descricao"].ToString();
                    produto.Categoria = result["pro_categoria"].ToString();
                    produto.Marca = result["pro_marca"].ToString();
                    produto.ValorVenda = Convert.ToDecimal(result["pro_valor_venda"]);
                    produto.ValorCompra = Convert.ToDecimal(result["pro_valor_compra"]);
                    listaProduto.Add(produto);
                }
            }

            database.Fechar();

            return listaProduto;
        }

        public List<Produto> FindByCategory(string categ)
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            string sql = @"SELECT * FROM produto WHERE LOWER(pro_categoria) LIKE @pProdCateg";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pProdCateg", "%" + categ.ToLower() + "%");

            DbDataReader result = database.ExecutarSelect(sql, parameters);
            List<Produto> listaProduto = new List<Produto>();
            if (result.HasRows)
            {
                Produto produto;
                while (result.Read())
                {
                    produto = new Produto();
                    produto.Id = Convert.ToInt32(result["pro_codigo"]);
                    produto.Descricao = result["pro_descricao"].ToString();
                    produto.Categoria = result["pro_categoria"].ToString();
                    produto.Marca = result["pro_marca"].ToString();
                    produto.ValorVenda = Convert.ToDecimal(result["pro_valor_venda"]);
                    produto.ValorCompra = Convert.ToDecimal(result["pro_valor_compra"]);
                    listaProduto.Add(produto);
                }
            }

            database.Fechar();

            return listaProduto;
        }

        public List<Produto> FindAll()
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            string sql = @"SELECT * FROM produto";

            DbDataReader result = database.ExecutarSelect(sql);
            List<Produto> listaProduto = new List<Produto>();
            if (result.HasRows)
            {
                Produto produto;
                while (result.Read())
                {
                    produto = new Produto();
                    produto.Id = Convert.ToInt32(result["pro_codigo"]);
                    produto.Descricao = result["pro_descricao"].ToString();
                    produto.Categoria = result["pro_categoria"].ToString();
                    produto.Marca = result["pro_marca"].ToString();
                    produto.ValorVenda = Convert.ToDecimal(result["pro_valor_venda"]);
                    produto.ValorCompra = Convert.ToDecimal(result["pro_valor_compra"]);
                    listaProduto.Add(produto);
                }
            }

            database.Fechar();

            return listaProduto;
        }

        public List<Produto> FindByBrand(string brand)
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            string sql = @"SELECT * FROM produto WHERE LOWER(pro_marca) LIKE @pProdBrand";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pProdBrand", "%" + brand.ToLower() + "%");

            DbDataReader result = database.ExecutarSelect(sql, parameters);
            List<Produto> listaProduto = new List<Produto>();
            if (result.HasRows)
            {
                Produto produto;
                while (result.Read())
                {
                    produto = new Produto();
                    produto.Id = Convert.ToInt32(result["pro_codigo"]);
                    produto.Descricao = result["pro_descricao"].ToString();
                    produto.Categoria = result["pro_categoria"].ToString();
                    produto.Marca = result["pro_marca"].ToString();
                    produto.ValorVenda = Convert.ToDecimal(result["pro_valor_venda"]);
                    produto.ValorCompra = Convert.ToDecimal(result["pro_valor_compra"]);
                    listaProduto.Add(produto);
                }
            }

            database.Fechar();

            return listaProduto;
        }

        public int Save(Produto produto)
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql;
            if (produto.Id == 0)
            {
                sql = @"INSERT INTO 
                    produto(pro_descricao, pro_categoria, pro_marca, 
                        pro_valor_compra, pro_valor_venda)
                    VALUES(@pProdDescricao, @pProdCategoria, @pProdMarca,
                        @pProdValorCompra, @pProdValorVenda
                    )";
            }
            else
            {
                sql = @"UPDATE 
                    produto SET pro_descricao = @pProdDescricao, 
                        pro_categoria = @pProdCategoria, 
                        pro_marca = @pProdMarca, 
                        pro_valor_compra = @pProdValorCompra,
                        pro_valor_venda = @pProdValorVenda
                    WHERE pro_codigo = @pProdId";
                parameters.Add("@pProdId", produto.Id);
            }

            parameters.Add("@pProdDescricao", produto.Descricao);
            parameters.Add("@pProdCategoria", produto.Categoria);
            parameters.Add("@pProdMarca", produto.Marca);
            parameters.Add("@pProdValorCompra", produto.ValorCompra);
            parameters.Add("@pProdValorVenda", produto.ValorVenda);
            database.ExecutarNonQuery(sql, parameters);

            return (int)database.GetUltimoId();
        }

        public int Delete(int id)
        {
            MySqlPersistence database = MySqlPersistence.GetInstancia();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string sql = @"DELETE FROM produto WHERE pro_codigo = @pProdId";
            parameters.Add("@pProdId", id);

            return database.ExecutarNonQuery(sql, parameters);
        }
    }
}
