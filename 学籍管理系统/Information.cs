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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        //保存信息,弹出成功提示
        private void SaveInformationButton_Click(object sender, EventArgs e)
        {
            this.ShowLabel.Text = "正在执行，请稍后";
            this.ShowLabel.Visible = true;
            if (StudentId.Text.Replace(" ", "") == "" || StudentName.Text.Replace(" ", "") == "" || StudentSex.Text.Replace(" ", "") == "" || StudentYear.Text.Replace(" ", "") == "" || StudentMonth.Text.Replace(" ", "") == "" || StudentDay.Text.Replace(" ", "") == "")
            {
                this.ShowLabel.Text = "出现错误，已终止操作";
                MessageBox.Show("输入信息不全，请继续输入");
                this.ShowLabel.Visible = false;
                return;
            }
            if (!Judge.JudgeChars(StudentId.Text))
            {
                this.ShowLabel.Text = "出现错误，已终止操作";
                MessageBox.Show("学号请不要包含英文字母");
                return;
            }
            if (!Judge.JudgeChars(StudentYear.Text))
            {
                this.ShowLabel.Text = "出现错误，已终止操作";
                MessageBox.Show("年份请不要包含英文字母");
                this.ShowLabel.Visible = false;
                return;
            }
            if(!ReadDatabase.ChangeDataBase("Information",new Student(StudentId.Text,StudentName.Text,null,null,StudentSex.Text,StudentYear.Text,StudentMonth.Text,StudentDay.Text,StudentCollege.Text,StudentProfessional.Text,StudentClass.Text)))
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
        private void CloseUpdateInformation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.ShowLabel.Visible==true)
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
