using System;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use?(List,SQL,Mongo)");
            var databaseType = Console.ReadLine();
            IDataAccess newDataAccess = DataAccessFactory.GetDataAccessType(databaseType);
            newDataAccess.LoadData();
            newDataAccess.SaveData();
        }
    }
}
