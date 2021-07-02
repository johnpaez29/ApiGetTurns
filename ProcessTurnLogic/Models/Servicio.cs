using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProcessTurnLogic.Models
{
    public class Servicio
    {
        [Key]
        [Column(name: "id_servicio")]
        public long id_servicio { get; set; }

        [Column(name: "id_comercio")]
        public long id_comercio { get; set; }

        [Column(name: "nom_servicio")]
        public string nom_servicio { get; set; }

        [Column(name: "hora_apertura")]
        public TimeSpan hora_apertura { get; set; }

        [Column(name: "hora_cierre")]
        public TimeSpan hora_cierre { get; set; }

        [Column(name: "duracion")]
        public int duracion { get; set; }

    }

}
