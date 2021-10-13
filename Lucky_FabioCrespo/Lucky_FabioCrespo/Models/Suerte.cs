using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_FabioCrespo.Models
{
    public class Suerte
    {
        [Key]
        public int SuerteId { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "La suerte debe contener entre 5 a 100 caracteres")]
        public string Detalle { get; set; }
        [Url]
        [Required]
        public string Imagen { get; set; }

    }
}
