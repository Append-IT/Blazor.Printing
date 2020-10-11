using System.Threading.Tasks;

namespace Append.Blazor.Printing
{
    public interface IPrintingService
    {
        Task Print(PrintOptions options);
        Task Print(string printable);
        Task Print(string printable, bool showModal);
    }
}