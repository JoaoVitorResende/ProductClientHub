using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationExcpetion : ProducClientHubException
    {
        private readonly List<string> _errors;
        public ErrorOnValidationExcpetion(List<string> messageErrors) : base(string.Empty)
        {
            _errors = messageErrors;
        }
        public override List<string> GetErros() => _errors;
        public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.BadRequest;
    }
}
