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
    public partial class ResetPassword : Form
    {
        //User currentUser;
        int index;
        public ResetPassword(int userId)
        {
            InitializeComponent();
            //this.currentUser = user;
            index = userId;

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            
            string str = txtPass.Text;
            SqlManager.ResPass(index, str);
            MessageBox.Show("Пароль изменен");
            Hide();
        }

        private void BtnCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
