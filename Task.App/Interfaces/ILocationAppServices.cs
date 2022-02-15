using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Model;

namespace Task.App.Interfaces
{
    public interface ILocationAppServices : IDisposable
    {
        void Add(Locations locations);
    }
}
