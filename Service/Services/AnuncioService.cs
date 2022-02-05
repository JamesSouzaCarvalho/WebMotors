using System.Collections.Generic;
using WebMotors.Data.SqlServer.Context;
using WebMotors.Data.SqlServer.Repositories;
using WebMotors.Domain.Entities;

namespace WebMotors.Service.Services
{
    public class AnuncioService : IAnuncioService
    {
        private readonly AnuncioRepository _anuncioRepository;

        public AnuncioService(IDatabaseContext context)
        {
            _anuncioRepository = new AnuncioRepository(context);
        }

        #region Consultar
        public IEnumerable<Anuncio> Anuncios()
        {
            return _anuncioRepository.Listar();
        }

        public IEnumerable<Anuncio> Listar()
        {
            return _anuncioRepository.Listar();
        }

        #endregion
        #region Cadastrar
        public void Cadastrar(Anuncio obj)
        {
            _anuncioRepository.Cadastrar(obj);
        }
        #endregion

        #region Obter Por Id
        public Anuncio ObterPorId(int id)
        {
            return _anuncioRepository.ObterPorId(id);
        }
        #endregion


        #region Editar
        public void Editar(Anuncio obj)
        {
            _anuncioRepository.Editar(obj);

        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            _anuncioRepository.Excluir(id);
        }
        #endregion

    }
}
