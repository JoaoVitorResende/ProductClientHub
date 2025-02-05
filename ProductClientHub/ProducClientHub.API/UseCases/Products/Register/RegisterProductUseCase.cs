using ProducClientHub.API.Entities;
using ProducClientHub.API.Infrastructure;
using ProducClientHub.API.UseCases.Products.SharedValidator;
using ProductClientHub.Comunication.Requests;
using ProductClientHub.Comunication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProducClientHub.API.UseCases.Products.Register
{
    public class RegisterProductUseCase
    {
        public ResponseShortProductJson Execute(Guid clientId, RequestProductJson request)
        {
            var dbContext = new ProductClientHubDbContext();
            Validate(request, clientId, dbContext);
            var entity = new Product
            {
                Name = request.Name,
                Brand = request.Brand,
                Price = request.Price,
                ClientId = clientId
            };
            dbContext.Products.Add(entity);
            dbContext.SaveChanges();
            return new ResponseShortProductJson
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }
        private void Validate(RequestProductJson request, Guid clientId, ProductClientHubDbContext dbContext)
        {
            var clientExists = dbContext.Clients.Any(client => client.Id == clientId);
            if (!clientExists)
                throw new NotFoundException("Cliente não existe");
            var validator = new RequestProductValidator();
            var result = validator.Validate(request);
            if (!result.IsValid) 
            {
                var erros = result.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ErrorOnValidationExcpetion(erros);
            }
        }
    }
}
