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

    public partial class CreateUserPr : Form
    {
        User currentUser;
        public bool HasAdded { get; private set; }
        public CreateUserPr(User user)
        {
            InitializeComponent();
            this.currentUser = user;

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

            ClearFieldsUser();
            Rol.DataSource = new BindingSource(SqlManager.GetRolView(), null);
            Rol.DisplayMember = "Value";
            Rol.ValueMember = "Key";
        }

        private void ClearFieldsUser()
        {
            SurName.Text = string.Empty;
            IsName.Text = string.Empty;
            ThirdName.Text = string.Empty;
            Login.Text = string.Empty;
            Password.Text = string.Empty;
            Rol.Text = string.Empty;           
        }
        
        private void Rol_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show($"Выбрано:{((KeyValuePair<int, string>)(sender as ComboBox).SelectedItem).Key}");
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SurName.Text))
            {
                MessageBox.Show("Фамилия должна быть заполнена.");
                return;
            }
            if (string.IsNullOrEmpty(IsName.Text))
            {
                MessageBox.Show("Имя должно быть заполнено.");
                return;
            }
            if (string.IsNullOrEmpty(ThirdName.Text))
            {
                MessageBox.Show("Отчество должно быть заполнено.");
                return;
            }
            if (string.IsNullOrEmpty(Login.Text))
            {
                MessageBox.Show("Логин должн быть заполнен.");
                return;
            }
            if (string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Пароль должн быть задан.");
                return;
            }
            if (string.IsNullOrEmpty(Rol.Text))
            {
                MessageBox.Show("Роль должна быть выбрана.");
                return;
            }

            User user = new User();
            user.role = new Role();

            int index = Rol.SelectedIndex+1;
            user.Surname = SurName.Text;
            user.Name = IsName.Text;
            user.NameName = ThirdName.Text;
            user.Login = Login.Text;
            user.Password = Password.Text;
            user.role.id = ((KeyValuePair<int, string>)Rol.SelectedItem).Key;
            user.role.Name = ((KeyValuePair<int, string>)Rol.SelectedItem).Value;

            User writeUser = SqlManager.CreateUser(user);

            MessageBox.Show("Пользователь создан.");
            HasAdded = true;
            ClearFieldsUser();

            
        }
    }
}
