using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Succces { get; }

        public string Message { get; }

        public Result(bool succces, string message):this(succces)
        {
            Message = message;
        }

        public Result(bool succces)
        {
            Succces = succces;
        }


    }
}
