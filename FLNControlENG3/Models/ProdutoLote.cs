using System;

public class ProdutoLote
{
	private int id;
	private string idExterno;
	private DateTime data;
	private int qtdEstoque;

    public ProdutoLote()
    {
    }

    public ProdutoLote(int id, string idExterno, DateTime data, int qtdEstoque)
    {
        this.id = id;
        this.idExterno = idExterno;
        this.data = data;
        this.qtdEstoque = qtdEstoque;
    }

    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public string getIdExterno()
    {
        return idExterno;
    }

    public void setIdExterno(string idExterno)
    {
        this.idExterno = idExterno;
    }

    public DateTime getData()
    {
        return data;
    }

    public void setData(DateTime data)
    {
        this.data = data;
    }

    public int getQtdEstoque()
    {
        return qtdEstoque;
    }

    public void setQtdEstoque(int qtdEstoque)
    {
        this.qtdEstoque = qtdEstoque;
    }
}

