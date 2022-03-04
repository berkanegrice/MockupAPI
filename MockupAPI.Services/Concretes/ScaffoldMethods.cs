#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Reflection;

namespace MockupAPI.Services
{
    public class ScaffoldMethod : IScaffoldMethod
    {
        public void CreateScaffoldMethod(string ServiceAdress, List<Field> ReturnClassFields, object[] ReturnClassFieldValue)
        {
            // string baseAddress = "http://localhost/"+ServiceAdress;
            // BasicHttpBinding binding = new BasicHttpBinding();

            dynamic obj = new DynamicClass(ReturnClassFields);
            
            // PropertyInfo[] propertyInfos;
            // propertyInfos = obj.GetProperties(BindingFlags.Public | BindingFlags.Static);
            
            // var col = ReturnClassFields.Join(ReturnClassFieldValue, x => x, y => y, (x, y) => new {X = x, Y = y});
            // foreach(var prop in propertyInfos)
            // {
            //     Console.WriteLine(prop.Name);
            // }

            // TODO: accessing "obj" object at the runtime and set a new value.
        }
    }
}
