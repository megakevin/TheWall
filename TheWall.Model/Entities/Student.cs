using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Model
{    
    public partial class Student
    {
        public Student()
        {
            this.Feedbacks = new HashSet<Feedback>();
        }
    
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string FirstName { get; set; }

        [Display(Name = "Lasr Name")]
        [StringLength(50, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string UserName { get; set; }

        [StringLength(50, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Password { get; set; }
        //public string Password
        //{
        //    get 
        //    {
        //        return Password;
        //    }
        //    set
        //    {               
        //        value = System.Web.Helpers.Crypto.HashPassword(value);
        //    }
        //}

        public int GenderId { get; set; }
                
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public DateTime BirthDate { get; set; }

        [StringLength(100, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string City { get; set; }

        [StringLength(10, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "RequiredErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string PostalCode { get; set; }

        public int StateId { get; set; }
    
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual State State { get; set; }

        //public bool VerifyPassword(string PlainTextPassword)
        //{
        //    return System.Web.Helpers.Crypto.VerifyHashedPassword(this.Password, PlainTextPassword);
        //}
    }
}
