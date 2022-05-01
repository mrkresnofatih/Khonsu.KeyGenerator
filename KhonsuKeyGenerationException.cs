using System;

namespace Khonsu.KeyGenerator
{
    public class KhonsuKeyGenerationException : Exception
    {
        public KhonsuKeyGenerationException() : base("Prefix Not Registered!")
        {
        }
    }
}