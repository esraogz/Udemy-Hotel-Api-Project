using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfSendMessageDal(Context _context) : GenericRepository<SendMessage>(_context), ISendMessageDal
    {
        public List<SendMessage> GetInbox()
        {
            var values = _context.SendMessages.Where(x => x.ReceiverMail == "admin@hotelproject.com").ToList();
            return values;
        }

        public List<SendMessage> GetSendbox()
        {
            var values = _context.SendMessages.Where(x => x.SenderMail == "admin@hotelproject.com").ToList();
            return values;
        }
    }
}
