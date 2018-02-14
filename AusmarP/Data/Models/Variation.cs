using System;
using System.ComponentModel.DataAnnotations;

namespace AusmarP.Data.Models
{
    public class Variation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int VariationCode { get; set; }
        public DateTime DateReleased { get; set; }
        public bool PostContract { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int Price { get; set; }
        public int EOT { get; set; }
        public bool ApprovedStatus { get; set; }
        public bool Claimed { get; set; }
        public bool Paid { get; set; }
        public DateTime PaymentDate { get; set; }

        

        public virtual Site Site { get; set; }
        public int SiteId { get; set; }
    }
}