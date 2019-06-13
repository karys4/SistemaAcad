using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaAcad.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 50 letras")]

        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage = "Máximo 256 letras")]
        [Display(Name = "Descripción")]

        public string Descripcion { get; set; }

        public string Carrera { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]

        public Boolean Estado { get; set; }

    }
}
