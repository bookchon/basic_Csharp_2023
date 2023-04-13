using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_bookrentalsho
{
    public partial class FrmLogin : Form
    {
        private bool isLogined = false;  
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            isLogined = LoginProcess();  // 로그인을 성공해야만 true가 됨

            if (isLogined)
            {
                this.Close();
            }
            else
            {
                return; 
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Environment.Exit(0); // 가장 완벽하게 프로그램을 종료시킴
        }


        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogined != true) // 로그인 안 되었을 때 창을 닫으면 프로그램 모두 종료
            {
                Environment.Exit(0);
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터 키를 누르면
            {
                BtnLogin_Click(sender, e);
            }
        }

        // DB UserTbl에서 정보확인 로그인 처리
        private bool LoginProcess()
        {
            // Validation check
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("유저 아이디를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("비밀번호를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string strUserId = "";
            string strPassword = "";
            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345;";
                // DB 처리
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    #region < DB쿼리를 위한 구성 >
                    string selQuery = @"SELECT userId
                                             , password
                                          FROM usertbl
                                         WHERE userID = @userID
                                           AND password = @password";
                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);
                    // @userID, @password 파라미터 할당
                    MySqlParameter prmUserId = new MySqlParameter("@userID", TxtUserId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@Password", TxtPassword.Text);
                    selCmd.Parameters.Add(prmUserId);
                    selCmd.Parameters.Add(prmPassword);
                    #endregion

                    MySqlDataReader reader = selCmd.ExecuteReader(); // 실행한 다음 userId, password
                    reader.Read();

                    strUserId = reader["userId"] != null ? reader["userId"].ToString() : "-";
                    strPassword = reader["password"] != null ? reader["password"].ToString() : "--";

                    return true;
                }
                MessageBox.Show(@"{strUserId} / {strPassword}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }
    }
}
