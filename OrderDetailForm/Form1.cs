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

namespace OrderDetailForm
{
    public partial class Form1 : Form
    {
        private int SelectedRowIndex;
        private void showList_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";

                // SQL 쿼리 수정
                string commandString = "SELECT ORDER_ID, PAYMENT_DATE, TOTAL_AMOUNT FROM payment";

                using (OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString))
                {
                    DataSet DS = new DataSet();
                    DBAdapter.Fill(DS, "payment");

                    // DBGrid 설정 (DataGridView)
                    // 예: 자동 열 생성
                    DBGrid.AutoGenerateColumns = true;

                    DBGrid.DataSource = DS.Tables["payment"].DefaultView;
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
