using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace 学籍管理系统
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Init();           
        }

        /// <summary>
        /// 初始化各项参数以及事件绑定
        /// </summary>
        private void Init()
        {
            //将初始焦点聚集在搜索按钮上
            this.FindButton.Select();

            //设置选择按钮
            ChooseBox.SelectedIndex = 0;
            ChooseBox.TextChanged += ChooseBox_TextChanged;

            //设置编辑框
            FindTextBox.GotFocus += SetFindTextBoxFocus;
            FindTextBox.LostFocus += SetFindTextBoxunfocus;
            FindTextBox.KeyDown += FindTextBox_KeyDown;
            FindButton.Click += FindButton_Click;

            ResultTable.DataSource = ReadDatabase.GetData("Default");//显示学生基本信息            
        }


        /// <summary>
        /// 文本框回车引发搜索功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                FindButton.PerformClick();
            }
        }
    

        /// <summary>
        /// 查询搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            //正在测试的，显示表格
            string keyword = FindTextBox.Text.Replace(" ","");
            InformationType DataType;
            if (keyword == ""||keyword== @"请输入“姓名”或者“学号”开始查询  注:当内容为数字串时默认为“学号”，非数字串时默认为“姓名”，请确保只输入一种".Replace(" ","")||keyword== "此功能不支持关键字查询，请检查功能按钮状态".Replace(" ",""))
            {
                DataType = InformationType.none;
            }
            else if (Judge.JudgeChars(keyword))
            {
                DataType = InformationType.id;
            }            
            else
            {
                DataType = InformationType.name;
            }

            DataTable result=null;
            //if (FindTextBox.Text.ToLower() == "Test".ToLower() || FindTextBox.Text == "测试")
            //{
            //    result = ReadDatabase.GetData("Test");
            //    ResultTable.DataSource = result;
            //    return;
            //}

            if (FindTextBox.Text == ""|| FindTextBox.Text == @"请输入“姓名”或者“学号”开始查询  注:当内容为数字串时默认为“学号”，非数字串时默认为“姓名”，请确保只输入一种")
            {
                if (ChooseBox.Text == "默认")
                {
                    result = ReadDatabase.GetData("Default");//显示学生基本信息
                    ResultTable.DataSource = result;
                    ResultTable.Columns[0].Width = 100;
                }
                else
                {
                    MessageBox.Show("请输入查询关键字(姓名或者学号)");
                }
                return;
            }

            //执行查询操作，获取数据表
            if (ChooseBox.Text== "默认")//查询某个同学。。。。。
            {
                result = ReadDatabase.GetData("Default",keyword,DataType);
            }
            else if(ChooseBox.Text == "查询基本信息")
            {
                result = ReadDatabase.GetData("Information",keyword,DataType);
            }
            else if (ChooseBox.Text == "查询课程及成绩")
            {
                result = ReadDatabase.GetData("ClassAndGrade",keyword,DataType);
            }
            else if (ChooseBox.Text == "查询历史教师")
            {
                result = ReadDatabase.GetData("Teacher",keyword,DataType);
            }
            else if (ChooseBox.Text == "查询即将被开除学生")
            {
                result = ReadDatabase.GetData("FailStudent", keyword, DataType);
            }
            ResultTable.DataSource = result;
            ResultTable.Columns[0].Width = 100;
        }

        /// <summary>
        /// 功能选项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseBox_TextChanged(object sender, EventArgs e)
        {
            if(ChooseBox.Text== "查询即将被开除学生")
            {
                FindTextBox.Text = "此功能不支持关键字查询，请检查功能按钮状态";               
                FindTextBox.Enabled = false;
                
            }
            else if (FindTextBox.Text == "此功能不支持关键字查询，请检查功能按钮状态")
            {
                FindTextBox.Enabled = true;
                FindTextBox.Text = @"请输入“姓名”或者“学号”开始查询  注:当内容为数字串时默认为“学号”，非数字串时默认为“姓名”，请确保只输入一种";

            }
        }

        /// <summary>
        /// 编辑框聚焦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetFindTextBoxFocus(object sender, EventArgs e)
        {
                FindTextBox.ForeColor = System.Drawing.Color.Black;
                if (FindTextBox.Text == "请输入“姓名”或者“学号”开始查询  注:当内容为数字串时默认为“学号”，非数字串时默认为“姓名”，请确保只输入一种" || FindTextBox.Text == "此功能不支持关键字查询，请检查功能按钮状态")
                {
                    FindTextBox.Text = "";
                }
        }

        /// <summary>
        /// 编辑框失去聚焦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetFindTextBoxunfocus(object sender, EventArgs e)
        {
            FindTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            if(FindTextBox.Text=="")
            {
                if(ChooseBox.Text!= "查询即将被开除学生")
                {
                    FindTextBox.Text = "请输入“姓名”或者“学号”开始查询  注:当内容为数字串时默认为“学号”，非数字串时默认为“姓名”，请确保只输入一种";
                }
                else
                {
                    FindTextBox.Text = "此功能不支持关键字查询，请检查功能按钮状态";
                }
            }
        }

        private void HelpAboutApplication_Click(object sender, EventArgs e)
        {
            HelpUsage helpUsage = new HelpUsage();
            helpUsage.Show();
        }

        private void HelpAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();

        }

        //默认
        private void SearchDefult_Click(object sender, EventArgs e)
        {
            ChooseBox.SelectedIndex = 0;
            this.FindButton.PerformClick();
        }

        //查询学生信息
        private void SearchInformation_Click(object sender, EventArgs e)
        {
            ChooseBox.SelectedIndex = 1;
        }

        //查询学生成绩
        private void SearchClassAndGrade_Click(object sender, EventArgs e)
        {
            ChooseBox.SelectedIndex = 2;
        }

        //查询历史教师
        private void SearchTeacher_Click(object sender, EventArgs e)
        {
            ChooseBox.SelectedIndex = 3;
        }

        //查询即将开除的学生
        private void SearchFailStudent_Click(object sender, EventArgs e)
        {
            ChooseBox.SelectedIndex = 4;
        }

        //更新学生信息
        private void UpdateInformation_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
        }

        //更新学生成绩
        private void UpdateGrade_Click(object sender, EventArgs e)
        {
            Grade grade = new Grade();
            grade.Show();
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

    }
}
