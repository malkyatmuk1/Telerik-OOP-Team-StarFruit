﻿using System;

namespace ExceptionLib
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException()
        {
        }

        public ProductNotFoundException(string message)
        : base(message)
        {
        }

        public ProductNotFoundException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
