using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForm
{
    public partial class Form1 : Form
    {
        SecarchDBClass dbSc;
        public Form1()
        {
            InitializeComponent();
            dbSc = new SecarchDBClass(); // SecarchDBClass의 인스턴스를 생성하여 dbSc에 할당
     }
    

        private void sc_Pdlist_Click(object sender, EventArgs e)
        {
            try
            {
                dbSc.DB_Open();
                sc_list.DataSource = dbSc.PhoneTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = sc_item.Text;

                // SearchDB2Class의 인스턴스 생성
                SearchDB2Class searchDB = new SearchDB2Class();

                // SearchDB2Class의 DB_Open 메서드 호출
                searchDB.DB_Open();

                DataView dv = searchDB.PhoneTable.DefaultView;
                dv.RowFilter = $"PRODUCT_NAME = '{itemName}'";

                //sc_hold.DataSource = dv;

                string productId = string.Empty;
                if (dv.Count > 0)
                {
                    productId = dv[0]["PRODUCT_ID"].ToString();

                    // SearchDB2Class의 ShopTable을 이용하여 필터링
                    DataView shopView = new DataView(searchDB.ShopTable);
                    shopView.RowFilter = $"PRODUCT_ID = '{productId}'";

                    sc_hold.DataSource = shopView;
                }
                else
                {
                    MessageBox.Show("해당하는 제품이 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_hold_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 클릭한 셀의 행 인덱스를 가져옵니다.
                int rowIndex = e.RowIndex;

                // 만약 유효한 행이라면
                if (rowIndex >= 0 && rowIndex < sc_hold.Rows.Count)
                {
                    // 클릭한 행에서 PRODUCT_ID 값을 가져옵니다.
                    string productId = sc_hold.Rows[rowIndex].Cells["PRODUCT_ID"].Value.ToString();

                    // sc_Productid 텍스트 박스에 PRODUCT_ID 값을 할당합니다.
                    sc_Productid.Text = productId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 클릭한 셀의 행 인덱스를 가져옵니다.
                int rowIndex = e.RowIndex;

                // 만약 유효한 행이라면
                if (rowIndex >= 0 && rowIndex < sc_list.Rows.Count)
                {
                    // 클릭한 행에서 PRODUCT_ID 값을 가져옵니다.
                    string productId = sc_list.Rows[rowIndex].Cells["PRODUCT_ID"].Value.ToString();

                    // sc_Productid 텍스트 박스에 PRODUCT_ID 값을 할당합니다.
                    sc_Productid.Text = productId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_Pdin_Click(object sender, EventArgs e)
        {

        }

        private void sc_basket_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<string> productIds = new List<string>();

        private void sc_in_Click(object sender, EventArgs e)
        {
            try
            {
                string productId = sc_Productid.Text;
                productIds.Add(productId);

                // SearchDB2Class의 인스턴스 생성
                SearchDB2Class searchDB = new SearchDB2Class();

                // SearchDB2Class의 DB_Open 메서드 호출
                searchDB.DB_Open();

                // 누적된 모든 PRODUCT_ID 값 필터링
                string filterExpression = string.Join(" OR ", productIds.Select(id => $"PRODUCT_ID = '{id}'"));
                DataView basketView = new DataView(searchDB.ShopTable);
                basketView.RowFilter = filterExpression;

                // sc_basket DataGridView에 필터링된 데이터 표시
                sc_basket.DataSource = basketView.ToTable(); // DataView를 DataTable로 변환하여 표시
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sc_clear_Click(object sender, EventArgs e)
        {
            try
            {
                // sc_basket DataGridView에 있는 데이터를 삭제
                ((DataTable)sc_basket.DataSource).Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
