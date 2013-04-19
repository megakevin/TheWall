using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public class Mood
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
        public virtual ICollection<Reason> Reasons { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
