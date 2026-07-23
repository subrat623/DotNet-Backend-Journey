using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class GenericClass<T>
    {
        public T Data;
        public GenericClass(T data) {
            Data = data;
        }

    }
}
