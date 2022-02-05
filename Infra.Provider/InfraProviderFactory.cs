using MovEngine.Hotel.Dominio.Interfaces.Broker;
using WebMotors.Domain.Interfaces.Provider;
using WebMotors.Infra.Provider.DesafioOnLine;

namespace WebMotors.Infra.Provider
{
    public class InfraProviderFactory : IProviderFactory
    {
        #region Membros IProviderFactory
        public virtual IProvider Criar(string fornecedor)
        {
            if (fornecedor != null)
            {
                switch (fornecedor.ToUpper())
                {
                    case "DESAFIOONLINE":
                        return new DesafioOnLineProvider();
                }
            }

            return new InfraProvider();
        }
        #endregion
    }
}
