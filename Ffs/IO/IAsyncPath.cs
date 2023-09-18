using System.Threading;
using System.Threading.Tasks;

namespace Ffs.IO
{
    public interface IAsyncPath : IPath
    {
        Task CopyToAsync(IAsyncPath destination, bool overwrite, CancellationToken token);
    }
}