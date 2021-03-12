using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
/*using Microsoft.AspNetCore.Mvc.ViewFeatures;*/
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingExceptions.Models
{
    public class CustomExceptionAttribute : IExceptionFilter
    {
        private readonly ILoggerManager logger;

        public CustomExceptionAttribute()
        {
            this.logger = new LoggerManager();
        }
        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomException" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(modelMetadata, context.ModelState);
            result.ViewData.Add("HandleException", context.Exception);
            context.Result = result;
            context.ExceptionHandled = true;
            logger.LogInformation(context.Exception.Message.ToString());
            logger.LogInformation(context.Exception.StackTrace.ToString());
        }
    }
}
