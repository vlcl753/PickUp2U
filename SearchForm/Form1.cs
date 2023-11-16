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
                // sc_item에서 값을 가져오는 예시입니다. 여기서 sc_item은 어떻게 값을 가져오는지에 따라 코드가 달라질 수 있습니다.
                string itemName = sc_item.Text; // sc_item에서 텍스트 값을 가져온다고 가정합니다.

                dbSc.DB_Open(); // 데이터베이스를 연결하고
                DataView dv = dbSc.PhoneTable.DefaultView;
                dv.RowFilter = $"PRODUCT_NAME = '{itemName}'"; // 원하는 값으로 필터링합니다.

                // 필터링된 데이터를 새로운 DataGridView에 표시합니다. sc_hold는 DataGridView의 이름입니다.
                sc_hold.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
