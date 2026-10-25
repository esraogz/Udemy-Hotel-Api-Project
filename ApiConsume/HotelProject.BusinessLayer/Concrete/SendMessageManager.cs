using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SendMessageManager(ISendMessageDal _sendMessageDal) : ISendMessageService
    {
        public void TDelete(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public SendMessage TGetById(int id)
        {
            return _sendMessageDal.GetById(id);
        }

        public List<SendMessage> TGetInbox()
        {
            return _sendMessageDal.GetInbox();
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessageDal.GetList();
        }

        public List<SendMessage> TGetSendbox()
        {
            return _sendMessageDal.GetSendbox();
        }

        public void TInsert(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public void TUpdate(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
