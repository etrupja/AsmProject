using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AusmarP.Data.Models
{
    public class Site
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string HomeOwner { get; set; }
        public int ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string HouseType { get; set; }
        public int ContractValueExGST { get; set; }
        public int ContractValueIncGST { get; set; }
        public DateTime ContractDate { get; set; } 
        public int PreContactEOT { get; set; }
        public DateTime DOPCDate { get; set; }
        public int TwelveMonthMaintenance { get; set; }
        public string Note { get; set; }


        //Relations
        public List<Issue> Issues { get; set; }
        public List<Maintenance> Maintenances { get; set; }
        public List<ProgressStage> ProgressStages { get; set; }
        public List<Variation> Variations { get; set; }

    }
}
