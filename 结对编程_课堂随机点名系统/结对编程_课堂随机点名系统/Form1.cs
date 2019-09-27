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
        string filepath;
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
                filepath = path1 + System.DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString().Replace(":", "-") + "数据输出" + ".xls";
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Excel(97-2003)文件|*.xls|所有文件|*.*";
                op.Title = "打开文件夹";
                string path = null;
                op.InitialDirectory = "d:\\";
                op.FilterIndex = 1;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    path = op.FileName;
                }
                string name = GetExcelFile.GetFile(path);//获取Excel文件。
                string Tsql = "SELECT * FROM [" + name + "]";
                DataTable table = ExcelToDataTable.Redatatable(path, Tsql).Tables[0];
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
                stuList = studentList.StudentList(table);
                CallTheRoll.Show();
                CallTheRollStop.Show();
                groupBox2.Hide();
                progressBar1.Hide();
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
                WriteOutStu.Class1.Write(filepath, label1.Text.ToString());
            }
        }
    }
}
