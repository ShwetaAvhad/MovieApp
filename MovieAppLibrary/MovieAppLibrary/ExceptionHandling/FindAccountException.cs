using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppLibrary.ExceptionHandling
{
    public class FindAccountException : Exception
    {
        public FindAccountException(string msg) : base(msg)
        {

        }
    }
}
