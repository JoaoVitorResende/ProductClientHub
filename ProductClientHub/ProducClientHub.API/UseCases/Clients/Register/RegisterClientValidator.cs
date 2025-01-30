using FluentValidation;
using ProductClientHub.Comunication.Requests;

namespace ProducClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientValidator : AbstractValidator<RequestClientJson>
    {
        public RegisterClientValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio!");
            RuleFor(client => client.Email).EmailAddress().WithMessage("O e-mail não valido!");
        }
    }
}
