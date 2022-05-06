using System;

namespace Append.Blazor.Printing
{
    internal static class PrintTypeExtensions
    {
        /// <summary>
        /// Adapts the <see cref="PrintType"/> to the JavaScript version.
        /// </summary>
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
