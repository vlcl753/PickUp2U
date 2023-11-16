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
    }
}
