using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearcher.Model
{
    public class Rating
    {
        string source;
        string value;

        public string Source { get => source; set => source = value; }
        public string Value { get => value; set => this.value = value; }

    }
}
