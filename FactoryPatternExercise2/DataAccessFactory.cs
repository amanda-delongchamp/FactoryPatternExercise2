using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
            {
                case "list":
                    return new ListDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                case "sql":
                    return new SQLDataAccess();
                default:
                    return new ListDataAccess();
            }
        }
    }
}
