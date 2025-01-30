using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;

namespace ProducClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseClientJson Execute(RequestClientJson request)
        {
            var validator = new RegisterClientValidator();
            var result = validator.Validate(request);
            if(!result.IsValid)
            {
                throw new ArgumentException("erro nos dados recebidos");
            }
            return new ResponseClientJson();
        }
    }
}
