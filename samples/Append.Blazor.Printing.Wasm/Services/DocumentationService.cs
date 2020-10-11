using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Append.Blazor.Printing.Documentation.Services
{
    public class DocumentationService
    {
        private readonly HttpClient client;
        private static string SampleCodeBlockWrapperStart = "<Code>";
        private static string SampleCodeBlockWrapperEnd = "</Code>";

        public DocumentationService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<string> GetSampleCode(string exampleName)
        {
            var file = await client.GetStringAsync($"examples/{exampleName}.md");

            int pFrom = file.IndexOf(SampleCodeBlockWrapperStart) + SampleCodeBlockWrapperStart.Length;
            int pTo = file.LastIndexOf(SampleCodeBlockWrapperEnd);

            return file[pFrom..pTo]; ;
        }
    }
}
