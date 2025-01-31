using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

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
                var erros = result.Errors.Select(failure => failure.ErrorMessage).ToList();
                throw new ErrorOnValidationExcpetion(erros);
            }
            return new ResponseClientJson();
        }
    }
}
