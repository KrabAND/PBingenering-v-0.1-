namespace PBingenering
{
    partial class CreateUserPr
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
            this.BtnCreateUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SurName = new System.Windows.Forms.TextBox();
            this.IsName = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Rol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCreateUser
            // 
            this.BtnCreateUser.Location = new System.Drawing.Point(10, 279);
            this.BtnCreateUser.Name = "BtnCreateUser";
            this.BtnCreateUser.Size = new System.Drawing.Size(185, 68);
            this.BtnCreateUser.TabIndex = 1;
            this.BtnCreateUser.Text = "Добавляем нового пользователя";
            this.BtnCreateUser.UseVisualStyleBackColor = true;
            this.BtnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Роль";
            // 
            // SurName
            // 
            this.SurName.Location = new System.Drawing.Point(82, 12);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(201, 20);
            this.SurName.TabIndex = 8;
            // 
            // IsName
            // 
            this.IsName.Location = new System.Drawing.Point(82, 51);
            this.IsName.Name = "IsName";
            this.IsName.Size = new System.Drawing.Size(201, 20);
            this.IsName.TabIndex = 9;
            // 
            // ThirdName
            // 
            this.ThirdName.Location = new System.Drawing.Point(82, 83);
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(201, 20);
            this.ThirdName.TabIndex = 10;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(82, 117);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(201, 20);
            this.Login.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(82, 155);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(201, 20);
            this.Password.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 234);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(273, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // Rol
            // 
            this.Rol.FormattingEnabled = true;
            this.Rol.Location = new System.Drawing.Point(82, 190);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(201, 21);
            this.Rol.TabIndex = 14;
            this.Rol.SelectedIndexChanged += new System.EventHandler(this.Rol_SelectedIndexChanged);
            // 
            // CreateUserPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 360);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.ThirdName);
            this.Controls.Add(this.IsName);
            this.Controls.Add(this.SurName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCreateUser);
            this.Name = "CreateUserPr";
            this.Text = "Добовляем нового пользователя";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCreateUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SurName;
        private System.Windows.Forms.TextBox IsName;
        private System.Windows.Forms.TextBox ThirdName;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox Rol;
    }
}