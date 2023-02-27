using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Emp_Educational_Details : System.Web.UI.Page
    {
        DataClasses1DataContext _context =new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindGrid();
                bindEmployees();
            }
        }
        private void bindGrid()
        {
            try
            {
                //var data = (from edu in _context.tbl_Educational_Details
                //             join emp in _context.tbl_Employee_Masters on edu.Employee_Id equals emp.Employee_Id
                //             select new
                //             {
                //                 emp.tbl_Employee_Master.Employee_Name,
                //                 emp.Employee_Id,
                //                 edu.Education,
                //                 edu.University,
                //                 edu.Grade_Obtained,
                //                 edu.Passing_Year
                //             }).ToList(); //join query

                var data1 = (from edu in _context.tbl_Educational_Details
                             select new
                             {
                                 edu.Educational_Details_Id,
                                 edu.tbl_Employee_Master.Employee_Name,
                                 edu.Employee_Id,
                                 edu.Education,
                                 edu.University,
                                 edu.Grade_Obtained,
                                 edu.Passing_Year
                             }).ToList();
                grdEducationalDetail.DataSource = data1;
                grdEducationalDetail.DataBind();
            }
            catch(Exception ex)
            {

            }
        }
        private void bindEmployees()
        {
            try
            {
                var data=_context.Proc_tbl_Employee_Master_Select_All().ToList();

                ddlEmployee.DataSource= data;
                ddlEmployee.DataValueField = "Employee_Id";
                ddlEmployee.DataTextField = "Employee_Name";
                ddlEmployee.DataBind();
            }
            catch(Exception ex) 
            {

            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Educational_Detail detail = new tbl_Educational_Detail();
                detail.Employee_Id = Convert.ToInt32(ddlEmployee.SelectedValue);
                detail.Education = txtEducation.Text;
                detail.University= txtUniversity.Text;
                detail.Grade_Obtained = txtGradeObtained.Text;
                detail.Passing_Year = txtPassingYear.Text;
                detail.Active_Status = true;
                _context.tbl_Educational_Details.InsertOnSubmit(detail);
                _context.SubmitChanges();

                lblMessage.Text = "Record Saved Successfully";
            }
            catch(Exception ex )
            {

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int Educational_Id = Convert.ToInt32(grdEducationalDetail.SelectedValue);
                var data = _context.tbl_Educational_Details.Where(a=>a.Educational_Details_Id== Educational_Id).FirstOrDefault();
                data.Employee_Id = Convert.ToInt32(ddlEmployee.SelectedValue);
                data.Education = txtEducation.Text;
                data.University = txtUniversity.Text;
                data.Grade_Obtained = txtGradeObtained.Text;
                data.Passing_Year = txtPassingYear.Text;
                _context.SubmitChanges();
                lblMessage.Text = "Record Updated Successfully";
            }
            catch(Exception ex)
            {

            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int Educational_Id = Convert.ToInt32(grdEducationalDetail.SelectedValue);
            var data = _context.tbl_Educational_Details.Where(a => a.Educational_Details_Id == Educational_Id).FirstOrDefault();
            data.Active_Status = false;

            lblMessage.Text = "Record Deleted Successfully";
        }

        protected void grdEducationalDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Educational_Id = Convert.ToInt32(grdEducationalDetail.SelectedValue);
                var data = _context.tbl_Educational_Details.Where(a => a.Educational_Details_Id == Educational_Id).FirstOrDefault();
                ddlEmployee.SelectedValue = data.Employee_Id.ToString();
                txtEducation.Text = data.Education;
                txtGradeObtained.Text = data.Grade_Obtained;
                txtPassingYear.Text = data.Passing_Year;
                txtUniversity.Text = data.University;
            }
            catch(Exception ex )
            {

            }
        }
    }
}