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
                dbc.DB_Open(); 
                DBGrid.DataSource = dbc.PhoneTable.DefaultView; 
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
                    shop_id.Text = "매장번호 = " + selectedRow["shop_id"].ToString();

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

                
                int newShopId = maxShopId + 1;

                
                string shopName = txtid.Text;
                string shopLocation = txtName.Text;
                string shopNumber = txtNumber.Text;
                

                
                DataRow newRow = dbc.PhoneTable.NewRow();
                newRow["SHOP_ID"] = newShopId.ToString();
                newRow["PRODUCT_ID"] = DBNull.Value; // NULL
                newRow["SHOP_NAME"] = shopName;
                newRow["SHOP_NUMBER"] = shopNumber;
                newRow["SHOP_LOCATION"] = shopLocation;


                dbc.PhoneTable.Rows.Add(newRow); 

                
                dbc.DBAdapter.Update(dbc.DS, "shop");

                
                dbc.DB_Open(); 
                DBGrid.DataSource = dbc.PhoneTable.DefaultView; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Shop_DelBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(shop_id.Text))
            {
                MessageBox.Show("삭제할 매장번호를 선택하세요.");
                return;
            }
            try
            {
                if (!string.IsNullOrEmpty(shop_id.Text))
                {
                    string selectedShopId = shop_id.Text.Replace("매장번호 = ", ""); 

                    DataRow[] rows = dbc.PhoneTable.Select($"SHOP_ID = {selectedShopId}"); 

                    if (rows.Length > 0)
                    {
                        rows[0].Delete();

                        
                        dbc.DBAdapter.Update(dbc.DS, "shop");

                        
                        dbc.DB_Open(); 
                        DBGrid.DataSource = dbc.PhoneTable.DefaultView; 
                    }
                    else
                    {
                        MessageBox.Show("해당 매장번호를 찾을 수 없습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("삭제할 매장번호를 선택하세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Shop_UdBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(shop_id.Text) || string.IsNullOrWhiteSpace(txtid.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("값이 비어있습니다. 값을 입력하세요.");
                return;
            }

            string selectedShopId = shop_id.Text.Replace("매장번호 = ", "");

            DataRow[] rows = dbc.PhoneTable.Select($"SHOP_ID = {selectedShopId}"); 

            if (rows.Length > 0)
            {
                rows[0]["SHOP_NAME"] = txtid.Text;
                rows[0]["SHOP_NUMBER"] = txtNumber.Text;
                rows[0]["SHOP_LOCATION"] = txtName.Text;

                
                dbc.DBAdapter.Update(dbc.DS, "shop");

               
                dbc.DB_Open(); 
                DBGrid.DataSource = dbc.PhoneTable.DefaultView; 
            }
            else
            {
                MessageBox.Show("해당 매장번호를 찾을 수 없습니다.");
            }
        }


        // ↑ SHOP 관리  ↓PRODUCT 관리

        private void Product_list_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Open_Product(); // Product 데이터 가져오기
                DBGrid_PD.DataSource = dbc.PhoneTable.DefaultView; // Product 데이터를 DBGrid_PD에 바인딩
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
