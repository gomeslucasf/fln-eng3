public class UnidadeMedida
{
	private int id;
	private string tipo;
    private float metragem;

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

    public float getMetragem()
    {
        return this.metragem;
    }

    public void setMetragem(float metragem)
    {
        this.metragem = metragem;
    }

    public bool gravarUnidadeMedida() {
        UnidadeMedidaDAL dal = new UnidadeMedidaDAL();
        return dal.gravarUnidadeMedida();
    }
    public List<UnidadeMedida> retornaTodas()
    {
        UnidadeMedidaDAL dal = new UnidadeMedidaDAL();
        return dal.retornaTodas();
    }
    public UnidadeMedida pesquisaPorCodigo(int id) {
        UnidadeMedidaDAL dal = new UnidadeMedidaDAL();
        return dal.pesquisarPorCodigo(id);
    }

}

