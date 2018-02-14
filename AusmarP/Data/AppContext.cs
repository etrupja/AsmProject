using AusmarP.Data.Models;
using System.Data.Entity;

namespace AusmarP.Data
{
    public class AppContext:DbContext
    {
        public AppContext():base()
        {
        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<ProgressStage>ProgressStages { get; set; }
        public DbSet<Variation> Variations { get; set; }
    }
}