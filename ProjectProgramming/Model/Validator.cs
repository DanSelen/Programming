using System;

namespace ProjectProgramming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value)
        { 
            if (value < 0) 
                throw new ArgumentException($"The {nameof(AssertOnPositiveValue)} property cannot be negative.");
        }
        public static void AssertOnPositiveValue(double value)
        {
            if (value < 0) 
                throw new ArgumentException($"The {nameof(AssertOnPositiveValue)} property cannot be negative.");
        }

        public static void AssertValueInRange(int value, int min, int max)
        {
            if (value < min || value >= max) 
                throw new ArgumentException($"The value {nameof(AssertValueInRange)} is out of range.");
        }
        public static void AssertValueInRange(double value, double min, double max)
        {
            if (value < min || value >= max) 
                throw new ArgumentException($"The value {nameof(AssertValueInRange)} is out of range.");
        }
    }
}
