using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace UnitConverter.Filters
{
    public class ConverterActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var parameter = context.ActionArguments
                .Where(c => c.Key.Equals("input"))
                .Select(c => c.Value)
                .FirstOrDefault() ?? string.Empty;

            if (!Decimal.TryParse(parameter.ToString(), out _))
                context.Result = new BadRequestObjectResult("Wrong parameter value");

            base.OnActionExecuting(context);
        }
    }
}
