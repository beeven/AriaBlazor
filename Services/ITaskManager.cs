using System;
using System.Threading.Tasks;
using System.Linq;

namespace AriaBlazor.Services
{
    public interface ITaskManager
    {
        Task InitializeAsync();
        Task<AriaVersion> GetVersionAsync();
        Task<AriaTaskStatus[]> GetActiveAsync(string[] keys);
    }
}