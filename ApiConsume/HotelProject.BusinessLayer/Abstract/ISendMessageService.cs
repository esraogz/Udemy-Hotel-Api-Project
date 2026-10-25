using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface ISendMessageService : IGenericService<SendMessage>
    {
        List<SendMessage> TGetInbox();
        List<SendMessage> TGetSendbox();
    }
}
