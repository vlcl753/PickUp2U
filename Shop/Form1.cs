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
                    txtNumber.Text = selectedRow["shop_Number"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Shop_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int maxShopId = 0;

                // SHOP_ID의 최대값 찾기
                foreach (DataRow row in dbc.PhoneTable.Rows)
                {
                    int currentId;
                    if (int.TryParse(row["SHOP_ID"].ToString(), out currentId))
                    {
                        if (currentId > maxShopId)
                        {
                            maxShopId = currentId;
                        }
                    }
                }

                // 새로운 SHOP_ID 생성 - 이전 최대값 다음 숫자로
                int newShopId = maxShopId + 1;

                // 값 가져오기
                string shopName = txtid.Text;
                string shopLocation = txtName.Text;
                string shopNumber = txtNumber.Text;

                // 새로운 행 추가
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["SHOP_ID"] = newShopId.ToString();
                newRow["PRODUCT_ID"] = DBNull.Value; // NULL로 지정
                newRow["SHOP_NAME"] = shopName;
                newRow["SHOP_NUMBER"] = shopNumber;
                newRow["SHOP_LOCATION"] = shopLocation;

                dbc.PhoneTable.Rows.Add(newRow); // 새 행을 DataTable에 추가

                // 변경 사항을 데이터베이스에 반영
                dbc.DBAdapter.Update(dbc.DS, "shop");

                // 삽입 후 그리드 갱신
                dbc.DB_Open(); // 데이터 가져오기
                DBGrid.DataSource = dbc.PhoneTable.DefaultView; // 데이터를 그리드에 바인딩
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
