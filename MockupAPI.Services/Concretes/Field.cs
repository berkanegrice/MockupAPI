using System;

namespace MockupAPI.Services
{
    public class Field
    {
        public string FieldName;
        public Type FieldType;
        
        public Field(string name, Type type)
        {
            this.FieldName = name;
            this.FieldType = type;
        }
    }
}
