using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBingenering.SQL;
using PBingenering.Model;

namespace PBingenering
{
    public partial class AddSubSection : Form
    {
        User currentUser;
        int IDProj;
        string err;
        string ProjectName;
        public string SubName { get; private set; }
        public int SpendedTime { get; private set; } = -1;

        public AddSubSection(int ProjID,User user, string NameProject)
        {
            currentUser = user;
            IDProj = ProjID;
            InitializeComponent();
            ProjectName = NameProject;
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            int minets;
            int hours;
             SubName = txtSubNameProject.Text;

            hours = int.Parse(mtbHours.Text);
            minets = int.Parse(mtbMinets.Text);

            if (minets > 59)
            {
                hours += 1;
                minets -= 60;
            }
             SpendedTime = (hours * 60) + minets;

            SqlManager.AddSubProject(currentUser, SubName,IDProj,out err , SpendedTime);
            MessageBox.Show("Название дополнительного раздела и  его планирование времени записано в базу.");
            Hide();
        }

        private void AddSubSection_Load(object sender, EventArgs e)
        {
            label6.Text = ProjectName;
        }

        private void BtnCansel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
