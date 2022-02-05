using System;
using System.Collections.Generic;
using WebMotors.Domain.Entities;

namespace WebMotors.Domain.Interfaces.Provider
{
    public interface IProvider
    {
        IEnumerable<Marca> ObterMarcas();
        IEnumerable<Modelo> ObterModelos(int id);
        IEnumerable<Versao> ObterVersoes(int id);
    }
}
