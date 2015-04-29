using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

public static class AlertCustom
{

    /// <summary> 
    /// Shows a client-side JavaScript alert in the browser. 
    /// </summary> 
    /// <param name="message">The message to appear in the alert.</param> 


    public static void ShowCustom(Page page,string message)
    {
        // Cleans the message to allow single quotation marks 
        string cleanMessage = message.Replace("'", "\\'");
        string script = "<script >alertify.alert(\"" + cleanMessage + "\" ); </script>";
        page = HttpContext.Current.CurrentHandler as Page;
        // Checks if the handler is a Page and that the script isn't allready on the Page 
        if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alertcustom"))
        {
            page.ClientScript.RegisterClientScriptBlock(typeof(AlertCustom), "alertcustom", script);
        }

    }
    public static void ShowSuccess(Page page, string message)
    {
        // Cleans the message to allow single quotation marks 
        string cleanMessage = message.Replace("'", "\\'");
        string script = "<script >alertify.success(\"" + cleanMessage + "\" ); </script>";
         page = HttpContext.Current.CurrentHandler as Page;
        // Checks if the handler is a Page and that the script isn't allready on the Page 
        if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alertcustomsuccess"))
        {
            page.ClientScript.RegisterClientScriptBlock(typeof(AlertCustom), "alertcustomsuccess", script);
        }

    }
    public static void ShowError(Page page, string message)
    {
        // Cleans the message to allow single quotation marks 
        string cleanMessage = message.Replace("'", "\\'");
        string script = "<script >alertify.error(\"" + cleanMessage + "\" ); </script>";
       page = HttpContext.Current.CurrentHandler as Page;
        // Checks if the handler is a Page and that the script isn't allready on the Page 
        if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alertcustomerror"))
        {
            page.ClientScript.RegisterClientScriptBlock(typeof(AlertCustom), "alertcustomerror", script);
        }

    }
    public static void ShowNormal(Page page, string message)
    {
        // Cleans the message to allow single quotation marks 
        string cleanMessage = message.Replace("'", "\\'");
        string script = "<script >alertify.message(\"" + cleanMessage + "\" ); </script>";
     page = HttpContext.Current.CurrentHandler as Page;
        // Checks if the handler is a Page and that the script isn't allready on the Page 
        if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alertcustomnormal"))
        {
            page.ClientScript.RegisterClientScriptBlock(typeof(AlertCustom), "alertcustomnormal", script);
        }

    }
}