using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Employeepractice.Filters
{
    public class myexceptionfilter:IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult("An error occurred!") { StatusCode = 500 };
            context.ExceptionHandled = true;
        }
    }
    
}
