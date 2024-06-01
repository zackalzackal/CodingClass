using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequiredProperty
{
    internal class BirthdayInfo
    {
        public required string Name { get; set; }
        public required DateTime Birthday { get; init; }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
}
