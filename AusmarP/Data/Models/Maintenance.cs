using System;
using System.ComponentModel.DataAnnotations;

namespace AusmarP.Data.Models
{
    public class Maintenance
    {
        [Key]
        public int Id { get; set; }
        public int IssueCode { get; set; }
        public DateTime DateRaised { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Priority { get; set; }
        public bool OpenStatus { get; set; }
        public string Note { get; set; }


        public virtual Site Site { get; set; }
        public int SiteId { get; set; }
    }
}