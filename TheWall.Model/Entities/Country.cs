using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TheWall.Model.Entities
{
    /// <summary>
    /// Los paises
    /// </summary>
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El nombre del paise no puede ser mayor de 50 caracteres" )]
        [Required(ErrorMessage = "Name's Required")]
        public string Name { get; set; }
    }
}
