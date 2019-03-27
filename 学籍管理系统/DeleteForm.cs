using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理系统
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        //删除信息,弹出成功提示
        private void SaveDeleteButton_Click(object sender, EventArgs e)
        {
            this.ShowLabel.Text = "正在执行,请稍后";
            this.ShowLabel.Visible = true;
            if (this.StudentId.Text == "" || this.StudentName.Text == "")
            {
                this.ShowLabel.Text = "出现错误，已终止操作";
                MessageBox.Show("请确保信息完整", "错误");
                this.ShowLabel.Visible = false;
                return;
            }
            else if (!Judge.JudgeChars(this.StudentId.Text))
            {
                this.ShowLabel.Text = "出现错误，已终止操作";
                MessageBox.Show("请确保学号是纯数字", "错误");
                this.ShowLabel.Visible = false;
                return;
            }

            if (!ReadDatabase.ChangeDataBase("DeleteInformation", new Student(StudentId.Text, StudentName.Text)))
            {
                this.ShowLabel.Text = "执行错误";
                MessageBox.Show("数据保存失败，未知错误");
                this.ShowLabel.Visible = false;
                return;
            }
            this.ShowLabel.Visible = false;
            this.timer1.Enabled = true;
            this.ShowLabel.Text = "操作成功";
        }

        //关闭界面
        private void CloseDeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.ShowLabel.Visible == true)
            {
                this.ShowLabel.Visible = false;
                this.timer1.Enabled = false;
            }
            else if (this.ShowLabel.Visible == false)
            {
                this.ShowLabel.Visible = true;
            }
        }
    }
}
