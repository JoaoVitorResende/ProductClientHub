namespace ProductClientHub.Comunication.Responses
{
    public class ResponseErrorMessagesJson
    {
        public List<String> Errors { get; private set; }
        public ResponseErrorMessagesJson(string message) => Errors = [message];
        public ResponseErrorMessagesJson(List<string> messages) => Errors = messages;
    }
}
