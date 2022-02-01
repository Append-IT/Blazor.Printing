using System.Threading.Tasks;

namespace Append.Blazor.Printing
{
    public interface IPrintingService
    {
        Task Print(PrintOptions options);
        Task Print(string printable, PrintType printType = PrintType.Pdf);
        Task Print(string printable, bool showModal, PrintType printType = PrintType.Pdf);
    }
}