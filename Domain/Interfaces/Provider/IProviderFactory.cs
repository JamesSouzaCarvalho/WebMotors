using WebMotors.Domain.Interfaces.Provider;

namespace MovEngine.Hotel.Dominio.Interfaces.Broker
{
    public interface IProviderFactory
    {
        IProvider Criar(string fornecedor);
    }
}
