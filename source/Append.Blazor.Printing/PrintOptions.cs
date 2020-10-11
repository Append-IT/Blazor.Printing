namespace Append.Blazor.Printing
{
    /// <summary>
    /// Options for a specific print.
    /// </summary>
    public record PrintOptions
    {
        public PrintOptions()
        {

        }
        public PrintOptions(string printable)
        {
            Printable = printable;
        }

        public PrintOptions(string printable, string modalMessage)
        {
            Printable = printable;
            ModalMessage = modalMessage;
            ShowModal = true;
        }
        /// <summary>
        /// Document source: pdf url or base64.
        /// </summary>
        public string Printable { get; init; }
        /// <summary>
        /// Printable type.
        /// </summary>
        internal PrintType Type { get; init; } = PrintType.Pdf;
        /// <summary>
        /// Enable this option to show user feedback when retrieving or processing large PDF files.
        /// </summary>
        public bool ShowModal { get; init; }
        /// <summary>
        /// Message displayed to users when <see cref="ShowModal"/> is set to true.
        /// </summary>
        public string ModalMessage { get; init; } = "Retrieving Document...";
        /// <summary>
        /// Used when printing PDF documents passed as base64 data.
        /// </summary>
        public bool Base64 { get; set; }
    }
}
