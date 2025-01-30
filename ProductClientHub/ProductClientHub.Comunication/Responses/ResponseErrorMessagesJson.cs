namespace ProductClientHub.Comunication.Responses
{
    public class ResponseErrorMessagesJson
    {
        public List<String> Errors { get; private set; }
        public ResponseErrorMessagesJson(string message)
        {
            Errors = [message];
        }
    }
}
