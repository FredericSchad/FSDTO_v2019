using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDTO_v2019
{
    public class DTOReformHQ
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Aplicacion { get; set; }
        [Required]
        [StringLength(70)]
        public string NombreArchivo { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(20)]
        public string Usuario { get; set; }
        [Required]
        [StringLength(60)]
        public string NombreDocumento { get; set; }
        public decimal Tasa { get; set; }
        public int NumeroPaginas { get; set; }

    }
}
