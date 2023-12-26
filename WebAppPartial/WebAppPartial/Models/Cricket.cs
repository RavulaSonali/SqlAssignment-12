
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System;

namespace WebAppPartial.Models
{

    public class Cricket
    {
        
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int NOWC { get; set; }
    }
}