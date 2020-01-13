using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GewinnspielBot.Exceptions
{
    class EmptyPropertyException : Exception
    {
        public EmptyPropertyException()
        {

        }

        public EmptyPropertyException(string message) : base(message)
        {

        } 

        public EmptyPropertyException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
