using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Availability Availability { get; set; }
        public string Url { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
