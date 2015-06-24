using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap_TableSamples
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

    #region Submit Button Helpers
    /// <summary>
    /// Submit button helper
    /// </summary>
    /// <param name="helper">The helper</param>
    /// <param name="buttonText">The text for the button</param>
    /// <returns>String</returns>
    public static MvcHtmlString SubmitButton(this HtmlHelper helper,
      string buttonText)
    {
      return SubmitButton(helper, buttonText, null, false, null);
    }

    /// <summary>
    /// Submit button helper
    /// </summary>
    /// <param name="helper">The helper</param>
    /// <param name="buttonText">The text for the button</param>
    /// <param name="id">The id for the button</param>
    /// <returns>String</returns>
    public static MvcHtmlString SubmitButton(this HtmlHelper helper,
      string buttonText, string id)
    {
      return SubmitButton(helper, buttonText, id, false, null);
    }

    /// <summary>
    /// Submit button helper
    /// </summary>
    /// <param name="helper">The helper</param>
    /// <param name="buttonText">The text for the button</param>
    /// <param name="id">The id for the button</param>
    /// <param name="isDisabled">Set to true if you want the button disabled</param>
    /// <returns>String</returns>
    public static MvcHtmlString SubmitButton(this HtmlHelper helper,
      string buttonText, string id, bool isDisabled)
    {
      return SubmitButton(helper, buttonText, id, isDisabled, null);
    }

    /// <summary>
    /// Submit button helper
    /// </summary>
    /// <param name="helper">The helper</param>
    /// <param name="buttonText">The text for the button</param>
    /// <param name="id">The id for the button</param>
    /// <param name="isDisabled">Set to true if you want the button disabled</param>
    /// <returns>String</returns>
    public static MvcHtmlString SubmitButton(this HtmlHelper helper,
      string buttonText, string id, bool isDisabled, string btnClass, 
      object htmlAttributes = null)
    {
      string str = string.Empty;
      string disable = string.Empty;

      if (string.IsNullOrEmpty(id))
        id = buttonText;
      if (string.IsNullOrEmpty(btnClass))
        btnClass = "btn-primary";

      // Ensure ID is a valid identifier
      id = id.Replace(" ", "").Replace("-", "_");

      str = "<input type='submit' class='btn {3}{1}' title='{0}' value='{0}' id='{2}' {4} />";
      if (isDisabled)
        disable = " disabled";

      str = string.Format(str, buttonText, disable, id, btnClass, GetHtmlAttributes(htmlAttributes));
      str = str.Replace("'", "\"");

      return new MvcHtmlString(str);
    }
    #endregion

    #region TextBox for HTML 5 Helpers
    public static MvcHtmlString TextBox5For<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression)
    {
      return TextBox5For(htmlHelper, expression, Html5InputTypes.text, string.Empty, string.Empty, false, false);
    }

    public static MvcHtmlString TextBox5For<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      Html5InputTypes type)
    {
      return TextBox5For(htmlHelper, expression, type, string.Empty, string.Empty, false, false);
    }

    public static MvcHtmlString TextBox5For<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      string title)
    {
      return TextBox5For(htmlHelper, expression, Html5InputTypes.text, title, title, false, false);
    }

    public static MvcHtmlString TextBox5For<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      Html5InputTypes type,
      string title)
    {
      return TextBox5For(htmlHelper, expression, type, title, title, false, false);
    }

    public static MvcHtmlString TextBox5For<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      string title,
      bool isRequired,
      bool isAutoFocus)
    {
      return TextBox5For(htmlHelper, expression, Html5InputTypes.text, title, title, isRequired, isAutoFocus);
    }

    public static MvcHtmlString TextBox5For<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      Html5InputTypes type,
      string title,
      string placeholder,
      bool isRequired,
      bool isAutoFocus, 
      object htmlAttributes = null)
    {
      MvcHtmlString html = default(MvcHtmlString);
      Dictionary<string, object> attr = new Dictionary<string, object>();
      
      if (htmlAttributes != null)
      {
        var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
        foreach (var item in attributes)
        {
          attr.Add(item.Key, item.Value);
        }
      }

      attr.Add("type", type.ToString());
      attr.Add("class", "form-control");
      if (!string.IsNullOrEmpty(title))
      {
        attr.Add("title", title);
      }
      if (!string.IsNullOrEmpty(placeholder))
      {
        attr.Add("placeholder", placeholder);
      }
      if (isAutoFocus)
      {
        attr.Add("autofocus", "autofocus");
      }
      if (isRequired)
      {
        attr.Add("required", "required");
      }
      
      html = System.Web.Mvc.Html.InputExtensions.TextBoxFor(htmlHelper,
      expression, attr);

      return html;
    }
    #endregion

    #region CheckBox in a Button Helpers
    public static MvcHtmlString CheckBoxButtonFor<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      string id,
      string text)
    {
      return CheckBoxButtonFor(htmlHelper, expression, id, text, null, false, false);
    }

    public static MvcHtmlString CheckBoxButtonFor<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      string id,
      string text,
      string btnClass)
    {
      return CheckBoxButtonFor(htmlHelper, expression, id, text, btnClass, false, false);
    }

    public static MvcHtmlString CheckBoxButtonFor<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      string id,
      string text,
      string btnClass,
      bool isChecked,
      bool isAutoFocus, 
      object htmlAttributes = null)
    {
      StringBuilder sb = new StringBuilder(512);
      string htmlChecked = string.Empty;
      string htmlAutoFocus = string.Empty;

      if (string.IsNullOrEmpty(btnClass))
      {
        btnClass = "btn-default";
      }
      if (isChecked)
      {
        htmlChecked = "checked='checked'";
      }
      if (isAutoFocus)
      {
        htmlChecked = "autofocus='autofocus'";
      }

      // Build the CheckBox
      sb.Append("<div class='checkbox'>");
      sb.AppendFormat("  <label class='btn {0}'>", btnClass);
      sb.AppendFormat("    <input id='{0}' name='{0}' type='checkbox' value='true' {1} {2}/><input name='{0}' type='hidden' value='false' {3} />", id, htmlChecked, htmlAutoFocus, GetHtmlAttributes(htmlAttributes));
      sb.AppendFormat("    {0}", text);
      sb.Append("  </label>");
      sb.Append("</div>");

      // Return an MVC HTML String
      return MvcHtmlString.Create(sb.ToString());
    }
    #endregion

    #region Radio Button in a Button Helpers
    public static MvcHtmlString RadioButtonInButtonFor<TModel, TValue>(
          this HtmlHelper<TModel> htmlHelper,
          Expression<Func<TModel, TValue>> expression,
          string id,
          string name,
      string text,
          string value)
    {
      return RadioButtonInButtonFor(htmlHelper, expression, id, name, text, value, null, false, false);
    }

    public static MvcHtmlString RadioButtonInButtonFor<TModel, TValue>(
      this HtmlHelper<TModel> htmlHelper,
      Expression<Func<TModel, TValue>> expression,
      string id,
      string name,
      string text,
      string value,
      string btnClass,
      bool isChecked,
      bool isAutoFocus, 
      object htmlAttributes = null)
    {
      StringBuilder sb = new StringBuilder(512);
      string htmlChecked = string.Empty;
      string htmlAutoFocus = string.Empty;

      if (string.IsNullOrEmpty(btnClass))
      {
        btnClass = "btn-default";
      }
      if (isChecked)
      {
        htmlChecked = "checked='checked'";
      }
      if (isAutoFocus)
      {
        htmlChecked = "autofocus='autofocus'";
      }

      // Build the Radio Button
      sb.Append("<div class='radio'>");
      sb.AppendFormat("  <label class='btn {0}'>", btnClass);
      sb.AppendFormat("    <input id='{0}' name='{1}' type='radio' value='{2} {3} {4}' {5} />", id, name, value, htmlChecked, htmlAutoFocus, GetHtmlAttributes(htmlAttributes));
      sb.AppendFormat("    {0}", text);
      sb.Append("  </label>");
      sb.Append("</div>");

      // Return an MVC HTML String
      return MvcHtmlString.Create(sb.ToString());
    }
    #endregion

    #region GetHtmlAttributes Method
    public static string GetHtmlAttributes(object htmlAttributes)
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