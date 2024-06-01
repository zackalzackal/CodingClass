using System;

namespace SealedMathod
{
    internal class Derived : Base
    {
        public sealed override void SealMe()
        {
        }
    }
}
