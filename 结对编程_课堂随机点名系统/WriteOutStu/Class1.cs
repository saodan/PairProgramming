using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;


namespace WriteOutStu
{
    public static class Class1
    {
        public static void Write(string Path,string str)
        {
            
            FileStream datafile = new FileStream(Path, FileMode.Append, FileAccess.Write);
            string data = string.Format("{0}\t缺席\n",str);
            StreamWriter writer = new StreamWriter(datafile, Encoding.GetEncoding("gb2312"));
            writer.Write(data);
            writer.Flush();
            writer.Close();
        }
    }
}
