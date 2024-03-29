using System;

namespace ProjectProgramming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        { 
            if (value < 0) 
                throw new ArgumentException($"The {nameof(propertyName)} property cannot be negative.");
        }
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0) 
                throw new ArgumentException($"The {nameof(propertyName)} property cannot be negative.");
        }

        public static void AssertValueInRange(int value, int min, int max,string propertyName)
        {
            if (value < min || value >= max) 
                throw new ArgumentException($"The value {nameof(propertyName)} is out of range.");
        }
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value >= max) 
                throw new ArgumentException($"The value {nameof(propertyName)} is out of range.");
        }
    }
}
