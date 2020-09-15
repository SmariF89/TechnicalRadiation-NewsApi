using System.Collections.Generic;
using System.Dynamic;


namespace TechnicalRadiation.Models
{
    public static class HyperMediaExtensions
    {
        public static void AddReference<T>(this ExpandoObject item, string key, T value) => ((IDictionary<string, object>)item).Add(key, value);
        public static void AddReferences<T>(this ExpandoObject item, string key, T[] value) => ((IDictionary<string, object>)item).Add(key, value);
    }
}