using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CZ.MVC.ViewModels
{
    public class ClientVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="First name is Required.")]
        [MaxLength(150,ErrorMessage ="Maximum {0} character length should be less")]
        [MinLength(2,ErrorMessage =" Minimum {0} characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "First name is Required.")]
        [MaxLength(150, ErrorMessage = "Maximum {0} character length should be less")]
        [MinLength(2, ErrorMessage = " Minimum {0} characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First name is Required.")]
        [MaxLength(150, ErrorMessage = "Maximum {0} character length should be less")]
        [EmailAddress(ErrorMessage ="Valid Email has to be entered.")]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DOB { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual IEnumerable<ProductVM> Products { get; set; }

    }
}