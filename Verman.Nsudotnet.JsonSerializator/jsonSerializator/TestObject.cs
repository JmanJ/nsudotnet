using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JsonSerializator
{
    [Serializable]
    class TestObject
    {
        public int i;
        public string s;

        [NonSerialized]
        public string ignore; // это поле не должно сериализоваться

        public string[] arrayMember;
        public bool b;

        public TestObject()
        {
            i = 5;
            s = "Hahaha";
            ignore = "IgnoreMe";
            arrayMember = new string[] { "1", "3", "5", "7", "9" };
            b = true;
        }
    }
}
