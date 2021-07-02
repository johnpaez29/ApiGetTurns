using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessTurnLogic.Models
{
    public class RequestTurn
    {
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public long IdServicio { get; set; }
    }
}
