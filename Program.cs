using System;
using System.Threading;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            bool correctInput;

            do {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("Which database would you like to use?");
                Console.WriteLine("Type sql");
                Console.WriteLine("Type list");
                Console.WriteLine("Type mongo");

                userInput = Console.ReadLine();

                if(userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Please try again");
                    Thread.Sleep(1000);
                }
            
            } while (!correctInput); ;

            Console.Clear();


            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);
           
            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name : {product.Name}     Price:   {product.Price}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
