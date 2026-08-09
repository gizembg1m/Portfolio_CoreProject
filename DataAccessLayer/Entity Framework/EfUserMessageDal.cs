using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entity_Framework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        public List<UserMessage> GetUserMessagesWithUser()
        {
            using (var c = new Context())
            {
                return c.UserMessages.Include(x => x.User).ToList();
            }
        }    
        
    }
}
