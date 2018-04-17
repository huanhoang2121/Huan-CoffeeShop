using CoffeeShopHue.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopHue
{
    public partial class frmSystemManager : Form
    {
        public frmSystemManager()
        {
            InitializeComponent();

            LoadAccountList();
            LoadFoodList();
            LoadDanhmucList();
            LoadBanList();
        }

        void LoadAccountList()
        {
            string query = "Select * from dbo.Account";

            dataGridViewAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadFoodList()
        {
            string query = "Select * from dbo.SanPham";

            dataGridViewFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadDanhmucList()
        {
            string query = "Select * from dbo.DanhMuc";

            dataGridViewDanhmuc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadBanList()
        {
            string query = "Select * from dbo.Ban";

            dataGridViewBan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
