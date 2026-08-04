using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectUrl { get; set; }
        public string ImageUrl2 { get; set; }
        public string? ImageUrl3 { get; set; }
        public string? ImageUrl4 { get; set; }
        public string Platform { get; set; }
        public string Price { get; set; }
        public int Value { get; set; }
        public bool Status { get; set; }


    }

}
