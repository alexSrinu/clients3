using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clients.Models
{
    public class Class
    {
        public long Id { get; set; }

        [Display(Name = "Text (English)")]
        //[Required(ErrorMessage = "*Please enter text (English)", AllowEmptyStrings = false)]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "* Minimum is 3 and Max is 100 characters")]
        [RegularExpression(@"^[ a-zA-Z0-9-_,.:()<>#@?&$+*®™©'!]*$", ErrorMessage = "Special characters and Numbers are not allowed.")]
        [Required(ErrorMessage = "*Please enter text ", AllowEmptyStrings = false)]
        public string TextEn { get; set; }
        [Display(Name = "Value")]
        [Required(ErrorMessage = "*Please enter value", AllowEmptyStrings = false)]
        [StringLength(7, MinimumLength = 1, ErrorMessage = "* Max Length is 7 digits")]
        //[RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Special characters and Alphabets are not allowed.")]
        public string Value { get; set; }
       
        public string ImagePath { get; set; }
        public long FlagId { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public string divImagePath { get; set; }
    }
}