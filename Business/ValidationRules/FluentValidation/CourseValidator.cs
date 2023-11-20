using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            //RuleFor(p=>p.Name).NotEmpty();
            //RuleFor(p => p.Name).MinimumLength(10);
            //RuleFor(p => p.Price).NotEmpty();
            //RuleFor(p => p.Price).GreaterThan(0);
            //RuleFor(p => p.Price).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 2).WithMessage("Hatalı");
            //RuleFor(p => p.Name).Must(StartWithA);

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
