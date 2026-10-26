using FluentValidation;
using HotelProject.WebUI.Dtos.BookingDto;

namespace HotelProject.WebUI.ValidationRules.BookingValidationRules
{
    public class CreateBookingValidator : AbstractValidator<CreateBookingDto>
    {
        public CreateBookingValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad soyad alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");

            RuleFor(x => x.Checkin).NotEmpty().WithMessage("Giriş tarihi boş geçilemez");
            RuleFor(x => x.CheckOut).NotEmpty().WithMessage("Çıkış tarihi boş geçilemez");
            RuleFor(x => x.AdultCount).NotEmpty().WithMessage("Yetişkin sayısı boş geçilemez");
            RuleFor(x => x.ChildCount).NotEmpty().WithMessage("Çocuk sayısı boş geçilemez");
            RuleFor(x => x.RoomCount).NotEmpty().WithMessage("Oda sayısı boş geçilemez");
        }
    }
}