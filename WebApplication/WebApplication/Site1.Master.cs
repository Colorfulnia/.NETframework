using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblUserId.Text = Session["user_Id"].ToString();
                lblFullName.Text = Session["Full_Name"].ToString();
            }
            catch(Exception ex)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Remove("user_Id");
                Session.Remove("Full_Name");
                Response.Redirect("Login.aspx");
            }
            catch(Exception ex)
            {

            }
        }
    }
}