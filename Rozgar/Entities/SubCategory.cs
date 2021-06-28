using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rozgar.Entities
{
    public class SubCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name ="Sub-Category Name")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Display(Name ="Category Name")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [Display(Name ="Category Name")]
        public virtual Category Category { get; set; }
        public bool Status { get; set; }
    }
}