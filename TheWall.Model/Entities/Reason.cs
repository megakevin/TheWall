using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{    
    public partial class Reason
    {
        public Reason()
        {
            this.FeedbackReasons = new HashSet<FeedbackReason>();
        }

        public int Id { get; set; }

        [StringLength(150, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Description { get; set; }
        
        public int MoodId { get; set; }
        
        public virtual Mood Mood { get; set; }
        public virtual ICollection<FeedbackReason> FeedbackReasons { get; set; }
    }
}
