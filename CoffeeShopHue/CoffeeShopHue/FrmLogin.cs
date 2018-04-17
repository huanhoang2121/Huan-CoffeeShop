using CoffeeShopHue.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopHue
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string PassWord = txtPassWord.Text;
            if (Login(UserName, PassWord))
            {
                FrmSystem f = new FrmSystem();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        bool Login(string UserName, string PassWord)
        {
            return AccountDAO.Instance.Login(UserName, PassWord);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
