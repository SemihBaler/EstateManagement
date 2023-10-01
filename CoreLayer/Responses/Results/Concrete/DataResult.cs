using CoreLayer.Responses.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Responses.Results.Concrete
{
    public class DataResult<T> :Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message)
        {
            data = Data;

        }
        public DataResult(T data, bool success) : base(success)
        {
            data = Data;

        }

        public T Data { get; }

    }
}
