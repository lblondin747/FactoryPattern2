using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from Mongo.");
        }
    }
}
