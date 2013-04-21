using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{    
    public partial class Availability
    {
        public Availability()
        {
            this.Courses = new HashSet<Course>();
        }
    
        public int Id { get; set; }
        
        [StringLength(20, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Description { get; set; }
    
        public virtual ICollection<Course> Courses { get; set; }
    }
}
