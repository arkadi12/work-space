using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;



public partial class login : System.Web.UI.Page
{egr
    protected void Page_Load(object sender, EventArgs e)
    {
        lblErrorMessage.Visible = false;
    }

    protected void Btnlogin_Click(object sender, EventArgs e)
    {
        using (SqlConnection sqlCon = new SqlConnection(@"Data Source=לורה\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True"))

        {
          
                
                string query = "SELECT COUNT(1) FROM [Logintable] WHERE UserName=@UserName AND pass=@Pass";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            //try
            //{
                sqlCon.Open();
            sqlCmd.Parameters.AddWithValue("@UserName", Textusername.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Pass", Textpassword.Text.Trim());
                
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
               // Response.Write("%d",count);
                if (count == 1)
                {
                    Session["username"] = Textusername.Text.Trim();
                    Response.Redirect("Deshboard.aspx");
                }
            //}
            //catch (Exception ex)
            else { lblErrorMessage.Visible = true; }


        }

    }

}