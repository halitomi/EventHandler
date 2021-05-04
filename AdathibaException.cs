using System;
using System.Runtime.Serialization;

namespace SZTF2_ZH2_IQGAMA
{
    
    internal class AdathibaException : Exception
    {
        public AdathibaException()
        {
        }

        public AdathibaException(string message) : base(message)
        {
        }

        public AdathibaException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}