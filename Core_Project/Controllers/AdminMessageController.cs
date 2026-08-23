using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        string p;
        public IActionResult ReceiverMessageList()
        {
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessages(p);
            return View(values);
        }


        public IActionResult SenderMessageList()
        {
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessages(p);
            return View(values);
        }


        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }


        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.TGetByID(id);

            if (values != null)
            {
                writerMessageManager.TDelete(values);
                if (values.Receiver == "admin@gmail.com")
                {
                    return RedirectToAction(nameof(ReceiverMessageList));
                }
                else if (values.Sender == "admin@gmail.com")
                {
                    return RedirectToAction(nameof(SenderMessageList));
                }
            }
            return RedirectToAction(nameof(SenderMessageList));
        }


        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToLongDateString());
            Context c = new Context();
            var userNameSurname = c.Users.Where(x => x.Email.Equals(p.Receiver)).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = userNameSurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction(nameof(SenderMessageList));
        }
    }

}
