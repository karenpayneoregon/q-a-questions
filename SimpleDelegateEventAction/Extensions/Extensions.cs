using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SimpleDelegateEventAction.Extensions
{
    public static class Extensions
    {
        [DebuggerStepThrough]
        public static string ToYesNoString(this bool value) => (value ? "Yes" : "No");
        public static bool IsNull(this object sender)
        {
            return sender == null || sender == DBNull.Value || Convert.IsDBNull(sender) == true;
        }

        /// <summary>
        /// Is the instance of a class null
        /// </summary>
        /// <typeparam name="T">Concrete class type</typeparam>
        /// <param name="senderInstance">Instance of concrete class</param>
        /// <returns>True if null, false if not null</returns>
        public static bool IsNull<T>(this T senderInstance) where T : new() => senderInstance is null;

        /// <summary>
        /// Is the instance of a class not null
        /// </summary>
        /// <typeparam name="T">Concrete class type</typeparam>
        /// <param name="senderInstance">Instance of concrete class</param>
        /// <returns>True if not null, false if null</returns>
        public static bool IsNotNull<T>(this T senderInstance) where T : new() => !senderInstance.IsNull();

    }
}
