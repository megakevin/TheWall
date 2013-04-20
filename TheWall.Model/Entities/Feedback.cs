using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        [Display(Name = "Comment")]
        public string Text { get; set; }

        [Required]
        public Course Course { get; set; }
        
        [Required]
        public Student Student { get; set; }

        public virtual ICollection<Reason> Reasons { get; set; }

        [Required]
        public Mood Mood { get; set; }
    }
}
