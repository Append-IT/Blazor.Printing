using System;

namespace Append.Blazor.Printing
{
    public static class PrintTypeExtensions
    {
        public static string ToPrintJsString(this PrintType printType)
        {
            return printType switch
            {
                PrintType.RawHtml => "raw-html",
                _ => Enum.GetName(typeof(PrintType), printType).ToLower(),
            };
        }
    }
}
