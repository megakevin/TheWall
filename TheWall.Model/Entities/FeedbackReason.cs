using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model
{
    public class FeedbackReason
    {
        public FeedbackReason()
        {

        }

        public int Id { get; set; }
        public int FeedbackId { get; set; }
        public int ReasonId { get; set; }

        public virtual Feedback Feeedback { get; set; }
        public virtual Reason Reason { get; set; }
    }
}
