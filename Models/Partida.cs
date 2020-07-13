using System;
using Aula37_Eplayers.Interfaces;

namespace Aula37_Eplayers.Models
{
    public class Partida : EplayersBase , IPartida
    {
        public int IdPartida { get; set; }

        public int IdEquipe1 { get; set; }

        public int IdEquipe2 { get; set; }

        public DateTime Horario { get; set; }
    }
}