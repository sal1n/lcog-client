using System;

namespace LcogClient.Utility
{
    public class LcogException : Exception
    {
        public LcogException() {}

        public LcogException(string message) : base(message) {}
    }
}
