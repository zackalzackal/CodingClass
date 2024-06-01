using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyFields
{
    internal class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            max = v2;
        }

        public void ChangeMax(int newMax)
        {
            max = newMax;
        }
    }
}
