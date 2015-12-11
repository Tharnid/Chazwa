using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HeroicCRM.Web.Utilities;
using System.Web.Mvc;

namespace HeroicCRM.Web.Helpers
{
    public static class JsonHtmlHelpers
    {
        public static IHtmlString JsonFor<T>(this HtmlHelper helper, T obj)
        {
            return helper.Raw(obj.ToJson());
        }
    }
}