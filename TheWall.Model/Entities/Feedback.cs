using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public virtual ICollection<Reason> Reasons { get; set; }
        public Mood Mood { get; set; }
    }
}
