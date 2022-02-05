using System.Collections.Generic;

namespace WebMotors.Data.SqlServer.Repositories
{
    public interface IRepository<T,Z> where T : class
    {
        #region Cadastrar
        public void Cadastrar(T obj);
        #endregion

        #region Consultar
        public IEnumerable<T> Listar();
        #endregion

        #region Obter Por Id
        public T ObterPorId(Z id);
        #endregion

        #region Editar
        public void Editar(T obj);
        #endregion

        #region Excluir
        public void Excluir(Z id);
        #endregion
    }
}
