﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace Day_1_Demo.Filters
{
    public class MyFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("OnActionExecuting");
        }
    }
}
