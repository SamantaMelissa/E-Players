
using System.Collections.Generic;
using Aula37_Eplayers.Models;
namespace Aula37_Eplayers.Interfaces
{
    public interface INoticias
    {
        void Create(Noticias n);

         List<Noticias> ReadAll();

         void Update (Noticias n);

         void Delete(int IdNoticias);
    }
}