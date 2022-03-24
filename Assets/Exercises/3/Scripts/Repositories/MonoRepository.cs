using System.Threading.Tasks;
using UnityEngine;

namespace Project.Exercise3.Repositories
{
    public abstract class MonoRepository<Data> : MonoBehaviour, IRepository<Data>
    {
        public abstract Task<Data> GetData();
    }
}