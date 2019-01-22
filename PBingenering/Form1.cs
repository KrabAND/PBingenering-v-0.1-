using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using PBingenering.SQL;
using PBingenering.Model;

namespace PBingenering
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
            textBox1.KeyDown += Form1_KeyDown;
            textBox2.KeyDown += Form1_KeyDown;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlManager.CloseConnection();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            SqlManager.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = SqlManager.CheckLogin(textBox1.Text.Trim(), textBox2.Text.Trim());
            if(user != null)
            {
                Form2 fm = new Form2(user);
                Hide();
                if (fm.ShowDialog() == DialogResult.Cancel)//окно формы 2 было закрыто на крестик вверхнем правом углу
                {
                    Close();
                    fm.Hide();
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль не верны");

            }
            #region Старое говно
            /*
            //string commandString = "Select login,password,Roles.ROL from Personal inner join roles on personal.rol = roles.id where login= '" + textBox1.Text.Trim() + "' and password= '" + textBox2.Text.Trim() + "'";
            string commandString = $"Select login,password,Roles.ROL from Personal inner join roles on personal.rol = roles.id where login= '{textBox1.Text.Trim()}' and password= '{textBox2.Text.Trim()}'";

            SqlDataAdapter sda = new SqlDataAdapter(commandString, connection);

            DataTable dtb1 = new DataTable();

            DataGridView dgv1 = new DataGridView();
            dgv1.DataSource = sda;

            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                Form2 fm = new Form2(dtb1.Rows[0][0].ToString(), dtb1.Rows[0][2].ToString());
                Hide();
                if(fm.ShowDialog() ==  DialogResult.Cancel)//окно формы 2 было закрыто на крестик вверхнем правом углу
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Что то пошло не так");
            }*/
            #endregion
    }
       
    }
}
