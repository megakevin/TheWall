using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{    
    public partial class Gender
    {
        public Gender()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int Id { get; set; }
        
        [StringLength(10, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
    }
}
