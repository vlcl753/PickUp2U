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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int maxUserId = 0;

                foreach (DataRow row in dbu.UserTable.Rows)
                {
                    int currentId;
                    if (int.TryParse(row["USER_ID"].ToString(), out currentId))
                    {
                        if (currentId > maxUserId)
                        {
                            maxUserId = currentId;
                        }
                    }
                }

                int newUserId = maxUserId + 1;

                string userId = user_id.Text;
                string userName = user_name.Text;
                string userGrade = user_grade.Text;
                string userPw = user_pw.Text;
                string userType = user_type.Text;
                string userPhone = user_phone.Text;
                string userEmail = uesr_email.Text;

                DataRow newRow = dbu.UserTable.NewRow();
                newRow["USER_ID"] = newUserId; // 변경된 부분: ID 컬럼에 새로운 값 할당
                newRow["USER_NAME"] = userName;
                newRow["ID"] = userName.ToString();
                newRow["MEMBERSHIP_ID"] = userGrade;
                newRow["PASSWORD"] = userPw; // PASSWORD 컬럼
                newRow["USER_TYPE"] = userType;
                newRow["PHONE_NUM"] = userPhone;
                newRow["EMAIL"] = userEmail;

                dbu.UserTable.Rows.Add(newRow);

                dbu.DBAdapter.Update(dbu.DS, "\"USER\""); // 수정된 데이터를 데이터베이스에 반영

                dbu.DB_Open(); // 데이터베이스 연결 열기
                DBGrid.DataSource = dbu.UserTable.DefaultView; // 그리드에 데이터 바인딩
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // user_num label에서 유저 번호 가져오기
                string userNumber = user_num.Text.Replace("유저 번호 = ", "");

                // 데이터베이스 테이블에서 해당 유저 번호에 해당하는 행 찾기
                DataRow[] rows = dbu.UserTable.Select($"USER_ID = '{userNumber}'");

                if (rows.Length > 0)
                {
                    // 데이터 삭제
                    rows[0].Delete();

                    // 변경 사항을 데이터베이스에 업데이트
                    dbu.DBAdapter.Update(dbu.DS, "\"USER\"");

                    // 데이터베이스 열기 및 그리드 업데이트
                    dbu.DB_Open();
                    DBGrid.DataSource = dbu.UserTable.DefaultView;

                    MessageBox.Show("데이터가 성공적으로 삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("해당 유저 번호를 찾을 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void user_update_Click(object sender, EventArgs e)
        {
            try
            {
                // user_num label에서 유저 번호 가져오기
                string userNumber = user_num.Text.Replace("유저 번호 = ", "");

                // 데이터베이스 테이블에서 해당 유저 번호에 해당하는 행 찾기
                DataRow[] rows = dbu.UserTable.Select($"USER_ID = '{userNumber}'");

                if (rows.Length > 0)
                {
                    // 수정할 데이터 가져오기
                    string userName = user_name.Text;
                    string userGrade = user_grade.Text;
                    string userPw = user_pw.Text;
                    string userType = user_type.Text;
                    string userPhone = user_phone.Text;
                    string userEmail = uesr_email.Text;

                    // 데이터 수정
                    rows[0]["USER_NAME"] = userName;
                    rows[0]["MEMBERSHIP_ID"] = userGrade;
                    rows[0]["PASSWORD"] = userPw;
                    rows[0]["USER_TYPE"] = userType;
                    rows[0]["PHONE_NUM"] = userPhone;
                    rows[0]["EMAIL"] = userEmail;

                    // 데이터베이스에 변경 사항 반영
                    dbu.DBAdapter.Update(dbu.DS, "\"USER\"");

                    // 데이터베이스 열기 및 그리드 업데이트
                    dbu.DB_Open();
                    DBGrid.DataSource = dbu.UserTable.DefaultView;

                    MessageBox.Show("데이터가 성공적으로 업데이트되었습니다.");
                }
                else
                {
                    MessageBox.Show("선택된 유저 번호에 해당하는 데이터를 찾을 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
