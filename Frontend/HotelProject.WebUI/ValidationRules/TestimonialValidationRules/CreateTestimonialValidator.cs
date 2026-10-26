using FluentValidation;
using HotelProject.WebUI.Dtos.TestimonialDto;
using HotelProject.WebUI.Models.Testimonial;

namespace HotelProject.WebUI.ValidationRules.TestimonialValidationRules
{
    public class CreateTestimonialValidator : AbstractValidator<CreateTestimonialDto>
    {
        public CreateTestimonialValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Referans adı soyadı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapınız");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Referans unvanı boş geçilemez");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapınız");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Lütfen en az 10 karakter açıklama giriniz");
            RuleFor(x => x.Description).MaximumLength(250).WithMessage("Lütfen en fazla 250 karakter açıklama giriniz");

            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel yolu boş geçilemez");
        }
    }
}
