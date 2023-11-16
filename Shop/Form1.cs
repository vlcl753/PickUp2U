using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {

        DBClass dbc;

        public Form1()
        {
            InitializeComponent();
            dbc = new DBClass();
        }

        private void shop_list_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Open(); // 데이터 가져오기
                DBGrid.DataSource = dbc.PhoneTable.DefaultView; // 데이터를 그리드에 바인딩
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
                    DataRowView selectedRow = (DataRowView)DBGrid.Rows[e.RowIndex].DataBoundItem;

                    txtid.Text = selectedRow["shop_name"].ToString();
                    txtName.Text = selectedRow["shop_location"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
