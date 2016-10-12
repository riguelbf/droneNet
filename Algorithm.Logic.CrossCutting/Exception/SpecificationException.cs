
using System;

namespace Algorithm.Logic.CrossCutting
{
    public class SpecificationException : Exception
    {
        
        public SpecificationException(string message)
        {
            Console.WriteLine(String.Format("Error: {0}", message));
        }

        public string GetErrorDefaultValue()
        {
            return Constant.ErrorValueDefault;
        }
    }
}
