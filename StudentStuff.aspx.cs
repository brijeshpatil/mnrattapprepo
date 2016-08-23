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
    public partial class StudentStuff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Val"] == null)
            {
               ModalPopupExtender1.Show();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "topsmnr" && txtPass.Text == "tech@$321")
            {
                Session["Val"] = "Brijesh";
                ModalPopupExtender1.Hide();
            }
            else
            {
                lblError.Text = "Invalid UserName or Password.!!";
            }
        }

        protected void btnDate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("GetAttendanceForDay", con);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@SDate", txtDate.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Remove("FkTechID");
            dt.Columns.Remove("FkPID");
            dt.Columns.Remove("PID");
            dt.Columns.Remove("TechID");
            dt.Columns.Remove("ATID");
            dt.Columns.Remove("BID");
            dt.Columns.Remove("FKBID");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}