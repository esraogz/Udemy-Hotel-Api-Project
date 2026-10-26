using FluentValidation;
using HotelProject.WebUI.Dtos.RoomDto;

namespace HotelProject.WebUI.ValidationRules.RoomValidationRules
{
    public class UpdateRoomValidator : AbstractValidator<UpdateRoomDto>
    {
        public UpdateRoomValidator()
        {
            RuleFor(x => x.RoomNumber).NotEmpty().WithMessage("Oda Numarası alanı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Oda başlığı alanı boş geçilemez");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");
            RuleFor(x => x.BathCount).NotEmpty().WithMessage("Banyo sayısı alanı boş geçilemez");
            RuleFor(x => x.BedCount).NotEmpty().WithMessage("Banyo sayısı alanı boş geçilemez");
            RuleFor(x => x.Wifi).NotEmpty().WithMessage("Wifi alanı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter veri girişi yapınız");
        }
    }
}
