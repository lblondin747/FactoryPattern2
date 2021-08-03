using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL.");
        }
    }
}
