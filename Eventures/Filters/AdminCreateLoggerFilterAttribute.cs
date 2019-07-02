using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Filters
{
    public class AdminCreateLoggerFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
            context.Result = new ContentResult() {Content = "Call from Filter" };
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}
