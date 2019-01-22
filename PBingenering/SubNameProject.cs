using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBingenering.SQL;
using PBingenering.Model;

namespace PBingenering
{
    public partial class SubNameProject : Form
    {
        Guid projID;
        string ProjectName;
        public SubNameProject(Guid IDproj, string NameProject)
        {
            InitializeComponent();
            projID = IDproj;
            ProjectName = NameProject;
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            int minets;
            int hours;
            string SubName = txtSubNameProject.Text;

            hours = int.Parse(mtbHours.Text);
            minets = int.Parse( mtbMinets.Text);

            if (minets >59)
            {
                hours +=  1;
                minets -= 60;
            }
            int SpendedTime = (hours * 60) + minets;

            SqlManager.AddSubNameProject(projID, SubName, SpendedTime);
            MessageBox.Show("Название раздела и планирование времени записано в базу.");
            Clean();
        }

        private void Clean()
        {
            txtSubNameProject.Text = string.Empty;
            mtbHours.Text = string.Empty;
            mtbMinets.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SubNameProject_Load(object sender, EventArgs e)
        {
            label6.Text = ProjectName;
        }
    }
}
