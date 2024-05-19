using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
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

        public IResult Add(Order order)
        {
            ValidationTool.Validate(new OrderValidator(),order);
            _orderDAL.Add(order);
            return new SuccessResult();
        }

        public IDataResult<List<Order>> GetAll()
        {
            var result = _orderDAL.GetAll();
            return new SuccessDataResult<List<Order>>(result,Messages.SuccessListed);
        }

        
    }
}