using System.Net.Http;
using System.Collections.Generic;

#nullable enable
namespace MockupAPI.Services
{
    public interface IScaffoldMethod
    {
        public void CreateScaffoldMethod(string ServiceAdress, List<Field> ReturnClassFields, object[] ReturnClassFieldValue);
    }
}