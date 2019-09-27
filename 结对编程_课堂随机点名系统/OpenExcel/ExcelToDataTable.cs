using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Data;

namespace 结对编程_课堂随机点名系统
{
    public static class ExcelToDataTable
    {
        public static DataSet Redatatable(string path,string Tsql)
        {
            DataSet ds;
            string strcon = "Provider=Microsoft.Ace.OleDb.12.0;Persist Security Info=False;" + "data source=" + path + ";Extended Properties='Excel 12.0; HDR=yes; IMEX=2'";
            OleDbConnection mycon = new OleDbConnection(strcon);
            mycon.Open();
            OleDbDataAdapter myconn = new OleDbDataAdapter(Tsql, strcon);
            ds = new DataSet();
            myconn.Fill(ds);
            mycon.Close();
            return ds;
        }
    }
}
