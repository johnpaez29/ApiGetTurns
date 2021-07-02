using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessTurnLogic.DataAccess
{
    public interface IrepositoryService<T>
    {
        T GetDataByName(string name);
    }
}
