using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using LeaveManagement.BL;
using System.Web.UI.WebControls;

namespace LeaveManagement
{
    public partial class leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                string emplastid = Convert.ToString(Session["empid"]);
                textlempid.Text = "" + emplastid;
           


            if (Request.QueryString["lid"] != null)
            {
                hiddenleaveempid.Value = Request.QueryString["lid"];
                getleaves(Convert.ToInt64(hiddenleaveempid.Value));
            }

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
                DataSet ds = objemployee.getleavetype();
                drpletid.DataValueField = Convert.ToString(ds.Tables[0].Columns["LT_ID"]);
                drpletid.DataTextField = Convert.ToString(ds.Tables[0].Columns["LT_NAME"]);

                drpletid.DataSource = ds.Tables[0];
                drpletid.DataBind();
            }
            catch
            {
                throw;
            }
        }

        protected void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {

                Int64 lempid;
                Int64 letid;
                string ldesc = string.Empty;
                string datefrom = string.Empty;
                string dateto = string.Empty;
                Int64 noofdays;


                if (string.IsNullOrEmpty(textlempid.Text))
                {
                    labelmsg.Text = "Enter the employee id ";
                    return;
                }
                if (string.IsNullOrEmpty(drpletid.SelectedValue))
                {
                    labelmsg.Text = "Enter the leave type id";
                    return;
                }

                if (string.IsNullOrEmpty(textldesc.Text))
                {
                    labelmsg.Text = "Enter the description ";
                    return;

                }
                if (string.IsNullOrEmpty(textdatefrom.Text))
                {
                    labelmsg.Text = "Enter the from date ";
                    return;

                }
                if (string.IsNullOrEmpty(textdateto.Text))
                {
                    labelmsg.Text = "Enter the to date ";
                    return;

                }
                if (string.IsNullOrEmpty(textnoofdays.Text))
                {
                    labelmsg.Text = "Enter the no of days ";
                    return;

                }
                lempid = Convert.ToInt64(textlempid.Text);
                letid = Convert.ToInt64(drpletid.SelectedValue);
                ldesc = textldesc.Text;
                datefrom = textdatefrom.Text;
                dateto = textdateto.Text;
                noofdays = Convert.ToInt64(textnoofdays.Text);

                clsemployeee objemployee = new clsemployeee();


                objemployee.lempid = lempid;
                objemployee.letid = letid;
                objemployee.ldesc = ldesc;
                objemployee.datefrom = datefrom;
                objemployee.dateto = dateto;
                objemployee.noofdays = noofdays;

                if (buttonsave.Text == "save")
                {
                    bool issave = objemployee.saveleaves(objemployee);

                    if (issave)
                    {
                        labelmsg.Text = "data saved successfully";
                        textlempid.Text = string.Empty;
                        textldesc.Text = string.Empty;
                        textdatefrom.Text = string.Empty;
                        textdateto.Text = string.Empty;
                        textnoofdays.Text = string.Empty;

                    }
                }
                else
                {
                    objemployee.lempid = Convert.ToInt64(hiddenleaveempid.Value);
                    bool isupdate = objemployee.updateleaves(objemployee);
                    if (isupdate)
                    {
                        labelmsg.Text = "updated succesfully";
                        textlempid.Text = string.Empty;
                        textldesc.Text = string.Empty;
                        textdatefrom.Text = string.Empty;
                        textdateto.Text = string.Empty;
                        textnoofdays.Text = string.Empty;
                        hiddenleaveempid.Value = string.Empty;
                        buttonsave.Text = "save";
                        Response.Redirect("~/viewleaves.aspx");

                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private void getleaves(Int64 Empid)

        {
            try
            {
                clsemployeee objemployee = new clsemployeee();
                DataSet ds = new DataSet();
                ds = objemployee.getleaves();//get particular employee details

                textlempid.Text = Convert.ToString(ds.Tables[0].Rows[0]["LE_EMP_ID"]);
                textldesc.Text = Convert.ToString(ds.Tables[0].Rows[0]["LE_DESC"]);
                textdatefrom.Text = Convert.ToString(ds.Tables[0].Rows[0]["LE_DATE_FROM"]);
                textdateto.Text = Convert.ToString(ds.Tables[0].Rows[0]["LE_DATE_TO"]);
                textnoofdays.Text = Convert.ToString(ds.Tables[0].Rows[0]["LE_NOOFDAYS"]);
                buttonsave.Text = "update";
            }
            catch
            {
                throw;
            }
        }

        protected void buttonback_Click(object sender, EventArgs e)
        {

            clsemployeee objemployee = new clsemployeee();
            bool isnext = objemployee.nextleavetype(objemployee);
            if (isnext)
            {
                Response.Redirect("~/leavetype.aspx");
            }
        }

        protected void buttonview_Click(object sender, EventArgs e)
        {
            clsemployeee objemployee = new clsemployeee();
            bool isnext = objemployee.nextleavetype(objemployee);
            if (isnext)
            {
                Response.Redirect("~/viewleaves.aspx");
            }
        }
    }
}

       
