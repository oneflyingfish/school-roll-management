namespace 学籍管理系统
{
    partial class Grade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grade));
            this.SaveGradeButton = new System.Windows.Forms.Button();
            this.CloseGradeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentGrade = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ShowLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StudentCourse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SaveGradeButton
            // 
            this.SaveGradeButton.Location = new System.Drawing.Point(87, 279);
            this.SaveGradeButton.Name = "SaveGradeButton";
            this.SaveGradeButton.Size = new System.Drawing.Size(83, 27);
            this.SaveGradeButton.TabIndex = 21;
            this.SaveGradeButton.Text = "保存";
            this.toolTip1.SetToolTip(this.SaveGradeButton, "执行保存操作，但是不会关闭窗口");
            this.SaveGradeButton.UseVisualStyleBackColor = true;
            this.SaveGradeButton.Click += new System.EventHandler(this.SaveGradeButton_Click);
            // 
            // CloseGradeButton
            // 
            this.CloseGradeButton.Location = new System.Drawing.Point(221, 279);
            this.CloseGradeButton.Name = "CloseGradeButton";
            this.CloseGradeButton.Size = new System.Drawing.Size(76, 27);
            this.CloseGradeButton.TabIndex = 20;
            this.CloseGradeButton.Text = "关闭";
            this.toolTip1.SetToolTip(this.CloseGradeButton, "关闭窗口，但是不会执行保存操作");
            this.CloseGradeButton.UseVisualStyleBackColor = true;
            this.CloseGradeButton.Click += new System.EventHandler(this.CloseGradeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "姓名:";
            this.label2.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.Enabled = false;
            this.StudentName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentName.Location = new System.Drawing.Point(102, 100);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(231, 23);
            this.StudentName.TabIndex = 18;
            this.StudentName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "学号:";
            // 
            // StudentId
            // 
            this.StudentId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentId.Location = new System.Drawing.Point(102, 36);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(231, 23);
            this.StudentId.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(37, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "成绩:";
            // 
            // StudentGrade
            // 
            this.StudentGrade.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentGrade.Location = new System.Drawing.Point(102, 222);
            this.StudentGrade.Name = "StudentGrade";
            this.StudentGrade.Size = new System.Drawing.Size(231, 23);
            this.StudentGrade.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(37, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "课程:";
            // 
            // ShowLabel
            // 
            this.ShowLabel.AutoSize = true;
            this.ShowLabel.ForeColor = System.Drawing.Color.Red;
            this.ShowLabel.Location = new System.Drawing.Point(155, 322);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(119, 14);
            this.ShowLabel.TabIndex = 29;
            this.ShowLabel.Text = "正在执行，请稍后";
            this.ShowLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentCourse
            // 
            this.StudentCourse.FormattingEnabled = true;
            this.StudentCourse.Items.AddRange(new object[] {
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045",
            "HA1112004",
            "SC1112001",
            "SC1112003",
            "SC2112005",
            "SC1112007",
            "CS2121007",
            "CS3121009",
            "CS3221018",
            "CS4221019",
            "CS3221020",
            "CS4221021",
            "CS3221022",
            "CS4321042",
            "CS3321043",
            "CS4321044",
            "CS3321045"});
            this.StudentCourse.Location = new System.Drawing.Point(102, 139);
            this.StudentCourse.Name = "StudentCourse";
            this.StudentCourse.Size = new System.Drawing.Size(231, 22);
            this.StudentCourse.TabIndex = 30;
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 360);
            this.ControlBox = false;
            this.Controls.Add(this.StudentCourse);
            this.Controls.Add(this.ShowLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentGrade);
            this.Controls.Add(this.SaveGradeButton);
            this.Controls.Add(this.CloseGradeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentId);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grade";
            this.Text = "修改/插入成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveGradeButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button CloseGradeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox StudentCourse;
    }
}