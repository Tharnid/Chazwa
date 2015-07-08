using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace BootstrapBusSetup.Components
{
    public static class HtmlExtensions
    {
        public enum Html5InputTypes
        {
            text,
            color,
            date,
            datetime,
            email,
            month,
            number,
            password,
            range,
            search,
            tel,
            time,
            url,
            week
        }

        public static MvcHtmlString SubmitButton(this HtmlHelper htmlHelper,
            string buttonText,
            object htmlAttributes = null)
        {
            return SubmitButton(htmlHelper, buttonText, null, false, null, htmlAttributes);
        }

        public static MvcHtmlString SubmitButton(this HtmlHelper htmlHelper,
            string buttonText, string id,
            object htmlAttributes = null)
        {
            return SubmitButton(htmlHelper, buttonText, id, false, null, htmlAttributes);
        }

        public static MvcHtmlString SubmitButton(this HtmlHelper htmlHelper,
     string buttonText, string id, bool isDisabled, string btnClass,
     object htmlAttributes = null)
        {
            string html = string.Empty;
            string disable = string.Empty;

            if (string.IsNullOrEmpty(id))
                id = buttonText;
            if (string.IsNullOrEmpty(btnClass))
                btnClass = "btn-primary";

            // Ensure ID is a valid identifier
            id = id.Replace(" ", "").Replace("-", "_");

            html = "<input type='submit' class='btn {3}{1}' title='{0}' value='{0}' id='{2}' {4} />";
            if (isDisabled)
                disable = " disabled";

            html = string.Format(html, buttonText, disable,
                                id, btnClass,
                                GetHtmlAttributes(htmlAttributes));
            html = html.Replace("'", "\"");

            return new MvcHtmlString(html);
        }

        #region GetHtmlAttributes Method

        private static string GetHtmlAttributes(object htmlAttributes)
        {
            string ret = string.Empty;

            if (htmlAttributes != null)
            {
                var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
                foreach (var item in attributes)
                {
                    ret += " " + item.Key + "=" + "'" + item.Value + "'";
                }
            }

            return ret;
        }

        #endregion
    }
}