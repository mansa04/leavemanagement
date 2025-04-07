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
    public partial class viewleaves : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadtblleave();
            }
        }

        private void loadtblleave()
        {
            try
            {
                clsemployeee objemployee = new clsemployeee();
                DataSet ds = objemployee.gettblleave();
                grdleaves.DataSource = ds;
                grdleaves.DataBind();
            }
            catch
            {
                throw;
            }
        }

        protected void grdleaves_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EDIT")
            {
                Int64 lid = Convert.ToInt64(e.CommandArgument);
                Response.Redirect("~/leaves.aspx?lid=" + lid);
            }
        }
    }
    }

   
