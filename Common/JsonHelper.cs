using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common
{
    public static class JsonHelper
    {
        public static T JsonToModel<T>(this string json) where T : new()
        {
            T t = JsonConvert.DeserializeObject<T>(json);
            return t;
        }

        public static string ModelToString<T>(this T t) where T : class
        {
            return JsonConvert.SerializeObject(t);

        }
    }
}