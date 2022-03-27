using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SklepInternetowy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S Plaid",
                        shortDesc = "Szybkość i elegancja",
                        longDesc = "Wygodny dla miasta, ale ukrywa niesamowity potencjał",
                        img = "/img/Tesla_Model_S_Plaid.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Elektryczne samochody"]
                    },
                    new Car
                    {
                        name = "Dodge Ram 1500",
                        shortDesc = "Siła i wygoda",
                        longDesc = "Pasuje dla tych, którzy mieszkają poza miastem",
                        img = "/img/Dodge_Ram_1500.jpg",
                        price = 40000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Zwykłe samochody"]
                    },
                    new Car
                    {
                        name = "Tesla Model X",
                        shortDesc = "Wygoda dla rodziny",
                        longDesc = "Pojazd dla rodziny wygodny, jak w mieście, tak i poza nim",
                        img = "/img/Tesla_Model_X.jpg",
                        price = 40000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Elektryczne samochody"]
                    },
                    new Car
                    {
                        name = "Dodge Charger",
                        shortDesc = "Szybkość i moc",
                        longDesc = "Samochód który przekazuje amerykańskie tradycję pojazdów",
                        img = "/img/Dodge_Charger.jpg",
                        price = 25000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Zwykłe samochody"]
                    },
                    new Car
                    {
                        name = "Toyota Hilux",
                        shortDesc = "Wygoda i niezawodność",
                        longDesc = "Pasuje dla tych, którzy mieszkają poza miastem",
                        img = "/img/Toyota_Hilux.jpg",
                        price = 20000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Zwykłe samochody"]
                    },
                    new Car
                    {
                        name = "Peugeot 508",
                        shortDesc = "Bezczelny i stylowy",
                        longDesc = "Dla tych którzy lubią wygodę i styl",
                        img = "/img/Peugeot_508.jpg",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Zwykłe samochody"]
                    },
                    new Car
                    {
                        name = "Volkswagen Golf",
                        shortDesc = "Mały i wygodny",
                        longDesc = "Bardzo wygodny dla miasta, dzięki swoim rozmiarom",
                        img = "/img/Volkswagen_Golf.jpg",
                        price = 10000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Elektryczne samochody"]
                    },
                    new Car
                    {
                        name = "Porshe Taycan",
                        shortDesc = "Szybkość i elegancja",
                        longDesc = "Ekologiczny samochód który tworzy konkurencję dla samochodów sportowych",
                        img = "/img/Porsche_Taycan.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Elektryczne samochody"]
                    },
                    new Car
                    {
                        name = "Chevrolet Corvette",
                        shortDesc = "Szybki i niepowstrzymany",
                        longDesc = "Dla ludzi którzy lubią szybkość",
                        img = "/img/Chevrolet_Corvette.png",
                        price = 30000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Zwykłe samochody"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Elektryczne samochody", desc = "Nowoczesny typ pojazdów"},
                        new Category { categoryName = "Zwykłe samochody", desc = "Auta z silnikiem spalinowym"},
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
