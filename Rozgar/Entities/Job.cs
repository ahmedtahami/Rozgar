using Rozgar.Enums;
using Rozgar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rozgar.Entities
{
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public double Budget { get; set; }
        public string ClientId { get; set; }
        [ForeignKey("ClientId")]
        public ApplicationUser Client { get; set; }
        public int SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory SubCategory { get; set; }
        public List<string> Attachments { get; set; }
        public ExperienceLevelEnum ExperienceLevel { get; set; }
    }
}