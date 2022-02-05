using System.Collections.Generic;

namespace WebMotors.Service.Services
{
    public interface IService<T, Z>
    {
        #region Consultar
        public IEnumerable<T> Listar();
        #endregion

        #region Cadastrar
        public void Cadastrar(T obj);
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
