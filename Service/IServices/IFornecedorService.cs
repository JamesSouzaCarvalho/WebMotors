using WebMotors.Domain.Entities;
using System.Collections.Generic;

namespace WebMotors.Service.Services
{
    public interface IFornecedorService
    {
        IEnumerable<Marca> ObterMarcas();

        IEnumerable<Modelo> ObterModelos(int id);

        IEnumerable<Versao> ObterVersoes(int id);
    }
}
