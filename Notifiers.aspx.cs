using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Notifiers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void notify_btn_Click(object sender, EventArgs e)
    {
        AlertCustom.ShowSuccess(this.Page, "Hello Success Notifier!");
    }
    protected void err_notify_btn_Click(object sender, EventArgs e)
    {
        AlertCustom.ShowError(this.Page, "Hello Error Notifier!");
    }
    protected void simple_notify_btn_Click(object sender, EventArgs e)
    {
        AlertCustom.ShowNormal(this.Page, "Hello Simple Notifier!");
    }
}