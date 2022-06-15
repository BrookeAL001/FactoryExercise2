using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name= "Xbox", Price = 399},
            new Product(){Name = "Beats", Price = 179},
            new Product(){Name = "Sous Vide", Price = 150},
            new Product(){Name= "Apple Watch", Price = 199}
        };


        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo data access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from Mongo data access");
        }

    }
}
