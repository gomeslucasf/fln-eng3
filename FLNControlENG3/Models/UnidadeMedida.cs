public class UnidadeMedida
{
	private int id;
	private string descricao;

    public UnidadeMedida()
    {
    }

    public UnidadeMedida(int id, string descricao)
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

