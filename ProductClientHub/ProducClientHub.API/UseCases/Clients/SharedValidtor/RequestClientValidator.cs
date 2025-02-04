using FluentValidation;
using ProductClientHub.Comunication.Requests;

namespace ProducClientHub.API.UseCases.Clients.SharedValidtor
{
    public class RequestClientValidator : AbstractValidator<RequestClientJson>
    {
        public RequestClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio!");
            RuleFor(client => client.Email).EmailAddress().WithMessage("O e-mail não valido!");
        }
    }
}
