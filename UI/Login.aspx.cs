using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        string strSQL = "select * from TabTeachers where UserID='" + TextBox1.Text + "'";
        DataTable dt = new DataTable();
        dt = LoginOperation.GetDTFromDAL(strSQL);
       
        if (dt.Rows.Count == 1)
        {
            if (TextBox3.Text == Session["ValidateCode"].ToString())
            {
                if (dt.Rows[0]["UserPWD"].ToString() == TextBox2.Text)
                {
                    Session["userid"] = dt.Rows[0]["UserID"].ToString();
                    Session["userrole"] = dt.Rows[0]["Role"].ToString();
                    Session["username"] = dt.Rows[0]["UserName"].ToString();
                    string Role = dt.Rows[0]["Role"].ToString();
                    switch (Role)
                    {
                        case "1":
                            Response.Redirect("AdminDefault.aspx");
                            break;
                        case "2":
                            Response.Redirect("AdminDefault.aspx");
                            break;
                        case "3":
                            Response.Redirect("AdminDefault.aspx");
                            break;
                        case "4":
                            Response.Redirect("AdminDefault.aspx");
                            break;

                    }
                }
                //}
                else
                {
                    Label3.Text = "密码不正确！";
                }
            }
            else
            {
                Label3.Text = "验证码错误";
            }
        }
        else
        {
            Label3.Text = "用户名不正确！";
        }
    }
    }
  