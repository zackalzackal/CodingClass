using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceoptionFiltering
{
    internal class Filterableexceoption : Exception
    {
        public int ErrorNO { get; set; }
    }
}
