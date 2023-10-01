using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Responses.Results.Concrete
{
    public class SuccsessDataResult<T> : DataResult<T>
    {
        public SuccsessDataResult(T data, string message) : base(data, true, message)
        {
        }
        public SuccsessDataResult(T data) : base(data, true)
        {
        }
        public SuccsessDataResult(string message) : base(default, true)
        {
        }
        public SuccsessDataResult() : base(default, true)
        {
        }

    }
}