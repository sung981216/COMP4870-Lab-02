using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Canada.Models;

public static class SeedData {

    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );

        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

    public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province() {
                ProvinceCode="BC",
                ProvinceName="British Columbia",    
            },
            new Province() {
                ProvinceCode="AB",
                ProvinceName="Alberta",    
            },
            new Province() {
                ProvinceCode="ON",
                ProvinceName="Ontario",    
            },
        };
        return provinces;
    }

    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 630,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Victoria",
                Population = 80,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Kamloops",
                Population = 90,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Edmonton",
                Population = 970,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 5,
                CityName = "Calgary",
                Population = 1200,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 6,
                CityName = "Red Deer",
                Population = 100,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 7,
                CityName = "Ottawa",
                Population = 930,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 8,
                CityName = "Toronto",
                Population = 2600,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 9,
                CityName = "Mississauga",
                Population = 720,
                ProvinceCode = "ON"
            },
        };
        return cities;
    }
}