using System.Collections.Generic;
using WebSeries.Interfaces;

namespace WebSeries.Entity
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Inserir(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
