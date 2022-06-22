using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssignment.Utilities.Exceptions
{
    public class ShopAssignmentException : Exception
    {
        public ShopAssignmentException()
        {
        }

        public ShopAssignmentException(string message)
            : base(message)
        {
        }

        public ShopAssignmentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
