using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors.Domain.Entities
{
    public class Anuncio 
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(45)")]
        [StringLength(45)]
        public string Marca { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(45)")]
        [StringLength(45)]
        public string Modelo { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(45)")]
        [StringLength(45)]
        public string Versao { get; set; }

        [Required]
        [Column(TypeName = "INT")]
        public int Ano { get; set; }

        [Required]
        [Column(TypeName = "INT")]
        public int Quilometragem { get; set; }

        [Required]
        [Column(TypeName = "TEXT")]
        public string Observacao { get; set; }
    }
}
