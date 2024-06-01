﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitOnly
{
    internal class Transaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount {  get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }
}
