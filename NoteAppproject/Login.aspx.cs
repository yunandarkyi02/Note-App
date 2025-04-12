using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace NoteAppproject
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\C#\WindowsFormsApplication1\WindowsFormsApplication1\NoteAppproject\NoteAppproject\App_Data\Notes.mdf;Integrated Security=True");
           
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = Txtusername.Text;
           // string password = Txtpassword.Text;
            conn.Open();
            string checkuser = "select  count(*) from users where name='" + username + "'";
            SqlCommand con = new SqlCommand(checkuser, conn);
           int temp = Convert.ToInt32(con.ExecuteScalar().ToString());
            conn.Close();
            if (temp==1)
            {
                conn.Open();
                string checkpassword = "select password from users where name='" + username + "'";
                SqlCommand conpass = new SqlCommand(checkpassword, conn);
                string password = conpass.ExecuteScalar().ToString();
                if (password == Txtpassword.Text)
                {
                    Session["New"] = username;
                    Response.Write("Password is Correct");

                }
                else
                {
                    Response.Write("Password is Not Correct");
                }

            }
            else
            {
                Response.Write("User Name is Not Correct");
            }
        }
    }
}