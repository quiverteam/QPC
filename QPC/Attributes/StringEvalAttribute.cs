using System;

namespace QPC.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class StringEvalExtension : System.Attribute
    {
        public StringEvalExtension()
        {
        }
    }
}
