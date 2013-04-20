using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public class Reason
    {
        public int Id { get; set; }

        [Display(Name = "Reason Description")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required]
        public string Description { get; set; }
        
        [Required]
        public Mood Mood { get; set; }
    }
}
