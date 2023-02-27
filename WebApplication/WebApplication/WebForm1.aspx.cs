using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataClasses1DataContext _context = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowAllData();
            lblUserId.Text = Session["user_Id"].ToString();
            lblFullName.Text = Session["Full_Name"].ToString();
        }

        public void ShowAllData()
        {
            try
            {
                //var data = _context.tbl_Employee_Masters.ToList();
                var data = _context.Proc_tbl_Employee_Master_Select_All();
                grdEmployeeList.DataSource= data;
                grdEmployeeList.DataBind();
            }
            catch(Exception ex)
            {
                Error_Logger.SaveLog("Employee Master", "ShowAllData", ex.Message, ex.StackTrace);
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            /*
            string EmpName = txtEmployeeName.Text;
            string ContactNo = txtContactNo.Text;
            string Address1 = txtAddress1.Text;
            string Address2 = txtAddress2.Text;
            string email = txtEmail.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string country = txtCountry.Text;
            string ZipCode = txtZipCode.Text;

            DataClasses1DataContext _context = new DataClasses1DataContext();
            tbl_Employee_Master employee = new tbl_Employee_Master();
            employee.Employee_Name = EmpName;
            employee.Contact_No = ContactNo;
            employee.Email = email;
            employee.Address_Line1= Address1;
            employee.Address_Line2= Address2;
            employee.City = city;
            employee.State = state;
            employee.Country = country;
            employee.Zip_Code= ZipCode;
            employee.Active_Status= true;

            _context.tbl_Employee_Masters.InsertOnSubmit(employee);
            _context.SubmitChanges();
            */
            try
            {
                _context.Proc_tbl_Employee_Master_Insert_Data(txtEmployeeName.Text, txtContactNo.Text, txtEmail.Text, txtAddress1.Text, txtAddress2.Text,
                    txtCity.Text, txtState.Text, txtCountry.Text, txtZipCode.Text);

                lblMessage.Text = "Record Saved Successfully";

                ClearControls();
                ShowAllData();
            }
            catch(Exception ex)
            {
                //if (trans != null)
                //    trans.Rollback();
                lblMessage.Text = "Record is Failed to Save.";
                Error_Logger.SaveLog("Employee Master", "Save Method", ex.Message, ex.StackTrace);
            }
        }
        public void ClearControls()
        {
            txtEmployeeName.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtZipCode.Text = string.Empty;
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeId = Convert.ToInt32(grdEmployeeList.SelectedValue);
                /*
                var data = _context.tbl_Employee_Masters.Where(a => a.Employee_Id == EmployeeId).FirstOrDefault();
                data.Employee_Name= txtEmployeeName.Text;
                data.Contact_No=txtContactNo.Text;
                data.Email=txtEmail.Text;
                data.Address_Line1 = txtAddress1.Text;
                data.Address_Line2= txtAddress2.Text;
                data.City=txtCity.Text;
                data.State=txtState.Text;
                data.Country=txtCountry.Text;
                data.Zip_Code=txtZipCode.Text;
                data.Active_Status = true;

                _context.SubmitChanges();
                */

                _context.Proc_tbl_Employee_Master_Update_Data(EmployeeId, txtEmployeeName.Text, txtContactNo.Text, txtEmail.Text, txtAddress1.Text, txtAddress2.Text,
                    txtCity.Text, txtState.Text, txtCountry.Text, txtZipCode.Text);

                lblMessage.Text = "Record Updated Successfully";

                ClearControls();
                ShowAllData();
            }
            catch(Exception ex)
            {
                Error_Logger.SaveLog("Employee Master", "Update Method", ex.Message, ex.StackTrace);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeId = Convert.ToInt32(grdEmployeeList.SelectedValue);
                //var data = _context.tbl_Employee_Masters.Where(a => a.Employee_Id == EmployeeId).FirstOrDefault();
                //_context.tbl_Employee_Masters.DeleteOnSubmit(data);
                //data.Active_Status = false ; //deactivate the recprd.
                //_context.SubmitChanges();
                _context.Proc_tbl_Employee_Master_Update_Status(EmployeeId, false);
                lblMessage.Text = "Record Deactivated Successfully";

                ClearControls();
                ShowAllData();
            }
            catch(Exception ex)
            {
                Error_Logger.SaveLog("Employee Master", "Delete Method", ex.Message, ex.StackTrace);
            }
        }

        protected void grdEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int EmployeeId = Convert.ToInt32(grdEmployeeList.SelectedValue);
                //var data = _context.tbl_Employee_Masters.Where(a => a.Employee_Id == EmployeeId).FirstOrDefault();
                var data = _context.Proc_tbl_Employee_Master_Select_By_Id(EmployeeId).FirstOrDefault();
                txtEmployeeName.Text = data.Employee_Name;
                txtContactNo.Text = data.Contact_No;
                txtEmail.Text = data.Email;
                txtAddress1.Text = data.Address_Line1;
                txtAddress2.Text = data.Address_Line2;
                txtCity.Text = data.City;
                txtState.Text = data.State;
                txtCountry.Text = data.Country;
                txtZipCode.Text = data.Zip_Code;
            }
            catch (Exception ex)
            {
                Error_Logger.SaveLog("Employee Master", "grdEmployeeList_SelectedIndexChanged", ex.Message, ex.StackTrace);
            }
        }
    }
}