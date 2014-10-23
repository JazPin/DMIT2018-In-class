using eRestaurant.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrontDesk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void MockLastBillingDateTime_Click(object sender, EventArgs e)
    {
        MessageUserControl.TryRun(SetMockedTimeToLastBill);
    }
    private void SetMockedTimeToLastBill()
    {
        var controller = new AdhocController();
        var info = controller.LastBillDate();
        // formatting date for use in an <input type="date"> HTML5 control
        SearchDate.Text = info.ToString("yyyy-MM-dd"); 
        // formatting time for use in an <input type="time"> HTML5 control
        SearchTime.Text = info.ToString("HH:mm:ss");// HH 24 hr clock, hh 12hr clock
    }
}