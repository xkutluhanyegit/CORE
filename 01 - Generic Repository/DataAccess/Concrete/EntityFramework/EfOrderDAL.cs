using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameworkCore;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDAL:EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDAL
    {
        
    }
}