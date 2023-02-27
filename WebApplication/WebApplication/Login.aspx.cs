using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        DataClasses1DataContext _context = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var data = _context.tbl_User_Masters.Where(a=>a.Username == txtUsername.Text && a.Password == txtPassword.Text).ToList();
                if(data.Count > 0)
                {
                    Session["user_id"] = data[0].User_Id;
                    Session["Full_Name"] = data[0].Full_Name;
                    Response.Redirect("Employee_Master.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid Username or Password";
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}