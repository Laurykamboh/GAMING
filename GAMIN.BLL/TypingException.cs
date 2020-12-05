using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMIN.BLL
{
     public class TypingException : Exception
    {
        public TypingException() : base()
        {

        }

        public TypingException(string message) : base(message)
        {

        }
        public TypingException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
