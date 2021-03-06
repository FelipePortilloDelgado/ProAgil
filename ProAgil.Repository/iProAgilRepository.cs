using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface iProAgilRepository
    {
        //GERAL
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveChangeAsync();
         
         //EVENTOS
         Task<Evento[]> GetAllEventoAsyncByTema(string Tema, bool includePalestrantes);
         Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);
         Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes);

         //PALESTRANTES
         Task<Palestrante[]> GetAllPalestranteAsyncByName(string name, bool includeEventos);
         Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEventos);
    }
}