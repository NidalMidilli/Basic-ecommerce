using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.categoryName).NotEmpty().WithMessage("Category name cant be empty")
                                        .MinimumLength(3).WithMessage("Category name must be greater than 3")
                                        .MaximumLength(30).WithMessage("Category name must be less than 30");
        }
    }
}
