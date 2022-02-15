using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Model;
namespace Task.Infra.Repositories
{
    public interface ILocationRepository : IDisposable
    {

        void Add(Locations obj);
        Locations Get();
        int SaveChanges();
    }
}
