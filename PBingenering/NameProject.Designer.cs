namespace PBingenering
{
    partial class NameProject
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
            this.BtnCreateProject = new System.Windows.Forms.Button();
            this.BtnCansel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameProject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnCreateProject
            // 
            this.BtnCreateProject.Location = new System.Drawing.Point(15, 229);
            this.BtnCreateProject.Name = "BtnCreateProject";
            this.BtnCreateProject.Size = new System.Drawing.Size(152, 57);
            this.BtnCreateProject.TabIndex = 0;
            this.BtnCreateProject.Text = "Создать проект";
            this.BtnCreateProject.UseVisualStyleBackColor = true;
            this.BtnCreateProject.Click += new System.EventHandler(this.BtnCreateProject_Click);
            // 
            // BtnCansel
            // 
            this.BtnCansel.Location = new System.Drawing.Point(446, 229);
            this.BtnCansel.Name = "BtnCansel";
            this.BtnCansel.Size = new System.Drawing.Size(152, 57);
            this.BtnCansel.TabIndex = 1;
            this.BtnCansel.Text = "Отмена";
            this.BtnCansel.UseVisualStyleBackColor = true;
            this.BtnCansel.Click += new System.EventHandler(this.BtnCansel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название проекта";
            // 
            // txtNameProject
            // 
            this.txtNameProject.Location = new System.Drawing.Point(172, 16);
            this.txtNameProject.Multiline = true;
            this.txtNameProject.Name = "txtNameProject";
            this.txtNameProject.Size = new System.Drawing.Size(426, 43);
            this.txtNameProject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список сотрудников проекта";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(172, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(426, 134);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // NameProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 298);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCansel);
            this.Controls.Add(this.BtnCreateProject);
            this.Name = "NameProject";
            this.Text = "Новый проект";
            this.Load += new System.EventHandler(this.NameProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateProject;
        private System.Windows.Forms.Button BtnCansel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}