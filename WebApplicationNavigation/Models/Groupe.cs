using System.ComponentModel.DataAnnotations;

namespace WebApplicationNavigation.Models
{
    public class Groupe
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Group ")]
        public string? LibGroupe { get; set; }
        public virtual ICollection<Etudiant>? Etudiants { get; set; }


    }
}
