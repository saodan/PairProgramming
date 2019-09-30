using Microsoft.VisualStudio.TestTools.UnitTesting;
using 结对编程_课堂随机点名系统;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace 结对编程_课堂随机点名系统.Tests
{
    [TestClass()]
    public class studentListTests
    {
        [TestMethod()]
        public void StudentListTest()
        {
            DataTable table = new DataTable();
            DataColumn column = new DataColumn(" ");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 1;
            column.AutoIncrementStep = 1;
            column.AllowDBNull = false;
            table.Columns.Add("学号", Type.GetType("System.String"));
            table.Columns.Add("姓名", Type.GetType("System.String"));
            table.Rows.Add("2016", "王川");
            table.Rows.Add("2017", "廖志丹");
            Assert.AreEqual(studentList.StudentList(table)[1], "廖志丹");
        }
    }

}