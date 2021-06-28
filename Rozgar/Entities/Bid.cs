using Rozgar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rozgar.Entities
{
    public class Bid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Proposal { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public double Budget { get; set; }
        public string FreelancerId { get; set; }
        [ForeignKey("FreelancerId")]
        public ApplicationUser Freelancer { get; set; }
        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public Job Job { get; set; }
        public List<string> Attachments { get; set; }
    }
}