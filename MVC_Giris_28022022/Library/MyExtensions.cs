using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Giris_28022022.Library
{
    public static class MyExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper,string id,ButonTip tip,string text)
        {
            string buton = string.Format("<button id='{0}' name='{0}' type='{1}'>{2}</button>",id,tip,text);
            return MvcHtmlString.Create(buton);
        }

        public enum ButonTip
        {
            button=0,
            submit=1,
            reset=2
        }
    }
}