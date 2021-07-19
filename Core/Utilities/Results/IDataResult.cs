using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IDataResult<T>:IResult
    {
        //listeler için bunu yaz

        T Data { get; }
    }
}
