using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace NoteAppproject
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection conn= new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\C#\WindowsFormsApplication1\WindowsFormsApplication1\NoteAppproject\NoteAppproject\App_Data\Notes.mdf;Integrated Security=True");
           
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();

            }
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             string username = Request.Form["name"];
            string email = Request.Form["email"];
             string password = Request.Form["password"];

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;  
            cmd.CommandText="insert into users values('"+username+"','"+email+"','"+password+"')";
            cmd.ExecuteNonQuery();
          Response.Write("<script>alert('Successful');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}