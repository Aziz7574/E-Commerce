using System;
using Xeptions;

namespace E_Commerce.DataBase
{
    public class InvalidClientException : Xeption
    {
        public InvalidClientException() : base(message: "Client is invalid")
        {
        }

        internal void ThrowIfContainsError()
        {
            throw new NotImplementedException();
        }
    }
}