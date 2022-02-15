using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Domain.Model;
using Task.Infra.Repositories;

namespace Task.Infra
{
    public class LocationRepository : ILocationRepository
    {
        protected readonly TaskDbContext _dbContext;

        public LocationRepository(TaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Locations obj)
        {
            obj.Id = 1;
            _dbContext.locations.Update(obj);
            _dbContext.SaveChanges();

        }
        public Locations Get()
        {
            var v = _dbContext.locations.AsNoTracking().FirstOrDefault(x => x.Id == 1);
            return _dbContext.locations.AsNoTracking().FirstOrDefault(x => x.Id == 1);
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

}
