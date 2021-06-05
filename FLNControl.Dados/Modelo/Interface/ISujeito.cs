namespace FLNControl.Dados.Modelo.Interface
{
    public interface ISujeito
    {
        void adicionarObservador(IObservador o);
        void removerObservador(IObservador o);
        void notificar();
    }
}
