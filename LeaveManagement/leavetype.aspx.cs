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
    public partial class leavetype : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                if (Request.QueryString["ltid"] != null)
                {
                    hiddenleavetypeid.Value = Request.QueryString["ltid"];
                    getleavetype(Convert.ToInt64(hiddenleavetypeid.Value));
                }
            }
        }

        protected void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                
                string strltname = string.Empty;
                string strltdesc = string.Empty;



                if (string.IsNullOrEmpty(textltname.Text))
                {
                    labelmsg.Text = "Enter the leavetype name ";
                    return;
                }

                if (string.IsNullOrEmpty(textltdesc.Text))
                {
                    labelmsg.Text = "Enter the leavetype description ";
                    return;
                }
                strltname = textltname.Text;
                strltdesc = textltdesc.Text;


                clsemployeee objemployee = new clsemployeee();

                
                objemployee.ltname = strltname;
                objemployee.ltdesc = strltdesc;

                if (buttonsave.Text == "save")
                {
                    bool issave = objemployee.savetblleavetype(objemployee);

                    if (issave)
                    {
                        labelmsg.Text = "data saved successfully";
                        textltname.Text = string.Empty;
                        textltdesc.Text = string.Empty;
                    }

                    }
                    else
                    {
                    objemployee.ltid = Convert.ToInt64(hiddenleavetypeid.Value);
                    bool isupdate = objemployee.updatetblleavetype(objemployee);
                    if (isupdate)
                    {
                        labelmsg.Text = "updated succesfully";
                        textltname.Text = string.Empty;
                        textltdesc.Text = string.Empty;
                        hiddenleavetypeid.Value = string.Empty;
                        buttonsave.Text = "save";
                       
                    }
                }
            }

            catch
            {
                throw;
            }
        }
        private void getleavetype(Int64 ltid)
        {
            try
            {
                clsemployeee objemployee = new clsemployeee();
                DataSet ds = new DataSet();
                ds = objemployee.gettblleavetype(ltid);
                textltname.Text = Convert.ToString(ds.Tables[0].Rows[0]["LT_NAME"]);
                textltdesc.Text = Convert.ToString(ds.Tables[0].Rows[0]["LT_DESC"]);
                buttonsave.Text = "update";

            }
            catch
            {
                throw;
            }
        }
        protected void buttonnext_Click(object sender, EventArgs e)
        {
            clsemployeee objemployee = new clsemployeee();
            bool isnext = objemployee.nextleaves(objemployee);
            if (isnext)
            {
                Response.Redirect("~/leaves.aspx");
            }
        }

        protected void buttonview_Click(object sender, EventArgs e)
        {
            clsemployeee objemployee = new clsemployeee();
            bool isnext = objemployee.nextleaves(objemployee);
            if (isnext)
            {
                Response.Redirect("~/viewleavetype.aspx");
            }
    }
    }
}

       
    