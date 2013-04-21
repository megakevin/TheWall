using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{    
    public partial class Country
    {
        public Country()
        {
            this.States = new HashSet<State>();
        }
    
        public int Id { get; set; }

        [StringLength(50, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }
    
        public virtual ICollection<State> States { get; set; }
    }
}
