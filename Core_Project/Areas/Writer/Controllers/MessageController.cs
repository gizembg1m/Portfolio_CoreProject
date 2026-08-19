using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }


       
       
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            WriterUser values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            List<WriterMessage> messageList = writerMessageManager.GetListReceiverMessages(p);
            return View(messageList);
        }


        
       
        public async Task<IActionResult> SenderMessage(string p)
        {
            WriterUser values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            List<WriterMessage> messageList = writerMessageManager.GetListSenderMessages(p);
            return View(messageList);
        }




    }
}
