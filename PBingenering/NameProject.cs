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
using static System.Windows.Forms.ListBox;

namespace PBingenering
{
    
    public partial class NameProject : Form
    {
        User currentUser;
        public NameProject(User user)
        {
            currentUser = user;
            InitializeComponent();
        }

        private void BtnCansel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void NameProject_Load(object sender, EventArgs e)
        {
            DataTable dt = SqlManager.GetWorkPersonalsView();
            Dictionary<int, string> users = new Dictionary<int, string>();

            //listBox1.DisplayMember = "Сотрудники";
            //listBox1.DataSource = SqlManager.GetWorkPersonalsView();

            foreach (DataRow row in dt.Rows)
            {
                users.Add(int.Parse(row["ID"].ToString()),
                                                            $"{row["SURNAME"].ToString()} {row["Name"].ToString()} {row["NameName"].ToString()},\t{row["ROL"].ToString()}");
            }
            listBox1.DataSource = new BindingSource(users, null);
            listBox1.DisplayMember = "Value";
            listBox1.ValueMember = "Key";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataRowView row = listBox1.SelectedItem as DataRowView;
            //string str = row["ROL"].ToString() +" "+ row["LOGIN"].ToString();
            //MessageBox.Show(str);
        }

        private void BtnCreateProject_Click(object sender, EventArgs e)
        {
            string err = string.Empty;

            if(string.IsNullOrEmpty(txtNameProject.Text))
                err += "Необходимо ввести имя проекта." + Environment.NewLine;
                //err = err + "Необходимо ввести имя проекта.\n" ;

            if (listBox1.SelectedItems.Count == 0)
                err += "Необходимо выбрать хотя бы одного пользователя." + Environment.NewLine;

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }
            
            int[] IDs = new int[listBox1.SelectedItems.Count];
            
            int i = 0;
            foreach (KeyValuePair<int, string> item in listBox1.SelectedItems)
            {
                IDs[i] = item.Key;
                i++;
            }
            string sqlError;
            SqlManager.CreateMainProject(currentUser, txtNameProject.Text, out sqlError, IDs);

            if (!string.IsNullOrEmpty(sqlError))
                MessageBox.Show(sqlError, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Проект создан, сотрудники назначены.", "Проект создан", MessageBoxButtons.OK);

            ClearFieldsProject();
        }

        private void ClearFieldsProject()
        {
            txtNameProject.Text = string.Empty;
        }
    }
}
