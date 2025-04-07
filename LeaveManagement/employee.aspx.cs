
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
    public partial class employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string username = Convert.ToString(Session["username"]);
            labeluser.Text = "Logged in user is " + username;


            if (!IsPostBack)
            {
                if (Request.QueryString["Empid"] != null)
                {
                    hiddenempid.Value = Request.QueryString["Empid"];
                    gettlemployee(Convert.ToInt64(hiddenempid.Value));
                }
            }

            if (!IsPostBack)
            {
                loadrole();
            }
        }

        private void loadrole()
        {
            try
            {
                clsemployeee objstudent = new clsemployeee();
                DataSet ds = objstudent.getrole();
                drprole.DataValueField = Convert.ToString(ds.Tables[0].Columns["RL_ID"]);
                drprole.DataTextField = Convert.ToString(ds.Tables[0].Columns["RL_NAME"]);
                drprole.DataSource = ds.Tables[0];
                drprole.DataBind();
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
                string stremployee_name = string.Empty;
                string stremployee_compid = string.Empty;
                string stremployee_mailid = string.Empty;
                Int64 mobileno;
                string stremployee_doj = string.Empty;
                string stremployee_dol = string.Empty;
                Int64 emprole;
                string stremployee_password = string.Empty;


                if (string.IsNullOrEmpty(textname.Text))
                {
                    labelmsg.Text = "Enter the employee name ";
                    return;
                }
                if (string.IsNullOrEmpty(textcompid.Text))
                {
                    labelmsg.Text = "Enter the company id";
                    return;
                }
                if (string.IsNullOrEmpty(textmailid.Text))
                {
                    labelmsg.Text = "Enter the employee mail id ";
                    return;
                }
                if (string.IsNullOrEmpty(textmobileno.Text))
                {
                    labelmsg.Text = "Enter the mobile number";
                    return;
                }
                if (string.IsNullOrEmpty(textdoj.Text))
                {
                    labelmsg.Text = "Enter the date of join";
                    return;

                }
                if (string.IsNullOrEmpty(textdol.Text))
                {
                    labelmsg.Text = "Enter the date of leave";
                    return;

                }


                if (string.IsNullOrEmpty(textpassword.Text))
                {
                    labelmsg.Text = "Enter the password";
                    return;

                }
                if (string.IsNullOrEmpty(drprole.SelectedValue))
                {
                    labelmsg.Text = "Enter the role ";
                    return;
                }




                stremployee_name = textname.Text;
                stremployee_compid = textcompid.Text;
                stremployee_mailid = textmailid.Text;
                mobileno = Convert.ToInt64(textmobileno.Text);
                stremployee_doj = textdoj.Text;
                stremployee_dol = textdol.Text;
                emprole = Convert.ToInt64(drprole.SelectedValue);
                stremployee_password = textpassword.Text;


                clsemployeee objemployee = new clsemployeee();

                objemployee.employeename = stremployee_name;
                objemployee.employeecompid = stremployee_compid;
                objemployee.employeemailid = stremployee_mailid;
                objemployee.employeemobileno = mobileno;
                objemployee.employeedoj = stremployee_doj;
                objemployee.employeedol = stremployee_dol;
                objemployee.employeerole = emprole;
                objemployee.employeepassword = stremployee_password;


                if (buttonsave.Text == "save")
                {
                    bool issave = objemployee.savetlemployee(objemployee);

                    if (issave)
                    {
                        labelmsg.Text = "employee details saved successfully";
                        textname.Text = string.Empty;
                        textcompid.Text = string.Empty;
                        textmailid.Text = string.Empty;
                        textmobileno.Text = string.Empty;
                        textdoj.Text = string.Empty;
                        textdol.Text = string.Empty;
                        textpassword.Text = string.Empty;


                    }
                }
                else
                {
                    objemployee.employeeid = Convert.ToInt64(hiddenempid.Value);
                    bool isupdate = objemployee.updateemployee(objemployee);
                    if (isupdate)
                    {
                        labelmsg.Text = "updated succesfully";
                        textname.Text = string.Empty;
                        textcompid.Text = string.Empty;
                        textmailid.Text = string.Empty;
                        textmobileno.Text = string.Empty;
                        textdoj.Text = string.Empty;
                        textdol.Text = string.Empty;
                        textpassword.Text = string.Empty;
                        hiddenempid.Value = string.Empty;
                        buttonsave.Text = "save";
                    }
                }

            }


            catch
            {
                throw;
            }
        }
        private void gettlemployee(Int64 Empid)
        {
            try
            {
                clsemployeee objemployee = new clsemployeee();
                DataSet ds = new DataSet();
                ds = objemployee.gettlemployee(Empid);//get particular employee details

                textname.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMP_NAME"]);
                textcompid.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMP_COMP_ID"]);
                textmailid.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMP_MAILID"]);
                textmobileno.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMP_MOBILENO"]);
                textdoj.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMP_DOJ"]);
                textdol.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMP_DOL"]);
                textpassword.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMP_PASSWORD"]);
                buttonsave.Text = "update";
            }
            catch
            {
                throw;
            }
        }


        protected void buttonnext_Click1(object sender, EventArgs e)
        {
            clsemployeee objemployee = new clsemployeee();
            bool isnext = objemployee.nexttblleavetype(objemployee);
            if (isnext)
            {
                Response.Redirect("~/leavetype.aspx");
            }
        }

        protected void buttonview_Click(object sender, EventArgs e)
        {
            clsemployeee objemployee = new clsemployeee();
            bool isnext = objemployee.nexttblleavetype(objemployee);
            if (isnext)
            {
                Response.Redirect("~/viewemployee.aspx");
            }

        }
    }
}

      

     