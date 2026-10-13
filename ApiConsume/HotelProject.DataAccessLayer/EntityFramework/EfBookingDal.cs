using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
            
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var value = context.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
            value.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var context = new Context();
            var value = context.Bookings.Find(id);
            value.Status = "Onaylandı";
            context.SaveChanges();
        }
    }
}
