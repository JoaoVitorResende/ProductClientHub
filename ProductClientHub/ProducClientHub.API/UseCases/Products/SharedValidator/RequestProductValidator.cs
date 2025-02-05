using FluentValidation;
using ProductClientHub.Comunication.Requests;

namespace ProducClientHub.API.UseCases.Products.SharedValidator
{
    public class RequestProductValidator :AbstractValidator<RequestProductJson>
    {
        public RequestProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty().WithMessage("O nome do produto não pode ser vazio!");
            RuleFor(product => product.Brand).NotEmpty().WithMessage("A marca do produto não pode ser vazio!");
            RuleFor(product => product.Price).GreaterThanOrEqualTo(0).WithMessage("O valor do produto não pode ser menor que zero!");
        }
    }
}
