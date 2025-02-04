using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public class NotFoundException : ProducClientHubException
    {
        public NotFoundException(string messageError) : base(messageError)
        {
        }
        public override List<string> GetErros() => [Message];
        public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.NotFound;
    }
}
