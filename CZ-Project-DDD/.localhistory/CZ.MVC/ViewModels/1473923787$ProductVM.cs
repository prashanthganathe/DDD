using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CZ.MVC.ViewModels
{
    public class ProductVM
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is Required.")]
        [MaxLength(200, ErrorMessage = "Maximum {0} character length should be less")]
        [MinLength(2, ErrorMessage = " Minimum {0} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "First name is Required.")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","99999999")]        
        public decimal Value { get; set; }
        public bool Dispose { get; set; }
        public int ClientId { get; set; }

        public virtual Clie
    }
}