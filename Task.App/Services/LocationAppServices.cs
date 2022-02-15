using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.App.Interfaces;
using Task.Domain.Model;
using Task.Infra.Repositories;

namespace Task.App.Services
{
    public class LocationAppServices : ILocationAppServices
    {
        private readonly ILocationRepository _locationRepository;

        public LocationAppServices(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public void Add(Locations locations)
        {
            _locationRepository.Add(locations);
        }

        public IEnumerable<Locations> Get()
        {
            return _locationRepository.Get();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
