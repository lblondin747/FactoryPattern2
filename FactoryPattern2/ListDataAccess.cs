using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List.");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from List.");
        }
    }
}
