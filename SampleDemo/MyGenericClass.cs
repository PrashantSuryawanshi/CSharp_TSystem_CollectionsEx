using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    internal class MyGenericClass<T>
    {
        private T data;
        public MyGenericClass(T data)
        {
            this.data = data;

        }
        public T getData()
        {
            return data;
        }
        public override string ToString()
        {
            return "data is " + data;
        }
    }
}
