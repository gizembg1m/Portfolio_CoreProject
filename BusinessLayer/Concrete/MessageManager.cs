using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }

}