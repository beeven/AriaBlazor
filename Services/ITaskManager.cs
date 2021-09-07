using System;
using System.Threading.Tasks;
using System.Linq;
using AriaBlazor.Models;

namespace AriaBlazor.Services
{
    public interface ITaskManager
    {
        Task InitializeAsync();
        Task<AriaVersion> GetVersionAsync();
        Task<AriaTaskStatus[]> GetActiveAsync();
        Task<AriaTaskStatus[]> GetActiveAsync(string[] keys);
    }
}