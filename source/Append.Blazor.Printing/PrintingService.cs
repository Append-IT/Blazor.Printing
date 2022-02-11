using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Append.Blazor.Printing
{
    public class PrintingService : IPrintingService
    {
        private IJSObjectReference module;
        private readonly IJSRuntime jsRuntime;

        public PrintingService(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task Print(PrintOptions options)
        {
            if (module is null)
                await ImportModule();

            await module.InvokeVoidAsync("print", new PrintOptionsAdapter(options));
        }

        public Task Print(string printable, PrintType printType = PrintType.Pdf)
        {
            return Print(new PrintOptions(printable) { Printable = printable, Type = printType });
        }
        public Task Print(string printable, bool showModal, PrintType printType = PrintType.Pdf)
        {
            return Print(new PrintOptions(printable) { ShowModal= showModal, Type = printType });
        }

        internal async ValueTask ImportModule()
        {
            module = await jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Append.Blazor.Printing/scripts.js");
        }
    }
}
