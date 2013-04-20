using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public enum Availability
    {
        Nationally, Internationally
    }

    /// <summary>
    /// 
    /// </summary>
    public class Course
    {
        public int Id { get; set; }

        [Display(Name="Course Name")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required(ErrorMessage = "Names's required")]
        public string Name { get; set; }
        
        [Display(Name = "Course Description")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required( ErrorMessage = "Description's Required")]
        public string Description { get; set; }

        [Display(Name = "Course availability")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters") ]
        public Availability Availability { get; set; }

        [Display( Name = "Url Address")]
        [StringLength ( 50, ErrorMessage = "Can't be longer than 50 characters")]
        public string Url { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
