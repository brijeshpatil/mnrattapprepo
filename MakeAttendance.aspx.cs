using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyAttendance
{
    public partial class ListAttendance : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        MyDataClasses1DataContext db = new MyDataClasses1DataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillTechnologies();
                FillProgramList();
                FIllBranch();
                txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                txtInTime.Text = DateTime.Now.ToShortTimeString();
            }
        }

        private void FIllBranch()
        {
            da = new SqlDataAdapter("select * from BranchTbl", con);
            dt = new DataTable();
            da.Fill(dt);
            drpBranch.DataSource = dt;
            drpBranch.DataTextField = "BName";
            drpBranch.DataValueField = "BID";
            drpBranch.DataBind();
            ListItem li = new ListItem();
            li.Value = "0";
            li.Text = "Select Your Branch";
            drpBranch.Items.Insert(0, li);
        }

        private void FillProgramList()
        {
            da = new SqlDataAdapter("select * from ProgramTbl", con);
            dt = new DataTable();
            da.Fill(dt);
            ViewState["Programs"] = dt;
            drpProgram.DataSource = dt;
            drpProgram.DataTextField = "PName";
            drpProgram.DataValueField = "PID";
            drpProgram.DataBind();
            ListItem li = new ListItem();
            li.Value = "0";
            li.Text = "Select Your Program";
            drpProgram.Items.Insert(0, li);
        }

        private void FillTechnologies()
        {
            da = new SqlDataAdapter("select * from TechnologyTbl", con);
            dt = new DataTable();
            da.Fill(dt);
            drpTechnology.DataSource = dt;
            drpTechnology.DataTextField = "TechName";
            drpTechnology.DataValueField = "TechID";
            drpTechnology.DataBind();
            ListItem li = new ListItem();
            li.Value = "0";
            li.Text = "Select Your Technology";
            drpTechnology.Items.Insert(0, li);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)ViewState["Programs"];

            AttendanceTbl att = db.AttendanceTbls.SingleOrDefault(asd => asd.fname.ToLower() == txtfname.Text.ToLower() && asd.lname.ToLower() == txtlname.Text.ToLower() && asd.FkTechID == Convert.ToInt16(drpTechnology.SelectedItem.Value) && asd.FkPID == Convert.ToInt16(drpProgram.SelectedItem.Value) && asd.FKBID == Convert.ToInt16(drpBranch.SelectedItem.Value) && Convert.ToDateTime(asd.AtDate).Date == System.DateTime.Now.Date);
            if (att != null)
            {
                if (att.fname != "")
                {
                    lblDuration.Text = "<div class='alert alert-danger'><strong>Error!</strong></div>Dear,<br>" + txtfname.Text + " " + txtlname.Text + "<br/>You are already LoggedIn.<b><br/>Please logout if your practical session completed.<br/>or else Contact any one faculty.!!";
                    ModalPopupDuration.BackgroundCssClass = "popupBackRed";
                    ModalPopupDuration.Show();
                }
            }
            else
            {
                cmd = new SqlCommand("AddNewAttendance", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BID", drpBranch.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@Fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@Lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@TID", drpTechnology.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@PID", drpProgram.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@IT", txtInTime.Text);
                cmd.Parameters.AddWithValue("@OT", "");
                con.Open();
                bool status = Convert.ToBoolean(cmd.ExecuteNonQuery());
                con.Close();
                if (status)
                {
                    lblDuration.Text = "<div class='alert alert-success'><strong>Success!</strong></div>Dear,<br>" + txtfname.Text + " " + txtlname.Text + "<br/>Your InTime is <b>" + txtInTime.Text + "</b><br/>Your practical session for <b>" + dt.Rows[drpProgram.SelectedIndex - 1]["Duration"].ToString() + "</b> only!!";
                    ModalPopupDuration.BackgroundCssClass = "popupBack";
                    ModalPopupDuration.Show();
                    txtfname.Text = "";
                    txtlname.Text = "";
                    drpBranch.SelectedIndex = 0;
                    drpProgram.SelectedIndex = 0;
                    drpTechnology.SelectedIndex = 0;
                    status = false;
                }
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            txtInTime.Text = DateTime.Now.ToShortTimeString();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Logout")
            {
                cmd = new SqlCommand("update AttendanceTbl set OutTime=@OT where ATID=@ATID", con);
                cmd.Parameters.AddWithValue("@OT", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("@ATID", e.CommandArgument.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtSearch.Text = "";
                DataList1.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select AttendanceTbl.*, ProgramTbl.*, TechnologyTbl.* from AttendanceTbl inner join ProgramTbl on ProgramTbl.PID = AttendanceTbl.FkPID inner join TechnologyTbl on TechnologyTbl.TechID = AttendanceTbl.FkTechID where cast(AttendanceTbl.AtDate as date) = cast(getdate() as date) and AttendanceTbl.OutTime ='' and (AttendanceTbl.fname like '%" + txtSearch.Text + "%' or AttendanceTbl.lname like '%" + txtSearch.Text + "%') order by AttendanceTbl.ATID desc", con);
            dt = new DataTable();
            da.Fill(dt);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtfname.Text = "";
            txtlname.Text = "";
            drpProgram.SelectedIndex = 0;
            drpTechnology.SelectedIndex = 0;
            drpBranch.SelectedIndex = 0;
            ModalPopupDuration.Hide();
        }

        //protected void drpProgram_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    dt = (DataTable)ViewState["Programs"];
        //    lblPracticalDuration.Visible = true;
        //    lblPracticalDuration.Text = "Your Practical Time Will be For "+dt.Rows[drpProgram.SelectedIndex - 1]["Duration"].ToString();
        //}
    }
}