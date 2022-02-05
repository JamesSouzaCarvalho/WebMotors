using System;
using System.Collections.Generic;
using System.Linq;
using WebMotors.Data.SqlServer.Context;
using WebMotors.Domain.Entities;

namespace WebMotors.Data.SqlServer.Repositories
{
    public class AnuncioRepository : IRepository<Anuncio, int>
    {
        private readonly IDatabaseContext _db;

        public AnuncioRepository(IDatabaseContext context)
        {
            _db = context;
        }

        #region Cadastrar
        public void Cadastrar(Anuncio obj)
        {
            try
            {
                var anuncio = _db.Anuncio.FirstOrDefault(q => q.Marca == obj.Marca && q.Modelo == obj.Modelo && q.Ano == obj.Ano && q.Versao == q.Versao);

                if (anuncio != null) throw new Exception("Anuncio já está cadastrada.");

                _db.Anuncio.Add(obj);

                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Consultar
        public IEnumerable<Anuncio> Listar()
        {
            return _db.Anuncio.ToList();
        }
        
        #endregion

        #region Obter Por Id
        public Anuncio ObterPorId(int id)
        {
            var Anuncio = _db.Anuncio.FirstOrDefault(q => q.Id == id);

            if (Anuncio == null) throw new Exception("Anuncio não localizada.");

            return Anuncio;
        }
        #endregion

        #region Editar
        public void Editar(Anuncio obj)
        {
            try
            {
                var anuncio = _db.Anuncio.FirstOrDefault(q => q.Id == obj.Id);

                anuncio.Marca = obj.Marca;
                anuncio.Modelo = obj.Modelo;
                anuncio.Versao = obj.Versao;
                anuncio.Ano = obj.Ano;
                anuncio.Quilometragem = obj.Quilometragem;
                anuncio.Observacao = obj.Observacao;

                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            var Anuncio = _db.Anuncio.FirstOrDefault(q => q.Id == id);

            if (Anuncio == null) return;

            _db.Anuncio.Remove(Anuncio);
            _db.SaveChanges();
        }
        #endregion
    }
}
