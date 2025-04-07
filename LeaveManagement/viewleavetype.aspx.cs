using LeaveManagement.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeaveManagement
{
    public partial class viewleavetype : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadtblleavetype();
            }
        }

        private void loadtblleavetype()
        {
            try
            {
                clsemployeee objemployee = new clsemployeee();
                DataSet ds = objemployee.getleavetype();
                grdleavetype.DataSource = ds;
                grdleavetype.DataBind();
            }
            catch
            {
                throw;
            }
        }

        protected void grdleavetype_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void buttonnext_Click(object sender, EventArgs e)
        {
            clsemployeee objemployee = new clsemployeee();
            bool isnext = objemployee.nextleaves(objemployee);
            if (isnext)
            {
                Response.Redirect("~/viewleaves.aspx");
            }
        }

        protected void grdleavetype_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EDIT")
            {
                Int64 ltid = Convert.ToInt64(e.CommandArgument);
                Response.Redirect("~/leavetype.aspx?ltid=" + ltid);
            }
        }
    }
    }
    

        