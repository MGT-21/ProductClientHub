using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Register;

public class RegisterClientValidator : AbstractValidator<RequestClientJson>
{
    public RegisterClientValidator()
    {
        RuleFor(client => client.Name).NotEmpty().WithMessage("O nome do cliente é obrigatório.");
        RuleFor(client => client.Email).NotEmpty().WithMessage("O email é obrigatório.");
       
    }
}
