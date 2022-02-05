using System.Collections.Generic;
using WebMotors.Data.SqlServer.Context;
using WebMotors.Data.SqlServer.Repositories;
using WebMotors.Domain.Entities;
using WebMotors.Domain.Factories;

namespace WebMotors.Service.Services
{
    public class FornecedorService : IFornecedorService
    {
        public IEnumerable<Marca> ObterMarcas()
        {
            var provider = "DesafioOnLine"; // _anuncioRepository.ObterFornecedoresDisponiveis();
            var providerFactory = ProviderFactory.Criar(provider);

            var marcas = providerFactory.ObterMarcas();

            return marcas;
        }

        public IEnumerable<Modelo> ObterModelos(int id)
        {
            var provider = "DesafioOnLine"; // _anuncioRepository.ObterFornecedoresDisponiveis();
            var providerFactory = ProviderFactory.Criar(provider);

            var modelos = providerFactory.ObterModelos(id);

            return modelos;
        }

        public IEnumerable<Versao> ObterVersoes(int id)
        {
            var provider = "DesafioOnLine"; // _anuncioRepository.ObterFornecedoresDisponiveis();
            var providerFactory = ProviderFactory.Criar(provider);

            var versoes = providerFactory.ObterVersoes(id);

            return versoes;

        }


    }
}
