using System;
using System.ComponentModel.DataAnnotations;

namespace AusmarP.Data.Models
{
    public class ProgressStage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stage { get; set; }
        public int Value { get; set; }
        public DateTime DateCompleted { get; set; }
        public string CompletedBy { get; set; }
        public DateTime DateApproved { get; set; }
        public string ApprovedBy { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime DatePaid { get; set; }
    


        public virtual Site Site { get; set; }
        public int SiteId { get; set; }

    }
}