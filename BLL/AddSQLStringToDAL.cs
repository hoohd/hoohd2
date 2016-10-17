using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class AddSQLStringToDAL
    {
        public static List<string>GetDistinctString(string strTable,string str1)
        {
            string strSQl = BuilSQLDistinctString(strTable, str1);
            return DBHelper.GeiDistinceColoum(strSQl, str1);
        }
        private static string BuilSQLDistinctString(string strTableName,string str1)
        {
            return "select distinct" + str1 + "from" + strTableName;
        }
    }
}
