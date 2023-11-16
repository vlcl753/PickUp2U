using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserForm
{
    public partial class Form1 : Form
    {
        DBClass_user dbu;
        public Form1()
        {
            InitializeComponent();
            dbu = new DBClass_user();
        }

        private void user_sc_Click(object sender, EventArgs e)
        {
            try
            {
                dbu.DB_Open();
                DBGrid.DataSource = dbu.UserTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = DBGrid.Rows[e.RowIndex];

                    user_id.Text = selectedRow.Cells["ID"].Value.ToString();
                    user_name.Text = selectedRow.Cells["USER_NAME"].Value.ToString();
                    user_grade.Text = selectedRow.Cells["MEMBERSHIP_ID"].Value.ToString();
                    user_num.Text = "유저 번호 = " + selectedRow.Cells["USER_ID"].Value.ToString();
                    user_pw.Text = selectedRow.Cells["PASSWORD"].Value.ToString();
                    user_type.Text = selectedRow.Cells["USER_TYPE"].Value.ToString();
                    user_phone.Text = selectedRow.Cells["PHONE_NUM"].Value.ToString();
                    uesr_email.Text = selectedRow.Cells["EMAIL"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
