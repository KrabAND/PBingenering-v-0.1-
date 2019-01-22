namespace PBingenering
{
    partial class SubNameProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddProject = new System.Windows.Forms.Button();
            this.txtSubNameProject = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbHours = new System.Windows.Forms.MaskedTextBox();
            this.mtbMinets = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название раздела";
            // 
            // BtnAddProject
            // 
            this.BtnAddProject.Location = new System.Drawing.Point(41, 169);
            this.BtnAddProject.Name = "BtnAddProject";
            this.BtnAddProject.Size = new System.Drawing.Size(119, 53);
            this.BtnAddProject.TabIndex = 4;
            this.BtnAddProject.Text = "Создать раздел";
            this.BtnAddProject.UseVisualStyleBackColor = true;
            this.BtnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // txtSubNameProject
            // 
            this.txtSubNameProject.Location = new System.Drawing.Point(41, 57);
            this.txtSubNameProject.Name = "txtSubNameProject";
            this.txtSubNameProject.Size = new System.Drawing.Size(300, 20);
            this.txtSubNameProject.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Планируется потратить время ";
            // 
            // mtbHours
            // 
            this.mtbHours.Location = new System.Drawing.Point(80, 126);
            this.mtbHours.Mask = "00000";
            this.mtbHours.Name = "mtbHours";
            this.mtbHours.Size = new System.Drawing.Size(80, 20);
            this.mtbHours.TabIndex = 8;
            this.mtbHours.ValidatingType = typeof(int);
            // 
            // mtbMinets
            // 
            this.mtbMinets.Location = new System.Drawing.Point(222, 126);
            this.mtbMinets.Mask = "00";
            this.mtbMinets.Name = "mtbMinets";
            this.mtbMinets.Size = new System.Drawing.Size(80, 20);
            this.mtbMinets.TabIndex = 9;
            this.mtbMinets.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "часов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "минут";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Название ПРОЕКТА";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // SubNameProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 270);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbMinets);
            this.Controls.Add(this.mtbHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSubNameProject);
            this.Controls.Add(this.BtnAddProject);
            this.Controls.Add(this.label1);
            this.Name = "SubNameProject";
            this.Text = "SubNameProject";
            this.Load += new System.EventHandler(this.SubNameProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddProject;
        private System.Windows.Forms.TextBox txtSubNameProject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbHours;
        private System.Windows.Forms.MaskedTextBox mtbMinets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}