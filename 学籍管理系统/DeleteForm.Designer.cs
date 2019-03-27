namespace 学籍管理系统
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.SaveDeleteButton = new System.Windows.Forms.Button();
            this.CloseDeleteButton = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ShowLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SaveDeleteButton
            // 
            this.SaveDeleteButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveDeleteButton.Location = new System.Drawing.Point(82, 271);
            this.SaveDeleteButton.Name = "SaveDeleteButton";
            this.SaveDeleteButton.Size = new System.Drawing.Size(83, 26);
            this.SaveDeleteButton.TabIndex = 25;
            this.SaveDeleteButton.Text = "删除";
            this.toolTip1.SetToolTip(this.SaveDeleteButton, "删除但是不会关闭窗口");
            this.SaveDeleteButton.UseVisualStyleBackColor = true;
            this.SaveDeleteButton.Click += new System.EventHandler(this.SaveDeleteButton_Click);
            // 
            // CloseDeleteButton
            // 
            this.CloseDeleteButton.Location = new System.Drawing.Point(194, 271);
            this.CloseDeleteButton.Name = "CloseDeleteButton";
            this.CloseDeleteButton.Size = new System.Drawing.Size(76, 26);
            this.CloseDeleteButton.TabIndex = 24;
            this.CloseDeleteButton.Text = "关闭";
            this.toolTip1.SetToolTip(this.CloseDeleteButton, "关闭但是不会执行删除操作");
            this.CloseDeleteButton.UseVisualStyleBackColor = true;
            this.CloseDeleteButton.Click += new System.EventHandler(this.CloseDeleteButton_Click);
            // 
            // StudentName
            // 
            this.StudentName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentName.Location = new System.Drawing.Point(91, 156);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(231, 23);
            this.StudentName.TabIndex = 23;
            // 
            // StudentId
            // 
            this.StudentId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentId.Location = new System.Drawing.Point(91, 49);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(231, 23);
            this.StudentId.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "姓名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "学号:";
            // 
            // ShowLabel
            // 
            this.ShowLabel.AutoSize = true;
            this.ShowLabel.ForeColor = System.Drawing.Color.Red;
            this.ShowLabel.Location = new System.Drawing.Point(149, 309);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(65, 12);
            this.ShowLabel.TabIndex = 28;
            this.ShowLabel.Text = "操作成功！";
            this.ShowLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 339);
            this.ControlBox = false;
            this.Controls.Add(this.ShowLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveDeleteButton);
            this.Controls.Add(this.CloseDeleteButton);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.StudentId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteForm";
            this.RightToLeftLayout = true;
            this.Text = "删除学生所有信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveDeleteButton;
        private System.Windows.Forms.Button CloseDeleteButton;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.Timer timer1;
    }
}