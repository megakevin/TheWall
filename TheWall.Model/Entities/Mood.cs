using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{    
    public partial class Mood
    {
        public Mood()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.Reasons = new HashSet<Reason>();
        }
    
        public int Id { get; set; }

        [StringLength(50, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Description { get; set; }
    
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Reason> Reasons { get; set; }
    }
}
