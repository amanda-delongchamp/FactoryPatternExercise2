using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which type of database do you want to use?  SQL, Mongo or List...  Please type your answer below");
            string databaseType = Console.ReadLine();
            databaseType = databaseType.ToLower();

                while (databaseType != "sql" || databaseType != "mongo" || databaseType != "list")
                {
                    Console.WriteLine("Answer is not a database choice, please try again");
                    databaseType = Console.ReadLine();
                    databaseType = databaseType.ToLower();
                }
            
                IDataAccess database = DataAccessFactory.GetDataAccessType(databaseType);
                database.LoadData();
                database.SaveData();
                Console.ReadLine();
            
            

        }
    }
}
