using System.ComponentModel.DataAnnotations;

namespace WebApplicationNavigation.Models
{
    public class Matiere
    {
        public int Id { get; set; }
        [Display(Name = "Matiere ")]
        [Required, StringLength(30, MinimumLength = 3)]
        public string? libMatiere { get; set; }
        public virtual ICollection<Inscription>? Inscriptions { get; set; }
    }
}
