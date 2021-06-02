using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
   public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine($"I am reading data from {this.GetType().Name} database");
        }

        public void SaveData()
        {
            Console.WriteLine($"I am wirting data to {this.GetType().Name} database");
        }
    }
}
