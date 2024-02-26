using System;
using System.Text.Json.Serialization;

namespace Append.Blazor.Printing
{
    /// <summary>
    /// Adapts the <see cref="PrintOptions"/> to the JavaScript version.
    /// </summary>
    internal record PrintOptionsAdapter
    {
        public string Printable { get; init; }
        public string Type { get; init; }
        public bool ShowModal { get; init; }
        public string ModalMessage { get; init; } = "Retrieving Document...";
        public bool? Base64 { get; set; }
        public string TargetStyles { get; set; } = "['*']";
        [JsonPropertyName("font_size")]
        //HACK: This is a hack to get around the fact that the PrintJS is dead and issue https://github.com/crabbly/Print.js/issues/534 is not getting fixed anytime soon.
        public string FontSize { get; set; }

        public PrintOptionsAdapter(PrintOptions options)
        {
            Printable = options.Printable;
            Type = options.Type.ToPrintJsString();
            ShowModal = options.ShowModal;
            ModalMessage = options.ModalMessage;
            Base64 = options.Base64 == true ? true : null;
            FontSize = options.UseFontSizeWorkaround ? "" : "12px"; //12px is the default value in PrintJS
        }
    }
}
