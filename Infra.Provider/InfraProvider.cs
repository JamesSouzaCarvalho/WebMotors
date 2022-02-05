using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebMotors.Domain.Entities;
using WebMotors.Domain.Interfaces.Provider;

namespace WebMotors.Infra.Provider
{
    public class InfraProvider : IProvider
    {
        #region Membros IProvider

        public IEnumerable<Marca> ObterMarcas()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modelo> ObterModelos(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Versao> ObterVersoes(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}