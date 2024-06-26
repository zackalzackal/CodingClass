using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    internal class InvalidArgumentException : Exception
    {
        public InvalidArgumentException()
        {

        }

        public InvalidArgumentException(string message) : base(message)
        {

        }
        public object Argument
        {
            get;
            set;
        }

        public string Range
        {
            get;
            set;
        }
    }
}
