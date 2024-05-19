using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Result;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDAL _orderDAL;
        public OrderManager(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }
        public IDataResult<List<Order>> GetAll()
        {
            var result = _orderDAL.GetAll();
            return new SuccessDataResult<List<Order>>(result,Messages.SuccessListed);
        }
    }
}