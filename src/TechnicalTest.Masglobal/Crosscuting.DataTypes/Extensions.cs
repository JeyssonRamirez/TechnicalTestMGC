//   -----------------------------------------------------------------------
//   <copyright file=Extensions.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 9:27 PM</Date>
//   <Update> 2019-01-05 - 12:47 AM</Update>
//   -----------------------------------------------------------------------

#region

using System;

#endregion

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
            result = (T) Enum.Parse(typeof(T), value, true);
            return result;
        }
    }
}