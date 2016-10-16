using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;
public partial class ValidateImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        //string strCode = "";
        //for (int i = 0; i < 4; i++)
        //{
        //    strCode += rd.Next(10).ToString();
        //}
        
        string[] codes = { "商务学院", "省属办公", "青年湖", "现代商务","食品科技","现代工程","会计电算","经济管理","食品工程"
                ,"机械工程","信息艺术","商务外语","建筑工程","基础教学","双师素质","明德立信","精品课程","教学团队","教学外语","教学名师"
                ,"爱心学院","绿色校园","技能学院","遗体学院","创新学院","实训中心","教学楼","高端技能","行业办公","工学交替","顶岗实习"
                ,"校企合作","工学结合","信息中心","教学研究","审计实务","投资理财","国际贸易","连锁经营","商务经纪","物流管理","粮食工程"
                ,"食品营养","粮油储藏","生物工艺","网络技术","软件开发","项目管理","网页设计","装潢艺术","广告设计","动漫设计","应用韩语"
                ,"应用英语","商务日语","数控技术","旅游管理","机电一体","港口业务","工程造价","建筑装饰","技能鉴定","兼职教师","精细管理"};
        Color[] color = { Color.Black, Color.Red, Color.Blue, Color.Brown, Color.DarkBlue };
        string[] font = { "宋体", "新宋体", "幼圆", "楷体_GB2312" };
        Random rd = new Random();
        string chkCode = codes[rd.Next(codes.Length)];
        Session["ValidataCode"] = chkCode;
        Bitmap bmp = new Bitmap(80, 20);
        /*
         * 噪点
         */
        for(int i=0;i<30;i++)
        {
            int x = rd.Next(80);
            int y = rd.Next(20);
            Color clr = color[rd.Next(color.Length)];
            bmp.SetPixel(x, y,clr);
        }
        Graphics g = Graphics.FromImage(bmp);
        g.Clear(Color.WhiteSmoke);
        int length = chkCode.Length;
        for(int i=0;i<length;i++)
        {
            string fnt = font[rd.Next(font.Length)];
            Font ft = new Font(fnt, 12);
            Color clr = color[rd.Next(color.Length)];
            g.DrawString(chkCode.ToString(), ft,new SolidBrush(clr),(float)i*20,(float)1);
            break;
        }
        //Font fnt = new Font("Times New Roman", 10, FontStyle.Bold);
        //干扰线
        for (int i = 0; i < 8; i++)
        {
                int x1 = rd.Next(80);
                int y1 = rd.Next(20);
                int x2 = rd.Next(80);
                int y2 = rd.Next(20);
                Color clr = color[rd.Next(color.Length)];
                g.DrawLine(new Pen(clr), x1, y1, x2, y2);
        }
    bmp.Save(Response.OutputStream, ImageFormat.Gif);

    }
}