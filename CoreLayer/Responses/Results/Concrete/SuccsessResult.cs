using CoreLayer.Responses.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Responses.Results.Concrete
{
    public class SuccsessResult : Result
    {
        public SuccsessResult(string message) : base(true,message)
        {
        }
        public SuccsessResult() : base(true)
        {
        }
    }
}
