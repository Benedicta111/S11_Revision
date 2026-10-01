using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PresseMots.Models
{
    public class StoryTag
    {
        public int Id { get; set; }
        
        public int? TagId { get; set; }
        [ValidateNever]
        public virtual Tag Tag { get; set; }
       
        public int? StoryId { get; set; }
        [ValidateNever]
        public virtual Story Story { get; set; }
    }
}
