using ProducClientHub.API.Entities;
using ProducClientHub.API.Infrastructure;
using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProducClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseShortClientJson Execute(RequestClientJson request)
        {
            Validate(request);
            var dbContext = new ProductClientHubDbContext();
            var entity = new Client
            {
                Email = request.Email,
                Name = request.Name,
                
            };
            dbContext.Clients.Add(entity);
            dbContext.SaveChanges();
            return new ResponseShortClientJson
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
        private void Validate(RequestClientJson request)
        {
            var validator = new RegisterClientValidator();
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                var erros = result.Errors.Select(failure => failure.ErrorMessage).ToList();
                throw new ErrorOnValidationExcpetion(erros);
            }
        }
    }
}
