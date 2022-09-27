using System.Diagnostics;
using System.Xml.Linq;

namespace LINQDemo.Data;

public class DataSource
{
    public List<Person> People { get; } = new();
    public List<Product> Stock { get; } = new();

    public DataSource()
    {
        var rand = new Random();
        Stock.AddRange(new[]
        {
            new Product { Id = 1, Name = "Apple", Price = 3.0 },
            new Product { Id = 2, Name = "Orange", Price = 15.0 },
            new Product { Id = 3, Name = "Banana", Price = 5.5 },
            new Product { Id = 4, Name = "Grapes", Price = 30.0 },
            new Product { Id = 5, Name = "Pear", Price = 7.0 },
            new Product { Id = 6, Name = "Pineapple", Price = 40.0 },
            new Product { Id = 7, Name = "Strawberries", Price = 30.0 },
        });

        People.AddRange(new[]
        {
            new Person
            {
                Id = 1, Age = rand.Next(15,100), Name = "Niklas", 
                Cart = 
                { 
                    new Product { Id = 1, Name = "Apple", Price = 3.0 },
                    new Product { Id = 1, Name = "Apple", Price = 3.0 },
                    new Product { Id = 4, Name = "Grapes", Price = 30.0 }
                }
            },
            new Person {Id = 2, Age = rand.Next(15,100), Name = "Alina",
                Cart =
                {
                    new Product { Id = 1, Name = "Apple", Price = 3.0 },
                    new Product { Id = 1, Name = "Apple", Price = 3.0 },
                    new Product { Id = 1, Name = "Apple", Price = 3.0 }
                }},
            new Person {Id = 3, Age = rand.Next(15,100), Name = "Peter",
                Cart =
                {
                    new Product { Id = 3, Name = "Banana", Price = 5.5 },
                    new Product { Id = 3, Name = "Banana", Price = 5.5 },
                    new Product { Id = 3, Name = "Banana", Price = 5.5 }
                }},
            new Person {Id = 4, Age = rand.Next(15,100), Name = "Ali",
                Cart =
                {
                    new Product { Id = 1, Name = "Apple", Price = 3.0 },
                    new Product { Id = 6, Name = "Pineapple", Price = 40.0 },
                    new Product { Id = 2, Name = "Orange", Price = 15.0 }

                }},
            new Person {Id = 5, Age = rand.Next(15,100), Name = "Rolf",
                Cart =
                {
                    new Product { Id = 7, Name = "Strawberries", Price = 30.0 },
                    new Product { Id = 5, Name = "Pear", Price = 7.0 },
                    new Product { Id = 5, Name = "Pear", Price = 7.0 },
                }},
            new Person {Id = 6, Age = rand.Next(15,100), Name = "Angela",
                Cart =
                {
                    new Product { Id = 5, Name = "Pear", Price = 7.0 },
                    new Product { Id = 5, Name = "Pear", Price = 7.0 },
                    new Product { Id = 5, Name = "Pear", Price = 7.0 },
                }},
            new Person {Id = 7, Age = rand.Next(15,100), Name = "Annika",
                Cart =
                {
                    new Product { Id = 1, Name = "Apple", Price = 3.0 },
                    new Product { Id = 4, Name = "Grapes", Price = 30.0 }
                }},
            new Person {Id = 8, Age = rand.Next(15,100), Name = "Sara"},
            new Person {Id = 9, Age = rand.Next(15,100), Name = "Rajah",
                Cart =
                {
                    new Product { Id = 2, Name = "Orange", Price = 15.0 },
                    new Product { Id = 2, Name = "Orange", Price = 15.0 },
                    new Product { Id = 2, Name = "Orange", Price = 15.0 }
                }},
            new Person {Id = 10, Age = rand.Next(15,100), Name = "Kalle",
                Cart =
                {
                    new Product { Id = 6, Name = "Pineapple", Price = 40.0 },
                    new Product { Id = 6, Name = "Pineapple", Price = 40.0 },
                    new Product { Id = 6, Name = "Pineapple", Price = 40.0 },
                }},
        });
    }
}