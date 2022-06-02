using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.IO;

namespace Collect_Dudes.Serialization
{
    internal static class Save<T>
    {
        
        public static void SaveData(T data, string path)
        {
           JObject jsonObject = (JObject)JToken.FromObject(data);
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(jsonObject.ToString());
            }
        }
        public static T LoadData(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                using (JsonTextReader jsonReader = new JsonTextReader(file))
                {
                    JObject jsonObject = (JObject)JToken.ReadFrom(jsonReader);
                    return (T)jsonObject.ToObject<T>();
                }
            }
        }
    }
}
