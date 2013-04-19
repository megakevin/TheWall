using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TheWall.Model.Entities
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
