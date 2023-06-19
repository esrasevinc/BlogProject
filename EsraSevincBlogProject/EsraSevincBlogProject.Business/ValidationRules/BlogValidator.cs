using EsraSevincBlogProject.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Business.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotNull().WithMessage("Blog başlığı boş geçilemez.");
            RuleFor(x => x.BlogDescription).NotEmpty().WithMessage("Blog içeriği boş geçilemez.");
            RuleFor(x => x.BlogDescription).MinimumLength(10).WithMessage("Minimum 100 karakter giriniz.");
        }
    }
}
