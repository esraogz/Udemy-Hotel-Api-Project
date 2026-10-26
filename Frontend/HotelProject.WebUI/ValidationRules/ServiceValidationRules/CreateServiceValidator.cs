using FluentValidation;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.ValidationRules.ServiceValidationRules
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceDto>
    {
        public CreateServiceValidator()
        {
            RuleFor(x => x.ServiceIcon).NotEmpty().WithMessage("Hizmet ikon linki boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Hizmet başlığı boş geçilemez");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Hizmet başlığı en fazla 100 karakter olabilir");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Hizmet açıklaması boş geçilemez");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Hizmet açıklaması en fazla 200 karakter olabilir");
        }
    }
}