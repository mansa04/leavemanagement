using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LeaveManagement.BL;

namespace LeaveManagement.BL
{
    public class clsemployeee
    {
        public Int64 employeeid { get; set; }
        public string employeename { get; set; }
        public string employeecompid { get; set; }
        public string employeemailid { get; set; }
        public Int64 employeemobileno { get; set; }
        public string employeedoj { get; set; }
        public string employeedol { get; set; }
        public Int64 employeerole { get; set; }
        public string employeepassword { get; set; }

        public Int64 ltid { get; set; }
        public string ltname { get; set; }
        public string ltdesc { get; set; }

        public Int64 lid { get; set; }
        public Int64 lempid { get; set; }
        public Int64 letid { get; set; }
        public string ldesc { get; set; }
        public string datefrom { get; set; }
        public string dateto { get; set; }
        public Int64 noofdays { get; set; }

        clsDbConnector objcon = new clsDbConnector();

        public bool savetlemployee(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                strqry = " insert into TLEMPLOYEE values('" + objemployee.employeename + "','" + objemployee.employeecompid + "','" + objemployee.employeemailid + "','" + objemployee.employeemobileno + "','" + objemployee.employeedoj + "','" + objemployee.employeedol + "','" + objemployee.employeerole + "','" + objemployee.employeepassword + "')";
                bool issave = objcon.runSQL(strqry);
                return issave;

            }

            catch
            {
                throw;
            }
        }
        public bool nexttlemployee(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                bool isnext = true;
                return isnext;
            }
            catch
            {
                throw;
            }
        }
        public bool savetblleavetype(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                strqry = "insert into TBLLEAVETYPE values('" + objemployee.ltname + "','" + objemployee.ltdesc + "')";
                bool issave = objcon.runSQL(strqry);
                return issave;
            }
            catch
            {
                throw;
            }
        }
        public bool nexttblleavetype(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                bool isnext = true;
                return isnext;
            }
            catch
            {
                throw;
            }
        }
        public bool saveleaves(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                string strqry1 = string.Empty;
                strqry = "insert into TBLLEAVES values('" + objemployee.lempid + "','" + objemployee.letid + "','" + objemployee.ldesc + "','" + objemployee.datefrom + "','" + objemployee.dateto + "','" + objemployee.noofdays + "')";
                bool issave = objcon.runSQL(strqry);
                return issave;
            }
            catch
            {
                throw;
            }
        }
        public DataSet checklogin(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                strqry = "select * from TLEMPLOYEE where EMP_MAILID='" + objemployee.employeemailid + "' and EMP_PASSWORD='" + objemployee.employeepassword + "' ";
                DataSet ds = objcon.GetDataSet(strqry);
                return ds;

            }
            catch
            {
                throw;
            }
        }
        public DataSet getrole()
        {
            try
            {
                string strqry = string.Empty;
                strqry = "select RL_ID,RL_NAME from TBLROLE";
                DataSet ds = objcon.GetDataSet(strqry);
                return ds;
            }
            catch
            {
                throw;
            }
        }
        public DataSet getleaves()
        {
            try
            {
                string strqry = string.Empty;
                strqry = "select LE_ID,LE_EMP_ID,LE_LT_ID,LE_DESC,LE_DATE_FROM,LE_DATE_TO,LE_NOOFDAYS from TBLLEAVES";
                DataSet ds = objcon.GetDataSet(strqry);
                return ds;
            }
            catch
            {
                throw;
            }
        }

        public DataSet getemployee()
        {
            try
            {
                string strqry = string.Empty;
                strqry = "select EMP_ID,EMP_NAME,EMP_COMP_ID,EMP_MAILID,EMP_MOBILENO,EMP_DOJ,EMP_DOL,EMP_ROLEID,EMP_PASSWORD,RL_ID,RL_NAME from [leavedatabase].[dbo].[TLEMPLOYEE] E inner join [leavedatabase].[dbo].[TBLROLE] R on R.RL_ID=E.EMP_ROLEID";
                DataSet ds = objcon.GetDataSet(strqry);
                return ds;
            }
            catch
            {
                throw;
            }
        }
        public DataSet getleavetype()
        {
            try
            {
                string strqry = string.Empty;
                strqry = "select LT_ID,LT_NAME,LT_DESC from TBLLEAVETYPE";
                DataSet ds = objcon.GetDataSet(strqry);
                return ds;
            }
            catch
            {
                throw;
            }
        }
        public DataSet gettblleavetype(Int64 Etid)
        {
            try
            {
                string strqry = string.Empty;
                strqry = "select LT_ID,LT_NAME,LT_DESC from TBLLEAVETYPE where LT_ID = '" + ltid + "' ";
                DataSet ds = objcon.GetDataSet(strqry);
                return ds;
            }
            catch
            {
                throw;
            }
        }
        public DataSet gettblleave()
        {
            try
            {
                string strqry = string.Empty;
                strqry = "select LE_ID,LE_EMP_ID,LE_LT_ID,LE_DESC,LE_DATE_FROM,LE_DATE_TO,LE_NOOFDAYS,EMP_NAME,EMP_COMP_ID,EMP_MAILID,EMP_MOBILENO,EMP_DOJ,EMP_DOL,EMP_ROLEID,EMP_PASSWORD from [leavedatabase].[dbo].[TBLLEAVES] TL inner join [leavedatabase].[dbo].[TBLLEAVETYPE] LT on LT.LT_ID=TL.LE_LT_ID inner join [leavedatabase].[dbo].[TLEMPLOYEE] E on E.EMP_ID=TL.LE_EMP_ID";
                DataSet ds = objcon.GetDataSet(strqry);
                return ds;
            }
            catch
            {
                throw;
            }
        }
        public bool nextleavetype(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                bool isnext = true;
                return isnext;
            }
            catch
            {
                throw;
            }
        }
        public bool nextleaves(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                bool isnext = true;
                return isnext;
            }
            catch
            {
                throw;
            }
        }



        public bool updatetblleavetype(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                strqry = "update TBLLEAVETYPE set  LT_NAME='" + objemployee.ltname + "',LT_DESC='" + objemployee.ltdesc + "', where LT_ID='" + objemployee.ltid + "' ";
                bool isupdate = objcon.runSQL(strqry);
                return isupdate;
            }
            catch
            {
                throw;
            }

        }

     

      
      
        public bool updateleaves(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                strqry = "update TBLLEAVES set  LE_EMP_ID='" + objemployee.lempid + "',LE_LT_ID='" + objemployee.letid + "',LE_DESC='" + objemployee.ldesc + "',LE_DATE_FROM='" + objemployee.datefrom + "',LE_DATE_TO='" + objemployee.dateto + "',LE_NOOFDAYS='" + objemployee.noofdays + "' where LE_ID='" + objemployee.lid + "' ";
                bool isupdate = objcon.runSQL(strqry);
                return isupdate;
            }
            catch
            {
                throw;
            }

        }
        public bool updateemployee(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                strqry = "update TLEMPLOYEE set EMP_NAME='" + objemployee.employeename + "',EMP_COMP_ID='" + objemployee.employeecompid + "',EMP_MAILID='" + objemployee.employeemailid + "',EMP_MOBILENO='" + objemployee.employeemobileno + "',EMP_DOJ='" + objemployee.employeedoj + "',EMP_DOL='" + objemployee.employeedol + "',EMP_PASSWORD='" + objemployee.employeepassword + "',EMP_ROLEID='" + objemployee.employeerole + "' where EMP_ID='" + objemployee.employeeid + "' ";
                bool isupdate = objcon.runSQL(strqry);
                return isupdate;
            }
            catch
            {
                throw;
            }

        }
       
      

        public bool nexttblleave(clsemployeee objemployee)
        {
            try
            {
                string strqry = string.Empty;
                bool isnext = true;
                return isnext;
            }
            catch
            {
                throw;
            }
        }

        public DataSet gettlemployee(Int64 Empid)
        {
            try
            {
                string strqry = string.Empty;
                strqry = "select EMP_ID,EMP_NAME,EMP_COMP_ID,EMP_MAILID,EMP_MOBILENO,EMP_DOJ,EMP_DOL,EMP_ROLEID,EMP_PASSWORD from TLEMPLOYEE where EMP_ID = '" + Empid + "' ";
                DataSet ds = objcon.GetDataSet(strqry);
                return ds;
            }
            catch
            {
                throw;
            }
        }
    }
}



    


