namespace 学籍管理系统
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InsestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchDefult = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchClassAndGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchFailStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.ChooseBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FindButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsestMenuItem,
            this.SearchMenuItem,
            this.DeleteMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(364, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InsestMenuItem
            // 
            this.InsestMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateInformation,
            this.UpdateGrade});
            this.InsestMenuItem.ForeColor = System.Drawing.Color.Black;
            this.InsestMenuItem.Name = "InsestMenuItem";
            this.InsestMenuItem.Size = new System.Drawing.Size(51, 24);
            this.InsestMenuItem.Text = "修改";
            // 
            // UpdateInformation
            // 
            this.UpdateInformation.Name = "UpdateInformation";
            this.UpdateInformation.Size = new System.Drawing.Size(210, 26);
            this.UpdateInformation.Text = "修改/插入基本信息";
            this.UpdateInformation.Click += new System.EventHandler(this.UpdateInformation_Click);
            // 
            // UpdateGrade
            // 
            this.UpdateGrade.Name = "UpdateGrade";
            this.UpdateGrade.Size = new System.Drawing.Size(210, 26);
            this.UpdateGrade.Text = "修改/插入学生成绩";
            this.UpdateGrade.Click += new System.EventHandler(this.UpdateGrade_Click);
            // 
            // SearchMenuItem
            // 
            this.SearchMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchDefult,
            this.SearchInformation,
            this.SearchClassAndGrade,
            this.SearchTeacher,
            this.SearchFailStudent});
            this.SearchMenuItem.ForeColor = System.Drawing.Color.Black;
            this.SearchMenuItem.Name = "SearchMenuItem";
            this.SearchMenuItem.Size = new System.Drawing.Size(51, 24);
            this.SearchMenuItem.Text = "查询";
            // 
            // SearchDefult
            // 
            this.SearchDefult.Name = "SearchDefult";
            this.SearchDefult.Size = new System.Drawing.Size(234, 26);
            this.SearchDefult.Text = "默认";
            this.SearchDefult.Click += new System.EventHandler(this.SearchDefult_Click);
            // 
            // SearchInformation
            // 
            this.SearchInformation.Name = "SearchInformation";
            this.SearchInformation.Size = new System.Drawing.Size(234, 26);
            this.SearchInformation.Text = "查询基本信息";
            this.SearchInformation.Click += new System.EventHandler(this.SearchInformation_Click);
            // 
            // SearchClassAndGrade
            // 
            this.SearchClassAndGrade.Name = "SearchClassAndGrade";
            this.SearchClassAndGrade.Size = new System.Drawing.Size(234, 26);
            this.SearchClassAndGrade.Text = "查询课程及成绩";
            this.SearchClassAndGrade.Click += new System.EventHandler(this.SearchClassAndGrade_Click);
            // 
            // SearchTeacher
            // 
            this.SearchTeacher.Name = "SearchTeacher";
            this.SearchTeacher.Size = new System.Drawing.Size(234, 26);
            this.SearchTeacher.Text = "查询历史教师";
            this.SearchTeacher.Click += new System.EventHandler(this.SearchTeacher_Click);
            // 
            // SearchFailStudent
            // 
            this.SearchFailStudent.Name = "SearchFailStudent";
            this.SearchFailStudent.Size = new System.Drawing.Size(234, 26);
            this.SearchFailStudent.Text = "查询即将被开除的学生";
            this.SearchFailStudent.Click += new System.EventHandler(this.SearchFailStudent_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteStudent});
            this.DeleteMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteMenuItem.ForeColor = System.Drawing.Color.Black;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(51, 24);
            this.DeleteMenuItem.Text = "删除";
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(216, 26);
            this.DeleteStudent.Text = "删除学生相关信息";
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAboutApplication,
            this.HelpAboutUs});
            this.HelpMenuItem.ForeColor = System.Drawing.Color.Black;
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(51, 24);
            this.HelpMenuItem.Text = "帮助";
            // 
            // HelpAboutApplication
            // 
            this.HelpAboutApplication.Name = "HelpAboutApplication";
            this.HelpAboutApplication.Size = new System.Drawing.Size(144, 26);
            this.HelpAboutApplication.Text = "关于软件";
            this.HelpAboutApplication.Click += new System.EventHandler(this.HelpAboutApplication_Click);
            // 
            // HelpAboutUs
            // 
            this.HelpAboutUs.Name = "HelpAboutUs";
            this.HelpAboutUs.Size = new System.Drawing.Size(144, 26);
            this.HelpAboutUs.Text = "关于我们";
            this.HelpAboutUs.Click += new System.EventHandler(this.HelpAboutUs_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.BackColor = System.Drawing.Color.White;
            this.FindTextBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FindTextBox.Location = new System.Drawing.Point(213, 35);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(788, 27);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.Text = "请输入“姓名”或者“学号”开始查询  注:当内容为数字串时默认为“学号”，非数字串时默认为“姓名”，请确保只输入一种";
            this.toolTip1.SetToolTip(this.FindTextBox, "点击查询按钮或者回车开始查询");
            // 
            // ResultTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.OrangeRed;
            this.ResultTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ResultTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultTable.BackgroundColor = System.Drawing.Color.Snow;
            this.ResultTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.ResultTable.EnableHeadersVisualStyles = false;
            this.ResultTable.GridColor = System.Drawing.Color.LightBlue;
            this.ResultTable.Location = new System.Drawing.Point(0, 66);
            this.ResultTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.ReadOnly = true;
            this.ResultTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ResultTable.RowHeadersVisible = false;
            this.ResultTable.RowHeadersWidth = 80;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.ResultTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ResultTable.RowTemplate.Height = 40;
            this.ResultTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultTable.ShowCellErrors = false;
            this.ResultTable.ShowEditingIcon = false;
            this.ResultTable.Size = new System.Drawing.Size(1067, 495);
            this.ResultTable.TabIndex = 4;
            // 
            // ChooseBox
            // 
            this.ChooseBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChooseBox.CausesValidation = false;
            this.ChooseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChooseBox.ForeColor = System.Drawing.Color.Black;
            this.ChooseBox.FormattingEnabled = true;
            this.ChooseBox.Items.AddRange(new object[] {
            "默认",
            "查询基本信息",
            "查询课程及成绩",
            "查询历史教师",
            "查询即将被开除学生"});
            this.ChooseBox.Location = new System.Drawing.Point(0, 35);
            this.ChooseBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChooseBox.Name = "ChooseBox";
            this.ChooseBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChooseBox.Size = new System.Drawing.Size(204, 25);
            this.ChooseBox.TabIndex = 5;
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FindButton.BackColor = System.Drawing.Color.Transparent;
            this.FindButton.BackgroundImage = global::学籍管理系统.Properties.Resources.search1;
            this.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FindButton.FlatAppearance.BorderSize = 0;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.ForeColor = System.Drawing.Color.Black;
            this.FindButton.Location = new System.Drawing.Point(1023, 34);
            this.FindButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindButton.Name = "FindButton";
            this.FindButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FindButton.Size = new System.Drawing.Size(28, 28);
            this.FindButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.FindButton, "点击执行搜索查询");
            this.FindButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.ChooseBox);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学籍管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InsestMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItem;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ToolStripMenuItem UpdateInformation;
        private System.Windows.Forms.ToolStripMenuItem UpdateGrade;
        private System.Windows.Forms.ToolStripMenuItem SearchDefult;
        private System.Windows.Forms.ToolStripMenuItem SearchInformation;
        private System.Windows.Forms.ToolStripMenuItem SearchClassAndGrade;
        private System.Windows.Forms.ToolStripMenuItem SearchTeacher;
        private System.Windows.Forms.ToolStripMenuItem SearchFailStudent;
        private System.Windows.Forms.DataGridView ResultTable;
        private System.Windows.Forms.ComboBox ChooseBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteStudent;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpAboutApplication;
        private System.Windows.Forms.ToolStripMenuItem HelpAboutUs;
    }
}

