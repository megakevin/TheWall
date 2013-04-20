using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TheWall.Model.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "State Name")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required]
        public string Name { get; set; }

        [Required]
        public Country Country { get; set; }
    }
}
