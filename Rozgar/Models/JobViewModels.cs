using Rozgar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rozgar.Models
{
    public class JobDetailViewModel
    {
        public Job Job { get; set; }
        public List<string> Skills { get; set; }
    }
    
}