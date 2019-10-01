using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace 结对编程_课堂随机点名系统
{
    public static class GetExcelFile
    {
        public static string GetFile(string path)
        {
            string name = null;
            if (File.Exists(path))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Persist Security Info=False;" + "data source=" + path + ";Extended Properties='Excel 12.0; HDR=yes; IMEX=2'"))
                {
                    conn.Open();
                    name = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[0][2].ToString().Trim();
                }
            }
            return name;

        }
    }
}
