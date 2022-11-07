using System.ComponentModel.DataAnnotations;

namespace ZadDomMVC.Models
{
    public class Comment
    {
        [Required(ErrorMessage = "Musisz coś napisać, żeby skomentować!")]
        public string Content { get; set; }
    }
}
