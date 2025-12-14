using System.ComponentModel.DataAnnotations;

namespace WebApplicationNavigation.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Last name needed ")]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }
        [Display(Name = " birth date")]
        public  DateTime DateN { get; set; }
        [Display(Name = "groupe")]
         public int GroupeId { get; set; }
        public string FullName { get { return Name + " " + LastName;  } }
         public virtual Groupe? Groupe { get; set; }
        public virtual ICollection<Inscription>? Inscriptions { get; set; }
        public string NomPrenom
        {
            get
            {
                return Name + " " + LastName;
            }
        }


    }

}
