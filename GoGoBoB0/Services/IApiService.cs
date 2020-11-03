using System;
using System.Threading.Tasks;
namespace GoGoBoB0.Services
{

    public interface IApiService
    {
        Task<Root> GetKrisFeed();
        Task<string> Get(string url);
    }
}
