using ProcessTurnLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessTurnLogic.DataAccess
{
    public interface IRepositoryTurn<T,V>
    {
        IEnumerable<T> GetData(V info);
    }
}
