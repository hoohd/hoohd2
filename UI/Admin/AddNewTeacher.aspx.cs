using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using System.Collections.Generic;
using BLL;
public partial class Admin_AddNewTeacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userid"].ToString()!="")
        {
            Bind();
        }
        else
        {
            Response.Redirect("~/Default.aspx");//这个地方不太明白是不是要新建个网页还是Addteachers。aspx的某种形态
        }
    }
    protected void Bind()
    {
        List<string> str = new List<string>();
        str = AddSQLStringToDAL.GetDistinctString("TabTeachers", "Department");
        for (int i = 0; i < str.Count; i++)
        {
            DropDownList2.Items.Add(str[i].ToString());
        }
    }
}