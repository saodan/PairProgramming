using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace 结对编程_课堂随机点名系统
{
    public static class studentList
    {
        
        public static Dictionary<int,string> StudentList(DataTable data)
        {
            Dictionary<int, string> stuList = new Dictionary<int, string>();
            for (int i = 1; i < data.Rows.Count; i++)
            {
                stuList.Add(i, data.Rows[i][1].ToString());
            }
            return stuList;
        }

    }
}
