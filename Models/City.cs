using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CommunityApp.Models
{
    public class City
    {
        [Key]
        public int CityId {get; set;}

        [Display(Name = "City")]
        public string? CityName {get; set;}

        public int Population {get; set;}

        public string? ProvinceCode {get; set;}

        [ForeignKey("ProvinceCode")] // Define the foreign key property name
        public Province? ProvinceNavigation { get; set; }

    }
}