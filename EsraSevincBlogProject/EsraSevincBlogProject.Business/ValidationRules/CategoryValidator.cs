using EsraSevincBlogProject.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotNull().WithMessage("Kategori adı boş geçilemez.");
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Minimum 3 karakter giriniz.");
        }
    }
}
