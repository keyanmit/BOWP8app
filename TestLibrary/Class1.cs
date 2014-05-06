using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace TestLibrary
{
    public class Class1
    {
        [JsonProperty("matter")]
        public int MyProperty { get; set; }
    }
}
