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
    
    public partial class Notes : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\C#\WindowsFormsApplication1\WindowsFormsApplication1\NoteAppproject\NoteAppproject\App_Data\Notes.mdf;Integrated Security=True");
           
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();

            }
            conn.Open();
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            string title= Request.Form["title"];
            string notes = Request.Form["notes_input"];
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into notes values('"+ title+ "','" + notes+ "')";
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Successful');</script>");
        }
    }
}