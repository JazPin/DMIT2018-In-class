using eRestaurant.BLL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageWaiters : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // TODO : List he waiters in the dropdown list
        }
    }
    protected void Add_Click(object sender, EventArgs e)
    {
        MessageUserControl.TryRun(AddWaiter, "Added waiter", "The new Waiter was successfully added");
    }
    public void AddWaiter()
    {
        Waiter person = new Waiter()
        {
            FirstName = FirstName.Text,
            LastName = LastName.Text,
            Address = Address.Text,
            Phone = Phone.Text,
            HireDate = DateTime.Parse(HireDate.Text),
        };
        DateTime fireOn;
        if (DateTime.TryParse(ReleaseDate.Text, out fireOn))
            person.ReleaseDate = fireOn;
        var controller = new RestaurantAdminController();
        person.WaiterID = controller.AddWaiter(person);
        WaiterID.Text = person.WaiterID.ToString();
        //TODO: Re-populate dropdown list of waiters and set the selectedvalue as well
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        int temp;
        if (int.TryParse(WaiterID.Text, out temp))
        {
            MessageUserControl.TryRun(UpdateWaiter, "Update Successed", "The waiter information was updated.");
        }
        else
            MessageUserControl.ShowInfo("Please lookup a waiter before clicking 'Update'.");
    }
    public void UpdateWaiter()
    {
        Waiter person = new Waiter()
        {
            WaiterID = int.Parse(WaiterID.Text),
            FirstName = FirstName.Text,
            LastName = LastName.Text,
            Address = Address.Text,
            Phone = Phone.Text,
            HireDate = DateTime.Parse(HireDate.Text),
        };
        DateTime fireOn;
        if (DateTime.TryParse(ReleaseDate.Text, out fireOn))
            person.ReleaseDate = fireOn;
        var controller = new RestaurantAdminController();
        controller.UpdateWaiter(person);
        //WaiterID.Text = person.WaiterID.ToString();
        //TODO: Re-populate dropdown list of waiters and set the selectedvalue as well
    }
}