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
    enum UserRole
    {
        Root,
        Administration,
        User
    }
    public partial class Form2 : Form
    {
        User currentUser;
        public Form2(User user)
        {
            currentUser = user;
            
            InitializeComponent();
            label3.Text = currentUser.role.Name;
            label4.Text = currentUser.Login;
            if (currentUser.role.Name == "Руководство")
            {
                tabPage1.Parent = null;               
                tabPage3.Parent = null;
                tabPage2.Parent = tabControl1;
            }
            else if(currentUser.role.Name == "Администратор")
            {
                tabPage1.Parent = tabControl1;
            }
            else
            {
                tabPage1.Parent = null;
                tabPage2.Parent = null;
                tabPage3.Parent = tabControl1;
            }
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {
            if(currentUser.role.Name == "Администратор")
                FillDvgForUser(dataGridView1, UserRole.Root, dataGridView2);
            else if (currentUser.role.Name == "Руководство")
                FillDvgForUser(dataGridView2, UserRole.Administration);
            else
                FillDvgForUser(dataGridView2, UserRole.User);


        }

        private void FillDvgForUser(DataGridView dgv, UserRole role, DataGridView ext = null)
        {
            switch (role)
            {
                case UserRole.Root:
                    dgv.DataSource = SqlManager.GetUserView();
                    dgv.Columns["IDeleteState"].Visible = false;
                    dgv.Columns["ID"].Visible = false;
                    dgv.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    RecolorDeletedRow(dataGridView1, "IDeleteState");
                    if(ext != null)
                    {
                        ext.DataSource = SqlManager.GetProjectSpendedView();
                        //dataGridView2.Columns["Deleted"].Visible = false;
                        //dataGridView2.Columns["LOGIN"].Visible = false;
                        //dataGridView2.Columns["id"].Visible = false;
                        ext.AutoResizeColumns(
                        DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    }
                    label8.Visible = false;
                    break;
                case UserRole.Administration:
                    dgv.DataSource = SqlManager.GetProjectView(label4.Text);
                    //dataGridView2.Columns["Deleted"].Visible = false;
                    //dataGridView2.Columns["LOGIN"].Visible = false;
                    //dataGridView2.AutoResizeColumns(
                    //DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    label8.Visible = false;
                    break;
                case UserRole.User:
                    dgv.DataSource = SqlManager.GetProjectSpendedView(currentUser.Login);
                    dgv.Columns["Deleted"].Visible = false;
                    dgv.Columns["LOGIN"].Visible = false;
                    dgv.Columns["ID"].Visible = false;
                    dgv.Columns["ROL"].Visible = false;
                    dgv.Columns["ProjectId"].Visible = false;
                    dgv.Columns["GUID"].Visible = false;
                    break;
                default:
                    break;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Close();
            //Hide();
            Form1 fm = new Form1();
           // Form2 fm2 = new Form2(currentUser);
            Hide();
            fm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }


        //Создаем документ для работы
        private void btnCreateDoc_Click(object sender, EventArgs e)
        {
            InserDocSql ids = new InserDocSql(currentUser);
            ids.ShowDialog();
        }


        //Создаем нового пользователя
        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserPr cu = new CreateUserPr(currentUser);
            cu.ShowDialog();

            if (cu.HasAdded)
            {
                dataGridView1.DataSource = SqlManager.GetUserView();
                RecolorDeletedRow(dataGridView1, "IDeleteState");
            }

        }

        private void RecolorDeletedRow(DataGridView dgv, string columnName)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if(int.TryParse(dgv[columnName,i].Value.ToString(), out int ideletestate))
                {
                    if(ideletestate == 1)
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;

                    }
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RecolorDeletedRow(dataGridView1, "IDeleteState");
        }

        //private void BtnBlockUser_Click(object sender, EventArgs e)
        //{
        //    //Заблокировать пользователя UPDATE IDELETESTATE c 0 на 1

        //    int index = dataGridView1.CurrentCell.RowIndex+1;
        //    SqlManager.BlocUser(index);
        //    MessageBox.Show("Пользователь заблокирован");

        //}


        //Удалить пользователя
        private void BtnDelUser_Click(object sender, EventArgs e)
        {
            int userID = (int)dataGridView1["ID",  dataGridView1.CurrentRow.Index].Value;
            DeleteUser delUser = new DeleteUser(currentUser, userID);
            delUser.ShowDialog();
            dataGridView1.DataSource = SqlManager.GetUserView();
            RecolorDeletedRow(dataGridView1, "IDeleteState");
        }

        //private void BtnRestoreUser_Click(object sender, EventArgs e)
        //{
        //    //Востановить пользователя
        //    int index = dataGridView1.CurrentRow.Index + 1;
        //    int ideleteState = (int)dataGridView1[5, index - 1].Value == 0 ? 1 : 0;
        //    SqlManager.RestoreUser(index, ideleteState);
        //    RecolorDeletedRow(dataGridView1, "IDeleteState");
        //    MessageBox.Show("Пользователь " + (ideleteState == 0 ? " восстановлен." : " удалён."));



        //}

        private void btnRestoreDelete_Click(object sender, EventArgs e)
        {
            //Востановить пользователя
            int index = dataGridView1.CurrentRow.Index + 1;
            int userID = (int)dataGridView1[0, index - 1].Value;

            int ideleteState = (int)dataGridView1[6, index - 1].Value == 0 ? 1 : 0;
            SqlManager.RestoreUser(userID, ideleteState);
            RecolorDeletedRow(dataGridView1, "IDeleteState");
            MessageBox.Show("Пользователь " + (ideleteState == 0 ? " восстановлен." : " заблокирован."));
            dataGridView1.DataSource = SqlManager.GetUserView();
            RecolorDeletedRow(dataGridView1, "IDeleteState");
        }

        private void BtnResPass_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index + 1;
            int userID = (int)dataGridView1[0, index - 1].Value;
            ResetPassword resPass = new ResetPassword(userID);
            resPass.ShowDialog();
        }

        //Удаляем(убираем видимость) документ(а)
        private void BtnDeleteDoc_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index + 1;
            int projID = (int)dataGridView2[1, index - 1].Value;
            int Deleted = (int)dataGridView2[0, index - 1].Value == 0 ? 1 : 0;  //проверить какая по счету колонка Deleted 
            SqlManager.RestoreProj(projID, Deleted);
            MessageBox.Show("Документ " + (Deleted == 0 ? " восстановлен." : " заблокирован."));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Создаем новый проект и назначением в него сотрудников
        private void BtnCreateProj_Click(object sender, EventArgs e)
        {
            if(currentUser.role.Name == "ГАП" || currentUser.role.Name == "ГИП")
            {
                NameProject nameP = new NameProject(currentUser);
                nameP.ShowDialog();
            }
            else
            {
                MessageBox.Show("У Вас нет прав, на создание проекта.");
            }
        }

        //Создать проект руководитель ,Админ
        private void button3_Click(object sender, EventArgs e)
        {
            NameProject nameP = new NameProject(currentUser);
            nameP.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            string NameProject = dataGridView2["Имя проекта", dataGridView2.CurrentRow.Index].Value.ToString();
            Guid guid = Guid.Parse(dataGridView2["GUID", dataGridView2.CurrentRow.Index].Value.ToString());
            SubNameProject snp = new SubNameProject(guid, NameProject);
            snp.ShowDialog();
        }


        //создаем доп раздел
        private void BtnAddSection_Click(object sender, EventArgs e)
        {
            int projID = (int)dataGridView2["ProjectId", dataGridView2.CurrentRow.Index].Value;
            string NameProject = dataGridView2["Имя проекта", dataGridView2.CurrentRow.Index].Value.ToString();
            AddSubSection ass = new AddSubSection(projID, currentUser,NameProject);
            ass.ShowDialog();
            FillDvgForUser(dataGridView2, UserRole.User);

        }
    }
}

