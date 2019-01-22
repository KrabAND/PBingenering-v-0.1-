namespace PBingenering
{
    partial class AddSubSection
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbMinets = new System.Windows.Forms.MaskedTextBox();
            this.mtbHours = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCansel = new System.Windows.Forms.Button();
            this.txtSubNameProject = new System.Windows.Forms.TextBox();
            this.BtnAddProject = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название дополнительного раздела";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "минут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "часов";
            // 
            // mtbMinets
            // 
            this.mtbMinets.Location = new System.Drawing.Point(205, 123);
            this.mtbMinets.Mask = "00";
            this.mtbMinets.Name = "mtbMinets";
            this.mtbMinets.Size = new System.Drawing.Size(80, 20);
            this.mtbMinets.TabIndex = 17;
            this.mtbMinets.ValidatingType = typeof(int);
            // 
            // mtbHours
            // 
            this.mtbHours.Location = new System.Drawing.Point(63, 123);
            this.mtbHours.Mask = "00000";
            this.mtbHours.Name = "mtbHours";
            this.mtbHours.Size = new System.Drawing.Size(80, 20);
            this.mtbHours.TabIndex = 16;
            this.mtbHours.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Планируется потратить время на дополнительный раздел";
            // 
            // BtnCansel
            // 
            this.BtnCansel.Location = new System.Drawing.Point(205, 166);
            this.BtnCansel.Name = "BtnCansel";
            this.BtnCansel.Size = new System.Drawing.Size(119, 53);
            this.BtnCansel.TabIndex = 14;
            this.BtnCansel.Text = "Отмена";
            this.BtnCansel.UseVisualStyleBackColor = true;
            this.BtnCansel.Click += new System.EventHandler(this.BtnCansel_Click);
            // 
            // txtSubNameProject
            // 
            this.txtSubNameProject.Location = new System.Drawing.Point(24, 54);
            this.txtSubNameProject.Name = "txtSubNameProject";
            this.txtSubNameProject.Size = new System.Drawing.Size(300, 20);
            this.txtSubNameProject.TabIndex = 13;
            // 
            // BtnAddProject
            // 
            this.BtnAddProject.Location = new System.Drawing.Point(24, 166);
            this.BtnAddProject.Name = "BtnAddProject";
            this.BtnAddProject.Size = new System.Drawing.Size(119, 53);
            this.BtnAddProject.TabIndex = 12;
            this.BtnAddProject.Text = "Создать дополнительный раздел раздел";
            this.BtnAddProject.UseVisualStyleBackColor = true;
            this.BtnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Название ПРОЕКТА";
            // 
            // AddSubSection
            // 
            this.ClientSize = new System.Drawing.Size(381, 264);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbMinets);
            this.Controls.Add(this.mtbHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCansel);
            this.Controls.Add(this.txtSubNameProject);
            this.Controls.Add(this.BtnAddProject);
            this.Controls.Add(this.label1);
            this.Name = "AddSubSection";
            this.Text = "Доп раздел";
            this.Load += new System.EventHandler(this.AddSubSection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbMinets;
        private System.Windows.Forms.MaskedTextBox mtbHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCansel;
        private System.Windows.Forms.TextBox txtSubNameProject;
        private System.Windows.Forms.Button BtnAddProject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
