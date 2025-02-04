using ProducClientHub.API.Infrastructure;
using ProducClientHub.API.UseCases.Clients.SharedValidtor;
using ProductClientHub.Comunication.Requests;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProducClientHub.API.UseCases.Clients.Update
{
    public class UpdateClientUseCasecs
    {
        public void Execute(Guid id, RequestClientJson request)
        {
            Validate(request);
            var dbContext = new ProductClientHubDbContext();
            var entity = dbContext.Clients.FirstOrDefault(client => client.Id == id);
            if (entity == null)
                throw new NotFoundException("Client não encontrado");
            entity.Name = request.Name;
            entity.Email = request.Email;
            dbContext.Clients.Update(entity);
            dbContext.SaveChanges();
        }
        private void Validate(RequestClientJson request)
        {
            var validator = new RequestClientValidator();
            var result = validator.Validate(request);
            if(!result.IsValid)
            {
                var erros = result.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ErrorOnValidationExcpetion(erros);
            }
        }
    }
}
