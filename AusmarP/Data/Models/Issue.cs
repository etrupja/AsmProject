﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AusmarP.Data.Models
{
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Priority { get; set; }
        public bool Status { get; set; }
        public string Note { get; set; }


        public virtual Site Site { get; set; }
        public int SiteId { get; set; }
        }

    }
