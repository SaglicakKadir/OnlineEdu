using FluentValidation;
using OnlineEdu.WebUI_.DTOs.BlogCategoryDtos;

namespace OnlineEdu.WebUI_.Validators
{
    public class BlogCategoryValidator:AbstractValidator<CreateBlogCategoryDto>
    {
        public BlogCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Blog Kategori adı boş bırakılamaz!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karakter olmalıdır!");
        }
    }
}
