using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{    
    public partial class State
    {
        public State()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int Id { get; set; }

        [StringLength(100, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }
        public int CountryId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
