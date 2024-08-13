using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clients.Models
{
    public class HomeClients
    {

        public long Id { get; set; }

        [Display(Name = "Text (English)")]
        //[Required(ErrorMessage = "*Please enter text (English)", AllowEmptyStrings = false)]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "* Minimum is 3 and Max is 100 characters")]
        [RegularExpression(@"^[ a-zA-Z0-9-_,.:()<>#@?&$+*®™©'!]*$", ErrorMessage = "Special characters and Numbers are not allowed.")]
        [Required(ErrorMessage = "*Please enter text ", AllowEmptyStrings = false)]
        public string TextEn { get; set; }

        [Display(Name = "Text (Arabic)")]
        //[Required(ErrorMessage = "*Please enter text (Arabic)", AllowEmptyStrings = false)]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "* Minimum is 3 and Max is 100 characters")]
        [RegularExpression(@"^[\u0621-\u064A\u0660-\u0669 a-zA-Z0-9-_,.!':()<>#@?&$+*®™©]*$", ErrorMessage = "Special characters and Numbers are not allowed.")]
        public string TextAr { get; set; }

        [Display(Name = "Value")]
        [Required(ErrorMessage = "*Please enter value", AllowEmptyStrings = false)]
        [StringLength(7, MinimumLength = 1, ErrorMessage = "* Max Length is 7 digits")]
        //[RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Special characters and Alphabets are not allowed.")]
        public string Value { get; set; }
        [Display(Name = "Icon Class")]
        [Required(ErrorMessage = "*Please enter icon class", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "* Minimum is 3 and Max is 100 characters")]
        public string IconClass { get; set; }
        [Required(ErrorMessage =".png only take")]
        public string ImagePath { get; set; }
        public string divImagePath { get; set; }
        public long SortIndex { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public long StatusCode { get; set; }
        public string Result { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public long DeletedBy { get; set; }
        public long FlagId { get; set; }
        public IEnumerable<HomeClients> HomePageCountersList { get; set; }
        public bool Create { get; set; }
        public bool Edit { get; set; }
        [Display(Name = "Banners")]
        [Required(ErrorMessage = "*Please enter Banners", AllowEmptyStrings = false)]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "* Minimum is 3 and Max is 100 characters")]
        [RegularExpression(@"^[\u0621-\u064A\u0660-\u0669 a-zA-Z0-9-_,.!':()<>#@?&$+*®™©]*$", ErrorMessage = "Special characters and Numbers are not allowed.")]
        public string Banners { get; set; }
        public string APIURL { get; set; }
    }

}
