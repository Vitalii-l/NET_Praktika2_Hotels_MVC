﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NET_Praktika2_Hotels_MVC.Models
{
    public class CitiesCollection
    {
        public static List<City> listCities = new List<City>();

         //статический конструктор
         static CitiesCollection()
         {
            listCities.Add(new City
            {
                Id = 1,
                Titel = "Tallinn",
                Hotels = new List<Hotel>()
                {
                     new Hotel { Id = 1, Name = "Radisson Blu Sky Hotel", Services = "Free Wifi Restaurant", PhotoFile = "\\Content\\Radisson.png", Aadress = "Ravala pst, 3" },
                     new Hotel { Id = 2, Name = "Hotel Palace", Services = "Breakfast Included Free Internet", PhotoFile = "\\Content\\Palace.png", Aadress = "Vabaduse Valjak, 3"},
                     new Hotel { Id = 3, Name = "Nordic Hotel Forum", Services = "Reserve now, pay later Breakfast Included", PhotoFile = "\\Content\\Forum.png", Aadress = "Viru Valjak, 3"}
                }
            });
            listCities.Add(new City
            {
                Id = 2,
                Titel = "Tartu",
                Hotels = new List<Hotel>()
                {
                    new Hotel { Id = 4, Name = "Art Hotel Pallas", Services = "Air conditioning Free Wifi Breakfast ", PhotoFile = "\\Content\\PallasTarty.png", Aadress = "Riia, 4" },
                    new Hotel { Id = 5, Name = "Hotel Tartu ", Services = "Free Wifi Breakfast included", PhotoFile = "\\Content\\Tarty.png", Aadress = "Soola, 3"}
                }
            });
            listCities.Add(new City
            {
                Id = 3,
                Titel = "Toila",
                Hotels = new List<Hotel>()
                {
                    new Hotel { Id = 6, Name = "Toila Spa Hotel", Services = "Спа и оздоровительный центр Бассейн Бесплатная парковка ", PhotoFile = "\\Content\\Toila.png", Aadress = "Ranna, 12" }
                }
            });
         }
    }
}