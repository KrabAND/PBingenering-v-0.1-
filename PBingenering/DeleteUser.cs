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
    public partial class DeleteUser : Form
    {
        User currentUser;
        int numDel;
        public DeleteUser(User user,int index)
        {
            InitializeComponent();
            this.currentUser = user;
            numDel = index;
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //Удаление пользователя
            //int index = dataGridView1.CurrentCell.RowIndex + 1;
            if (SqlManager.DeleteUser(numDel))
                MessageBox.Show("Пользователь удален из базы.");
            else
                MessageBox.Show("Ошибка удаления пользователя из базы.");
            Hide();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
