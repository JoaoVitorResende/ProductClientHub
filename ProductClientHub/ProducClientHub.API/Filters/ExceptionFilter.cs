using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductClientHub.Comunication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProducClientHub.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is ProducClientHubException producClientHubException)
            {
                context.HttpContext.Response.StatusCode = (int)producClientHubException.GetHttpStatusCode();
                context.Result = new ObjectResult(new ResponseErrorMessagesJson(producClientHubException.GetErros()));
            }
            else
            {
                ThrowUnknowError(context);
            }
        }
        private void ThrowUnknowError(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(new ResponseErrorMessagesJson("Erro desconhecido"));
        }
    }
}
