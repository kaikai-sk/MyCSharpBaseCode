namespace 老师或学生登陆
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.RadioStudent = new System.Windows.Forms.RadioButton();
            this.radioTeacher = new System.Windows.Forms.RadioButton();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 21);
            this.txtName.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(105, 67);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(210, 21);
            this.txtPwd.TabIndex = 2;
            // 
            // RadioStudent
            // 
            this.RadioStudent.AutoSize = true;
            this.RadioStudent.Location = new System.Drawing.Point(69, 115);
            this.RadioStudent.Name = "RadioStudent";
            this.RadioStudent.Size = new System.Drawing.Size(47, 16);
            this.RadioStudent.TabIndex = 3;
            this.RadioStudent.TabStop = true;
            this.RadioStudent.Text = "学生";
            this.RadioStudent.UseVisualStyleBackColor = true;
            // 
            // radioTeacher
            // 
            this.radioTeacher.AutoSize = true;
            this.radioTeacher.Location = new System.Drawing.Point(206, 115);
            this.radioTeacher.Name = "radioTeacher";
            this.radioTeacher.Size = new System.Drawing.Size(47, 16);
            this.radioTeacher.TabIndex = 4;
            this.radioTeacher.TabStop = true;
            this.radioTeacher.Text = "老师";
            this.radioTeacher.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(148, 146);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "登录";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 190);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.radioTeacher);
            this.Controls.Add(this.RadioStudent);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.RadioButton RadioStudent;
        private System.Windows.Forms.RadioButton radioTeacher;
        private System.Windows.Forms.Button btnLogIn;
    }
}

