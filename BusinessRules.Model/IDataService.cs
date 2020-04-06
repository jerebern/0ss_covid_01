using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Model
{
    interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }

}
