using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_App.Repo.IRepo
{
    interface IRepo<T> where T : class
    {
        Task<T> GetAsync(string url, int id);
        Task<IEnumerable<T>> GetAllAsync(string url);
        Task<bool> CreateAsync(string url, T objectCreate);
        Task<bool> UpdateAsync(string url, T objectUpdate);
        Task<T> DeleteAsync(string url, int id);

    }
}
