using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearcher.Exceptions
{
    class MovieNotFoundException: Exception
    {
        public MovieNotFoundException(): base("Movie not found exception")
        {

        }
    }
}
