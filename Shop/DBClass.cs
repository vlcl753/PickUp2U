using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Shop
{
    public class DBClass
    {
        private OracleDataAdapter dBAdapter;
        private DataSet dS;
        private DataTable phoneTable;
        private OracleCommandBuilder myCommandBuilder;
        private int selectedRowIndex;

        public int SelectedRowIndex
        {
            get { return selectedRowIndex; }
            set
            { selectedRowIndex = value; }
        }
        public OracleDataAdapter DBAdapter
        {
            get { return dBAdapter; }
            set { dBAdapter = value; }
        }


        public DataTable PhoneTable { get { return phoneTable; } }

        public DBClass()
        {
            // 생성자에서 초기화
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "SELECT * FROM shop";
                //string commandString = "SELECT shop_name, shop_location FROM shop"; 
                dBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);
                dS = new DataSet();
                dBAdapter.Fill(dS, "shop");
                phoneTable = dS.Tables["shop"];


            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public void DB_Open_Product()
        {
            try
            {
                string connectionString = "User Id=admin; Password=admin; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "SELECT * FROM PRODUCT";
                dBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(dBAdapter);
                dS = new DataSet();
                dBAdapter.Fill(dS, "product"); // "product"라는 이름으로 DataSet에 채움
                                               // PRODUCT 테이블에 대한 DataTable을 phoneTable에 설정
                phoneTable = dS.Tables["product"];
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }


        public void DB_Open()
        {
            // 여기에 추가적인 데이터베이스 작업을 위한 코드 추가 가능
        }

        public DataSet DS { get { return dS; } set { dS = value; } }

    }

}