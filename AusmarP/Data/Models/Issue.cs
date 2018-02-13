using System.ComponentModel.DataAnnotations;

namespace AusmarP.Data.Models
{
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual Site Site { get; set; }
        public int SiteId { get; set; }

    }
}