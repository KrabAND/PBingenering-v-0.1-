namespace PBingenering
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnResPass = new System.Windows.Forms.Button();
            this.RestoreDeleteBtn = new System.Windows.Forms.Button();
            this.BtnDelUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCreateUser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnListProject = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnReport = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnCloseProject = new System.Windows.Forms.Button();
            this.BtnAddWork = new System.Windows.Forms.Button();
            this.BtnAddSection = new System.Windows.Forms.Button();
            this.BtnAddProject = new System.Windows.Forms.Button();
            this.BtnCreateProj = new System.Windows.Forms.Button();
            this.BtnDeleteDoc = new System.Windows.Forms.Button();
            this.btnCreateDoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCloseSection = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 479);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.BtnResPass);
            this.tabPage1.Controls.Add(this.RestoreDeleteBtn);
            this.tabPage1.Controls.Add(this.BtnDelUser);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.BtnCreateUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Админка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Создание рабочего календаря";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnResPass
            // 
            this.BtnResPass.Location = new System.Drawing.Point(249, 394);
            this.BtnResPass.Name = "BtnResPass";
            this.BtnResPass.Size = new System.Drawing.Size(119, 53);
            this.BtnResPass.TabIndex = 7;
            this.BtnResPass.Text = "Сбросить пароль";
            this.BtnResPass.UseVisualStyleBackColor = true;
            this.BtnResPass.Click += new System.EventHandler(this.BtnResPass_Click);
            // 
            // RestoreDeleteBtn
            // 
            this.RestoreDeleteBtn.Location = new System.Drawing.Point(124, 394);
            this.RestoreDeleteBtn.Name = "RestoreDeleteBtn";
            this.RestoreDeleteBtn.Size = new System.Drawing.Size(119, 53);
            this.RestoreDeleteBtn.TabIndex = 6;
            this.RestoreDeleteBtn.Text = "Заблокировать / Восстановить пользователя";
            this.RestoreDeleteBtn.UseVisualStyleBackColor = true;
            this.RestoreDeleteBtn.Click += new System.EventHandler(this.btnRestoreDelete_Click);
            // 
            // BtnDelUser
            // 
            this.BtnDelUser.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnDelUser.Location = new System.Drawing.Point(643, 394);
            this.BtnDelUser.Name = "BtnDelUser";
            this.BtnDelUser.Size = new System.Drawing.Size(119, 53);
            this.BtnDelUser.TabIndex = 5;
            this.BtnDelUser.Text = "Удалить пользователя c базы";
            this.BtnDelUser.UseVisualStyleBackColor = false;
            this.BtnDelUser.Click += new System.EventHandler(this.BtnDelUser_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 388);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // BtnCreateUser
            // 
            this.BtnCreateUser.Location = new System.Drawing.Point(3, 394);
            this.BtnCreateUser.Name = "BtnCreateUser";
            this.BtnCreateUser.Size = new System.Drawing.Size(119, 53);
            this.BtnCreateUser.TabIndex = 1;
            this.BtnCreateUser.Text = "Создать пользователя";
            this.BtnCreateUser.UseVisualStyleBackColor = true;
            this.BtnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnListProject);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.maskedTextBox2);
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.BtnReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Для руководства";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnListProject
            // 
            this.btnListProject.Location = new System.Drawing.Point(128, 394);
            this.btnListProject.Name = "btnListProject";
            this.btnListProject.Size = new System.Drawing.Size(119, 53);
            this.btnListProject.TabIndex = 10;
            this.btnListProject.Text = "Список проектов";
            this.btnListProject.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "Создать проект";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "от";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отчет по сотруднику";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(656, 283);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(525, 283);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(592, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(495, 305);
            this.dataGridView3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Список не заполнивших отчет сотрудников";
            // 
            // BtnReport
            // 
            this.BtnReport.Location = new System.Drawing.Point(643, 186);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(119, 53);
            this.BtnReport.TabIndex = 0;
            this.BtnReport.Text = "Отчет по сотрудникам";
            this.BtnReport.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnCloseSection);
            this.tabPage3.Controls.Add(this.BtnCloseProject);
            this.tabPage3.Controls.Add(this.BtnAddWork);
            this.tabPage3.Controls.Add(this.BtnAddSection);
            this.tabPage3.Controls.Add(this.BtnAddProject);
            this.tabPage3.Controls.Add(this.BtnCreateProj);
            this.tabPage3.Controls.Add(this.BtnDeleteDoc);
            this.tabPage3.Controls.Add(this.btnCreateDoc);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Для сотрудников";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnCloseProject
            // 
            this.BtnCloseProject.Location = new System.Drawing.Point(3, 389);
            this.BtnCloseProject.Name = "BtnCloseProject";
            this.BtnCloseProject.Size = new System.Drawing.Size(119, 53);
            this.BtnCloseProject.TabIndex = 7;
            this.BtnCloseProject.Text = "Закрыть проект (только для ГИП,ГАП)";
            this.BtnCloseProject.UseVisualStyleBackColor = true;
            // 
            // BtnAddWork
            // 
            this.BtnAddWork.Location = new System.Drawing.Point(378, 330);
            this.BtnAddWork.Name = "BtnAddWork";
            this.BtnAddWork.Size = new System.Drawing.Size(119, 53);
            this.BtnAddWork.TabIndex = 6;
            this.BtnAddWork.Text = "Создать запись работы";
            this.BtnAddWork.UseVisualStyleBackColor = true;
            // 
            // BtnAddSection
            // 
            this.BtnAddSection.Location = new System.Drawing.Point(253, 330);
            this.BtnAddSection.Name = "BtnAddSection";
            this.BtnAddSection.Size = new System.Drawing.Size(119, 53);
            this.BtnAddSection.TabIndex = 5;
            this.BtnAddSection.Text = "Добавить дополнительный раздел проекта";
            this.BtnAddSection.UseVisualStyleBackColor = true;
            this.BtnAddSection.Click += new System.EventHandler(this.BtnAddSection_Click);
            // 
            // BtnAddProject
            // 
            this.BtnAddProject.Location = new System.Drawing.Point(128, 330);
            this.BtnAddProject.Name = "BtnAddProject";
            this.BtnAddProject.Size = new System.Drawing.Size(119, 53);
            this.BtnAddProject.TabIndex = 4;
            this.BtnAddProject.Text = "Работать в проекте";
            this.BtnAddProject.UseVisualStyleBackColor = true;
            this.BtnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // BtnCreateProj
            // 
            this.BtnCreateProj.Location = new System.Drawing.Point(3, 330);
            this.BtnCreateProj.Name = "BtnCreateProj";
            this.BtnCreateProj.Size = new System.Drawing.Size(119, 53);
            this.BtnCreateProj.TabIndex = 3;
            this.BtnCreateProj.Text = "Создать проект (только для ГИП,ГАП)";
            this.BtnCreateProj.UseVisualStyleBackColor = true;
            this.BtnCreateProj.Click += new System.EventHandler(this.BtnCreateProj_Click);
            // 
            // BtnDeleteDoc
            // 
            this.BtnDeleteDoc.Location = new System.Drawing.Point(643, 330);
            this.BtnDeleteDoc.Name = "BtnDeleteDoc";
            this.BtnDeleteDoc.Size = new System.Drawing.Size(119, 53);
            this.BtnDeleteDoc.TabIndex = 2;
            this.BtnDeleteDoc.Text = "Удалить/Восстановить запись";
            this.BtnDeleteDoc.UseVisualStyleBackColor = true;
            this.BtnDeleteDoc.Click += new System.EventHandler(this.BtnDeleteDoc_Click);
            // 
            // btnCreateDoc
            // 
            this.btnCreateDoc.Location = new System.Drawing.Point(518, 330);
            this.btnCreateDoc.Name = "btnCreateDoc";
            this.btnCreateDoc.Size = new System.Drawing.Size(119, 53);
            this.btnCreateDoc.TabIndex = 1;
            this.btnCreateDoc.Text = "Создать запись работы";
            this.btnCreateDoc.UseVisualStyleBackColor = true;
            this.btnCreateDoc.Click += new System.EventHandler(this.btnCreateDoc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 321);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(762, 318);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип доступа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(703, 571);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Вы добавлены в проект(ы):";
            // 
            // BtnCloseSection
            // 
            this.BtnCloseSection.Location = new System.Drawing.Point(128, 389);
            this.BtnCloseSection.Name = "BtnCloseSection";
            this.BtnCloseSection.Size = new System.Drawing.Size(119, 53);
            this.BtnCloseSection.TabIndex = 8;
            this.BtnCloseSection.Text = "Закрыть раздел";
            this.BtnCloseSection.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 616);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCreateUser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDeleteDoc;
        private System.Windows.Forms.Button btnCreateDoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnDelUser;
        private System.Windows.Forms.Button RestoreDeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BtnResPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAddProject;
        private System.Windows.Forms.Button BtnCreateProj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnListProject;
        private System.Windows.Forms.Button BtnAddSection;
        private System.Windows.Forms.Button BtnAddWork;
        private System.Windows.Forms.Button BtnCloseProject;
        private System.Windows.Forms.Button BtnCloseSection;
    }
}