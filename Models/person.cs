using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blazorTabelWithSorted.Models
{
    public class person
    {
        public int id { get; set; }
        [Display(Name = "имя")]
        public string name { get; set; }
        [Display(Name = "фамилия")]
        public string lastname { get; set; }
        [Display(Name = "возраст")]
        public int age { get; set; }
    }
}
