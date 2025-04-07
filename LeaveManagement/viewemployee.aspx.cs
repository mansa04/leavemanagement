using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LeaveManagement.BL;

namespace LeaveManagement
{
    public partial class viewemployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loademployee();
            }
        }
        private void loademployee()
        {
            try
            {
                clsemployeee objstudent = new clsemployeee();
                DataSet ds = objstudent.getemployee();
                grdemployee.DataSource = ds;
                grdemployee.DataBind();
            }
            catch
            {
                throw;
            }
        }

        protected void grdemployee_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EDIT")
            {
                Int64 Empid = Convert.ToInt64(e.CommandArgument);
                Response.Redirect("~/employee.aspx?Empid=" + Empid);
            }
        }
    }
    }

      


