using FluentValidation;
using HotelProject.WebUI.Dtos.StaffDto;

namespace HotelProject.WebUI.ValidationRules.StaffValidationRules
{
    public class CreateStaffValidator : AbstractValidator<CreateStaffDto>
    {
        public CreateStaffValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Personel adı soyadı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapınız");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Personel unvanı boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapınız");

            RuleFor(x => x.SocialMedia1).NotEmpty().WithMessage("Sosyal medya 1 alanı boş geçilemez");
            RuleFor(x => x.SocialMedia2).NotEmpty().WithMessage("Sosyal medya 2 alanı boş geçilemez");
            RuleFor(x => x.SocialMedia3).NotEmpty().WithMessage("Sosyal medya 3 alanı boş geçilemez");
        }
    }
}
