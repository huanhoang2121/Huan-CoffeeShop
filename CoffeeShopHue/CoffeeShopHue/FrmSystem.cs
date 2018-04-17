using CoffeeShopHue.DAO;
using CoffeeShopHue.DTO;
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
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();

            LoadTable();
        }

        #region Method

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightPink;
                        break;
                    default:
                        btn.BackColor = Color.LightYellow;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }      

        void ShowBill(int id)
        {
            //lsvBill.Items.Clear();
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUncheckBillIDByTableID(id));

            foreach (BillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodID.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                //lsvBill.Items.Add(lsvItem);
            }
        }

        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID =((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount();
            f.ShowDialog();
        }

        private void loggingSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemManager f = new frmSystemManager();
            f.ShowDialog();
        }

        private void FrmSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion

      
    }
}
