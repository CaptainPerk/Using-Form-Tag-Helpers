﻿using Cities.Models.Interfaces;
using System.Collections.Generic;

namespace Cities.Models
{
    public class MemoryCityRepository : ICityRepository
    {
        private readonly List<City> cities = new List<City>
        {
            new City{ Name = "London", Country = "England", Population = 8539000 },
            new City{ Name = "New York", Country = "USA", Population = 8406000 },
            new City{ Name = "San Jose", Country = "USA", Population = 998537 },
            new City{ Name = "Paris", Country = "France", Population = 2244000 },
        };

        public IEnumerable<City> Cities => cities;
        public void AddCity(City newCity) => cities.Add(newCity);
    }
}
