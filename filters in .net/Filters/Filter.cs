using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc.Filters;

namespace filters_in_.net.Filters
{
    public class Filter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var para = context.ActionArguments["para"];
            Console.WriteLine(para);
           
           
        }
        


    }
}
