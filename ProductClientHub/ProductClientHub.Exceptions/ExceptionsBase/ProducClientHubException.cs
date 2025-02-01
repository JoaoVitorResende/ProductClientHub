using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public abstract class ProducClientHubException : SystemException
    {
        public ProducClientHubException(string messageError) :base(messageError) {}
        public abstract List<string> GetErros();
        public abstract HttpStatusCode GetHttpStatusCode();
    }
}
