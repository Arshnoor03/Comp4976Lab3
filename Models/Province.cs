using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityApp.Models
{
    public class Province
    {
        
        [Key]
        [Display(Name = "Province Code")]
        public string? ProvinceCode {get; set;}

        [Display(Name = "Province")]
        public string? ProvinceName {get; set;}

        public List<City>? Cities {get; set;}

    }
}