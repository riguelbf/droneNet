using System;

namespace Algorithm.Logic.CrossCutting
{
    public static class ExceptionFilter
    {
        public static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            new SpecificationException(e.ExceptionObject.ToString()).GetErrorDefaultValue();
        }
    }
}
