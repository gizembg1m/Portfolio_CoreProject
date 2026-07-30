using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public bool Status { get; set; }
    }
}
