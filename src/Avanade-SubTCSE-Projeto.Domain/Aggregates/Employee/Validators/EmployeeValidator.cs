using FluentValidation;

namespace Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("new", () => 
            {
                RuleFor(e => e.FirstName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be empty");

                RuleFor(e => e.SurName)
                .NotEmpty()
                .WithMessage("{PropertyName}  can not be empty");
            });
        }
    }
}
