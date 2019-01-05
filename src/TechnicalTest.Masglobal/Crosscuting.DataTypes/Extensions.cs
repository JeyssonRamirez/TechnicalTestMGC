using System;

namespace Crosscuting.DataTypes
{
    public static class Extensions
    {
        public static T ToEnum<T>(this string value, T defaultValue)
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            T result;
            result=(T)Enum.Parse(typeof(T), value, true);
            return result;
        }
        
    }
}
