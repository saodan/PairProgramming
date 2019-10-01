using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 结对编程_课堂随机点名系统
{
    public partial class Student : Form
    {
        public string filepath;
        Dictionary<int, string> stuList = new Dictionary<int, string>();
        public Student()
        {
            InitializeComponent();
        }

        public void Loading_Click(object sender, EventArgs e)
        {
            try
            {
                string path1 = @"E:/";
                filepath = path1 + System.DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString().Replace(":", "-") + "缺课名单" + ".xls";
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel(97-2003)文件|*.xls|所有文件|*.*";
                op.Title = "打开文件夹";
                string path = null;
                op.InitialDirectory = "d:\\";//最初从D盘开始查找文件，测试文件放置于本文件夹。
                op.FilterIndex = 1;
                if (op.ShowDialog() == DialogResult.OK)//判断路径是否正确
                {
                    path = op.FileName;
                }
                string name = GetExcelFile.GetFile(path);//获取Excel文件。
                string Tsql = "SELECT * FROM [" + name + "]";
                DataTable table = ExcelToDataTable.Redatatable(path, Tsql).Tables[0];//将Excel转换为dataset类型并赋值于table
                groupBox2.Show();
                progressBar1.Show();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    progressBar1.Value += 1;
                    System.Threading.Thread.Sleep(50);
                }
                StuAll.Show();
                StuAll.DataSource = table;
                Loading.Hide();
                label1.Show();
                stuList = studentList.StudentList(table);//将学生信息存储到字典中。
                CallTheRoll.Show();
                CallTheRollStop.Show();
                groupBox2.Hide();
                progressBar1.Hide();
                Out.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            label1.Hide();
            CallTheRoll.Hide();
            CallTheRollStop.Hide();
            groupBox2.Hide();
            StuAll.Hide();
            progressBar1.Hide();
            Out.Hide();
        }

        private void timerCallname_(object sender, EventArgs e)
        {
            Random random = new Random();
            int t = random.Next(1, stuList.Count + 1);
            label1.Text = stuList[t];
        }

        private void CallTheRoll_Click(object sender, EventArgs e)
        {
            timerCallname.Start();
        }

        private void CallTheRollStop_Click(object sender, EventArgs e)
        {
            timerCallname.Stop();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show(string.Format("{0}是否缺席。", label1.Text),"提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                WriteOutStu.Class1.Write(filepath, label1.Text.ToString());//将缺课学生导出为Excel文件
            }
        }

        private void Out_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("缺课名单已导出至{0}", filepath));
            Application.Exit();
        }
    }
}
