using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LeaveManagement.BL;
using System.Data;
namespace LeaveManagement
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                clsemployeee obj = new clsemployeee();

                string mailid = string.Empty;

                string password = string.Empty;

                if (string.IsNullOrEmpty(textmailid.Text))

                {
                    labelmsg.Text = "Enter the mailid";
                    return;

                }

                if (string.IsNullOrEmpty(textpassword.Text))

                {

                    labelmsg.Text = "Enter the password";
                    return;

                }

                mailid = textmailid.Text;
                password = textpassword.Text;
                obj.employeemailid = mailid;
                obj.employeepassword = password;

                DataSet ds = obj.checklogin(obj);
                if (ds.Tables[0].Rows.Count>0)

                {
                    Session["empid"] = Convert.ToString(ds.Tables[0].Rows[0]["EMP_ID"]);
                    Session["username"] = textmailid.Text;
                    Response.Redirect("~/employee.aspx");

                }

                else

                {
                    labelmsg.Text = "Invalid login";

                }

            }

            catch

            {
                throw;


            }
        }
    }
}