using System;
using System.Collections.Generic;
using System.Text;

namespace HalmolenCA.Domain.Common
{
    public class Result<T>
    {
        public T? Value { get; private set; }
        public bool IsSuccess { get; private set; } = false;

        public string? Message { get; private set; }

        private Result() { }

        public static Result<T> Success(T value)
        {
            return new Result<T>
            {
                Value = value,
                IsSuccess = true
            };
        }

        public static Result<T> Failure(string message)
        {
            return new Result<T>
            {
                IsSuccess = false,
                Message = message
            };
        }

    }
}
