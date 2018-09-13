using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearcher.Exceptions
{
    class TooManyResultsException: Exception
    {
        public TooManyResultsException(): base("Too many Results")
        {
        }
    }
}
