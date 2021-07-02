using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProcessTurnLogic.Models
{
    public class Turno
    {
        [Key]
        [Column(name: "id_turno")]
        public long IdTurno { get; set; }

        [Column(name:"id_servicio")]
        public long IdServicio { get; set; }

        [Column(name: "fecha_turno")]
        public DateTime FechaTurno { get; set; }

        [Column(name: "hora_inicio")]
        public DateTime HoraInicio { get; set; }

        [Column(name: "hora_fin")]
        public DateTime HoraFin { get; set; }

        [Column(name: "estado")]
        public string Estado { get; set; }


    }
}
