//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace RoaSystems.Web.Portal.Models
//{
//    public class ScriptBlock
//    {
//    }
//}
using System;
using System.Collections;

namespace RoaSystems.Web.Portal.Models
{
    public class ScriptBlock : IEnumerable
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
