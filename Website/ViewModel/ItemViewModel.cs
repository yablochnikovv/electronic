using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.ViewModel
{
    public class ItemViewModel
    {
        public Guid ItemId { get; set; }
        public int CategoryId { get; set; }
        public string ItemCode { get; set; }
        public string Decription { get; set; }
        public decimal ItemPrice { get; set; }
        public HttpPostedFileBase ImagePath { get; set; }
    }
}