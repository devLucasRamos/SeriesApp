using System.Collections.Generic;

namespace WebSeries.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Lista();
        T RetornaPorId(int Id);
        void Inserir(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();

    }
}
