using MovEngine.Hotel.Dominio.Interfaces.Broker;
using System;
using WebMotors.Domain.Interfaces.Provider;

namespace WebMotors.Domain.Factories
{
    public class ProviderFactory
    {
        #region Campos | Membros
        private static IProviderFactory _factoryAtual;
        #endregion

        #region Metodos Publicos
        public static void DefinirAtual(IProviderFactory factory)
        {
            _factoryAtual = factory;
        }

        public static IProvider Criar(string fornecedor)
        {
            if (_factoryAtual == null)
            {
                throw new Exception("_factoryAtual");
            }

            return _factoryAtual.Criar(fornecedor);
        }
        #endregion
    }
}
