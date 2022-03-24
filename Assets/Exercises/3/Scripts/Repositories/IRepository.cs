using System.Threading.Tasks;

namespace Project.Exercise3.Repositories
{
    public interface IRepository<Data>
    {
        Task<Data> GetData();
    }
}