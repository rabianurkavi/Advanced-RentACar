using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        //BURASI BASEDBCONTEXTE GÖRE ÇALIŞACAK
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
