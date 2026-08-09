using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IUserMessageService: IGenericService<UserMessage>
    {
        List<UserMessage> GetUserMessagesWithUserService();
    }
}
