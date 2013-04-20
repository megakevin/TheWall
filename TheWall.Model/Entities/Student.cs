using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public enum Gender
    {
        Female, Male
    }

    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [StringLength( 50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Username")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]  
        [Required]
        public string Password
        {
            private get
            {
                return Password;
            }
            
            set
            {
                value = System.Web.Helpers.Crypto.HashPassword(value);
            }
        }

        [Display(Name = "Gender")]
        [Required]
        public Gender Gender { get; set; }

        [Display(Name = "Birth Date")]
        [Required]
        public DateTime BirthDate { get; set; }

        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required]
        public State State { get; set; }

        [Display(Name = "City")]
        [StringLength(50, ErrorMessage = "Can't be longer than 50 characters")]
        [Required]
        public string City { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(10, ErrorMessage = "Can't be longer than 50 characters")]
        [Required]
        public string PostalCode { get; set; }

        public virtual ICollection<Feedback> Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_password">pasword to validate</param>
        /// <returns>if equal True else False</returns>
        public bool VerifyPassword(string _password)
        {
            return System.Web.Helpers.Crypto.VerifyHashedPassword(this.Password, _password);
        }
    }
}
