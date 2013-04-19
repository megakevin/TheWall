using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public class Reason
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
        public Mood Mood { get; set; }
    }
}
