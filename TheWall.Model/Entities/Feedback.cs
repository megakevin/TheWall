using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{
    public partial class Feedback
    {
        public Feedback()
        {
            this.FeedbackReasons = new HashSet<FeedbackReason>();
        }

        public int Id { get; set; }

        [Display(Name = "Comment")]
        public string Text { get; set; }

        [Display(Name = "Course")]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public int CourseId { get; set; }

        [Display(Name = "Student")]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public int StudentId { get; set; }

        [Display(Name = "Mood")]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public int MoodId { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Mood Mood { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<FeedbackReason> FeedbackReasons { get; set; }
    }
}
