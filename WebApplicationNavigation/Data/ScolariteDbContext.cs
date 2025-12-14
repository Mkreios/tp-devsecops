using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationNavigation.Models;

    public class ScolariteDbContext : DbContext
    {
        public ScolariteDbContext (DbContextOptions<ScolariteDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationNavigation.Models.Etudiant> Etudiants { get; set; } = default!;
    public DbSet<WebApplicationNavigation.Models.Groupe> Groupes { get; set; } = default!;
    public DbSet<WebApplicationNavigation.Models.Matiere> Matieres { get; set; } = default!;
    public DbSet<WebApplicationNavigation.Models.Inscription> Inscriptions { get; set; } = default!; 

}
