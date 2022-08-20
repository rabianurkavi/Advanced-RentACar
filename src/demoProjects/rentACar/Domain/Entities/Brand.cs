using Core.Persistence.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core.CustomTypeProviders;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand:Entity
    {
       
        public string BrandName { get; set; }
        public Brand()
        {

        }

        public Brand(int id,string brandName):this()
        {
            Id = id;
            BrandName = brandName;
        }
    }
}
