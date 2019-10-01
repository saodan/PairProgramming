using Microsoft.VisualStudio.TestTools.UnitTesting;
using WriteOutStu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using 结对编程_课堂随机点名系统;
using WriteOutStu;
using System.Windows.Forms;


namespace WriteOutStu.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void WriteTest()
        {
            Student s = new Student();
            s.Loading_Click(null, EventArgs.Empty);
            WriteOutStu.Class1.Write(s.filepath, "廖志丹");
            StreamReader sr = new StreamReader(s.filepath,Encoding.Default);
            string str = sr.ReadToEnd();
            Assert.AreEqual(str, "廖志丹\t缺席\n");
        }
    }
}