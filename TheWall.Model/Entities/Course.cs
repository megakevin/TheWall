using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{   
    public partial class Course
    {
        public Course()
        {
            this.Feedbacks = new HashSet<Feedback>();
        }
    
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        [StringLength(50, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }

        [Display(Name = "Course Description")]        
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Description { get; set; }

        [Display(Name = "Course availability")]
        public int AvailabilityId { get; set; }

        [Display(Name = "Url Address")]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Url { get; set; }
    
        public virtual Availability Availability { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
