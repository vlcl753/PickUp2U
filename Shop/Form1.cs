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
        private int SelectedRowIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void shop_list_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=jintaek; Password=jintaek; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "SELECT shop_name, shop_location FROM shop";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "shop");
                DBGrid.DataSource = DS.Tables["shop"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string connectionString = "User Id=jintaek; Password=jintaek; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from shop";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "shop");
                DataTable phoneTable = DS.Tables["shop"];
                if (e.RowIndex < 0)
                {
                    return;
                }
                else if (e.RowIndex > phoneTable.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = phoneTable.Rows[e.RowIndex];
                txtid.Text = currRow["SHOP_NAME"].ToString();
                txtName.Text = currRow["shop_location"].ToString();
                //txtPhone.Text = currRow["Phone"].ToString();
                //txtMail.Text = currRow["EMail"].ToString();
                //SelectedRowIndex = Convert.ToInt32(currRow["id"]);
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
    }
}
