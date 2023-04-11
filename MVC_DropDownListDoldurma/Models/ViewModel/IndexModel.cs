using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DropDownListDoldurma.Models.ViewModel
{
    public class IndexModel
    {
        public int SecilenSehirId { get; set; }
        public int SecilenUlkeId { get; set; }
        public SelectList SehirListesi { get; set; }
        public SelectList UlkeListesi { get; set; }
    }
}