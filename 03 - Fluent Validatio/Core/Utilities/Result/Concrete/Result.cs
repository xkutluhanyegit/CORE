using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Result.Abstract;

namespace Core.Utilities.Result.Concrete
{
    public class Result:IResult
    {
        public bool Success { get; }

        public string Message { get; }

        public Result(bool success)
        {
            Success = success;
        }

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
    }
}