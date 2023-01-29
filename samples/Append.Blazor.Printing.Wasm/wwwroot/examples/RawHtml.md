@inject IPrintingService PrintingService
<Example Name="@this.GetType().Name">
    <Documentation>
        <h3>Raw HTML</h3>
        <p>Print raw HTML.</p>
    </Documentation>
    <Code>
        @{
            string rawHtml = String.Join(
                Environment.NewLine,
                "<h1>Print.js Raw HTML Print Test</h1>",
                "<p style=\"color: blue;\">Lorem ipsum dolor sit amet, consectetur adipiscing elit,</p>",
                "<p>sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>");
        }

        <button @onclick="@(_ => PrintingService.Print(rawHtml, PrintType.RawHtml))">
            Print Raw Html
        </button>
    </Code>
</Example>