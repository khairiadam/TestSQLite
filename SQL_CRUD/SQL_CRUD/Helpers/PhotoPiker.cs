using System.IO;
using System.Threading.Tasks;

namespace TestSQLite.Helpers
{
    public interface IPhotoPiker
    {
        Task<Stream> GetImageStreamAsync();
    }
}