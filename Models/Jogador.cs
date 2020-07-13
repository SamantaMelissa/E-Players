using Aula37_Eplayers.Interfaces;

namespace Aula37_Eplayers.Models
{
    public class Jogador : EplayersBase , IJogador 
    {
        public int IdJogador { get; set; }
        
        public string Nome { get; set; }

        public int IdEquipe { get; set; }
    }
}