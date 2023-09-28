using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );

            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
        }

        

        public static List<City> GetCities(){
            List<City> cities = new List<City>(){
                new City(){
                    CityId = 1,
                    CityName = "Surrey",
                    Population = 300000,
                    ProvinceCode = "BC"
                },
                  new City(){
                    CityId = 2,
                    CityName = "Toronto",
                    Population = 400000,
                    ProvinceCode = "ON"
                },
                  new City(){
                    CityId = 3,
                    CityName = "Calgary",
                    Population = 100000,
                    ProvinceCode = "AB"
                },
                new City(){
                    CityId = 4,
                    CityName = "Burnaby",
                    Population = 300000,
                    ProvinceCode = "BC"
                },
                new City(){
                    CityId = 5,
                    CityName = "Richmond",
                    Population = 300000,
                    ProvinceCode = "BC"
                },
                new City(){
                    CityId = 6,
                    CityName = "New West",
                    Population = 300000,
                    ProvinceCode = "BC"
                },
                 new City(){
                    CityId = 7,
                    CityName = "Edmonton",
                    Population = 50000,
                    ProvinceCode = "AB"
                },
                 new City(){
                    CityId = 8,
                    CityName = "Banf",
                    Population = 3000,
                    ProvinceCode = "AB"
                },
                    new City(){
                    CityId = 9,
                    CityName = "Ottawa",
                    Population = 300000,
                    ProvinceCode = "ON"
                },
                 new City(){
                    CityId = 10,
                    CityName = "Brampton",
                    Population = 700000,
                    ProvinceCode = "ON"
                },


            };
            return cities;
        }

         public static List<Province> GetProvinces(){
            List<Province> provinces = new List<Province>(){
                new Province(){
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                    
                },
                  new Province(){
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario",
                    
                },
                  new Province(){
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                },
            };
            return provinces;
        }
    }
}