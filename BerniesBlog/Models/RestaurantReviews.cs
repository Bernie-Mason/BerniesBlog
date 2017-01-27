using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BerniesBlog.Models
{
    public class RestaurantReviews : IValidatableObject
    {
        public int Id { get; set; }

        [Range(1,10)]
        [Required] // redundant for an int
        public int Rating { get; set; }

        [Required]
        [StringLength(1024)]
        public string Body { get; set; }
       
        [Display(Name ="User Name")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string ReviewerName { get; set; }

        public int RestaurantId { get; set; }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (Rating < 2 && ReviewerName.ToLower().StartsWith("scott"))
            {
                yield return new ValidationResult("Sorry Scott, you can't do this");
            }
        }
    }
}