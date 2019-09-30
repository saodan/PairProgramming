namespace 结对编程_课堂随机点名系统
{
    partial class Student
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.timerCallname = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StuAll = new System.Windows.Forms.DataGridView();
            this.Loading = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CallTheRollStop = new System.Windows.Forms.Button();
            this.CallTheRoll = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StuAll)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCallname
            // 
            this.timerCallname.Interval = 20;
            this.timerCallname.Tick += new System.EventHandler(this.timerCallname_);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StuAll
            // 
            this.StuAll.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.StuAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StuAll.GridColor = System.Drawing.SystemColors.ControlLight;
            this.StuAll.Location = new System.Drawing.Point(0, 73);
            this.StuAll.Name = "StuAll";
            this.StuAll.RowTemplate.Height = 23;
            this.StuAll.Size = new System.Drawing.Size(507, 315);
            this.StuAll.TabIndex = 0;
            // 
            // Loading
            // 
            this.Loading.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Loading.Location = new System.Drawing.Point(204, 382);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(86, 30);
            this.Loading.TabIndex = 2;
            this.Loading.Text = "载入学生名单";
            this.Loading.UseVisualStyleBackColor = false;
            this.Loading.Click += new System.EventHandler(this.Loading_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(206, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "点名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Maximum = 82;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(507, 34);
            this.progressBar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.Out);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CallTheRollStop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CallTheRoll);
            this.groupBox1.Controls.Add(this.StuAll);
            this.groupBox1.Controls.Add(this.Loading);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 477);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(416, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "学生名单";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(0, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 34);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // CallTheRollStop
            // 
            this.CallTheRollStop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CallTheRollStop.Location = new System.Drawing.Point(421, 394);
            this.CallTheRollStop.Name = "CallTheRollStop";
            this.CallTheRollStop.Size = new System.Drawing.Size(86, 30);
            this.CallTheRollStop.TabIndex = 6;
            this.CallTheRollStop.Text = "停止点名";
            this.CallTheRollStop.UseVisualStyleBackColor = false;
            this.CallTheRollStop.Click += new System.EventHandler(this.CallTheRollStop_Click);
            // 
            // CallTheRoll
            // 
            this.CallTheRoll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CallTheRoll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CallTheRoll.Location = new System.Drawing.Point(0, 394);
            this.CallTheRoll.Name = "CallTheRoll";
            this.CallTheRoll.Size = new System.Drawing.Size(86, 30);
            this.CallTheRoll.TabIndex = 5;
            this.CallTheRoll.Text = "开始点名";
            this.CallTheRoll.UseVisualStyleBackColor = false;
            this.CallTheRoll.Click += new System.EventHandler(this.CallTheRoll_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Out
            // 
            this.Out.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Out.Location = new System.Drawing.Point(424, 436);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(80, 27);
            this.Out.TabIndex = 9;
            this.Out.Text = "退出系统";
            this.Out.UseVisualStyleBackColor = false;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 478);
            this.Controls.Add(this.groupBox1);
            this.Name = "Student";
            this.Text = "课堂随机点名系统";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StuAll)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerCallname;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView StuAll;
        private System.Windows.Forms.Button Loading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button CallTheRollStop;
        private System.Windows.Forms.Button CallTheRoll;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Out;
    }
}

