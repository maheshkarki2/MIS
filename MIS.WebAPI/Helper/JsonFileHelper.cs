using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using Newtonsoft.Json;

namespace MIS.WebAPI.Helper
{
    public static class JsonFileHelper
    {
        public static List<T> GetObjectListFromJson<T>(string jsonFile)
        {
            List<T> list = new List<T>();

            if (string.IsNullOrEmpty(jsonFile))
                return list;

            //Getting the content from Json file.
            string jsonFilepath = HostingEnvironment.MapPath(jsonFile);
            string jsonText = File.ReadAllText(jsonFilepath);

            // Deserializing from json to list of object
            list = JsonConvert.DeserializeObject<List<T>>(jsonText);

            return list;
        }

        public static T GetObjectFromJson<T>(string jsonFile)
        {
            T obj = default(T);

            if (string.IsNullOrEmpty(jsonFile))
                return obj;

            //Getting the content from Json file.
            string jsonFilepath = HostingEnvironment.MapPath(jsonFile);
            string jsonText = File.ReadAllText(jsonFilepath);

            // Deserializing from json to list of object
            obj = JsonConvert.DeserializeObject<T>(jsonText);

            return obj;
        }
    }
}