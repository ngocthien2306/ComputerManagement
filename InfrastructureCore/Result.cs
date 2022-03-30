using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureCore
{
    public class Result
    {
        public bool Success { get; set; }

        public string Error { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public Result(bool success, string error)
        {
            Success = success;
            Error = error;
        }

        public Result()
        {
            Success = false;
            Error = "";
        }

        public static Result Fail(string error)
        {
            return new Result(false, error);
        }

        public static Result Ok()
        {
            return new Result(true, null);
        }

    }
}
