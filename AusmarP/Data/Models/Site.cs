using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AusmarP.Data.Models
{
    public class Site
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        //Relations
        public List<Issue> Issues { get; set; }


    }
}