﻿using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }
        public bool IsEven(int candidate)
        {
            if (candidate % 2 == 0)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }
    }
}
