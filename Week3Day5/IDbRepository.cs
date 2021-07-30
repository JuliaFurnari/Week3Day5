using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day5
{
    interface IDbRepository<T>
    {
        public List<T> CreationList();
        public List<T> CreationEmptyList();
    }
}
