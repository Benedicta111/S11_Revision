using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PresseMots.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public virtual List<Story>? Story { get; set; }
        public virtual List<StoryTag> StoryTags { get; set; }
    }
}
