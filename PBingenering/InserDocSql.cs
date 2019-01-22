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
    public partial class InserDocSql : Form
    {
        User currentUser;
        public InserDocSql(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void InserDocSql_Load(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSaveDoc_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ProjectName.Text) || string.IsNullOrEmpty(ProjectSurName.Text))
            {
                MessageBox.Show("Название проекта или Раздел проекта не могут быть пустыми.");
                return;
            }
            if (!CheckMoney())
            {
                MessageBox.Show("Планируемые затраты и Фактические затраты должны быть представленны в виде числа с запятой.");
                return;
            }
            if (!CheckTime())
            {
                MessageBox.Show("Часы и минуты должны быть указаны.");
                return;
            }

            ProjectDoc project = new ProjectDoc();
            project.User = currentUser;
            project.NameProject = ProjectName.Text;
            project.SurNameProject = ProjectSurName.Text;
            project.PlanHourse = int.Parse(PlanHourse.Text);
            project.PlanMinets = int.Parse(PlanMinets.Text);
            project.SpendedHourse = int.Parse(SpendedHourse.Text);
            project.SpendedMinets = int.Parse(SpendedMinets.Text);
            project.PlanMoney = decimal.Parse(PlanMoney.Text.Replace('.', ','));
            project.SpendedMoney = decimal.Parse(SpendedMoney.Text.Replace('.', ','));

            ProjectDoc writedProject = SqlManager.InsertProjectDoc(project);

            if(writedProject.guid == default(Guid))
            {
                MessageBox.Show("Произошла ошибка, данные не были записаны в базу данных!");
                return;
            }
            MessageBox.Show("Данные успешно записаны в базу данных.");
            ClearFields();

        }
        private bool CheckMoney()
        {
            if (!decimal.TryParse(PlanMoney.Text.Replace('.',','), out decimal planMoney))
                return false;
            if (!decimal.TryParse(SpendedMoney.Text.Replace('.', ','), out decimal spendedMoney))
                return false;

            return true;
        }
        private bool CheckTime()
        {
            if (!int.TryParse(PlanHourse.Text, out int planMoney))
                return false;
            if (!int.TryParse(SpendedHourse.Text, out int spendedMoney))
                return false;
            if (!int.TryParse(PlanMinets.Text, out int panMinets))
                return false;
            if (!int.TryParse(SpendedMinets.Text, out int spendedMinets))
                return false;

            return true;
        }
        private void ClearFields()
        {
            ProjectName.Text = string.Empty;
            ProjectSurName.Text = string.Empty;
            PlanHourse.Text = string.Empty;
            PlanMinets.Text = string.Empty;
            SpendedHourse.Text = string.Empty;
            SpendedMinets.Text = string.Empty;
            PlanMoney.Text = string.Empty;
            SpendedMoney.Text = string.Empty;
        }
    }
}
