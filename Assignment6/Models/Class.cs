using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment6.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        public string ClassName { get; set; }


        public virtual ICollection<Teacher> Teachers {get; set;}
 
    }
}