namespace GiaoDien
{
    partial class dangnhap
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_project = new System.Windows.Forms.Label();
            this.btn_signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(349, 111);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(215, 20);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(349, 151);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(215, 20);
            this.txt_password.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(287, 114);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(60, 13);
            this.lb_username.TabIndex = 2;
            this.lb_username.Text = "UserName:";
            this.lb_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(287, 154);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(56, 13);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Password:";
            // 
            // lb_project
            // 
            this.lb_project.AutoSize = true;
            this.lb_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_project.Location = new System.Drawing.Point(186, 20);
            this.lb_project.Name = "lb_project";
            this.lb_project.Size = new System.Drawing.Size(457, 25);
            this.lb_project.TabIndex = 4;
            this.lb_project.Text = "Hệ thống quản lý Doanh nghiệp cho thuê hội trường";
            this.lb_project.Click += new System.EventHandler(this.lb_project_Click);
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(349, 217);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(120, 23);
            this.btn_signin.TabIndex = 6;
            this.btn_signin.Text = "ĐĂNG NHẬP";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.lb_project);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "dangnhap";
            this.Text = "Hệ thống quản lý Doanh nghiệp cho thuê hội trường";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_project;
        private System.Windows.Forms.Button btn_signin;
    }
}

