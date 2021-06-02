using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {
        public void LoadData();

        public void SaveData();
    }
}
