using System.Collections.Generic;
using Aula37_Eplayers.Models;
namespace Aula37_Eplayers.Interfaces
{
    public interface IEquipe
    {
         void Create(Equipe e);

         List<Equipe> ReadAll();

         void Update (Equipe e);

         void Delete(int IdEquipe);
    }
}