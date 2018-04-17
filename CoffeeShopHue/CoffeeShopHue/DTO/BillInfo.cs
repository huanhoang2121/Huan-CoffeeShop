using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopHue.DTO
{
    public class BillInfo
    {
        private int iD;
        private int billID;
        private int foodID;
        private int count;

        public BillInfo(int id, int billID, int foodID,  int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.BillID = (int)row["SoHoaDon"];
            this.FoodID = (int)row["MaSanPham"];
            this.Count = (int)row["SoLuong"];
        }
        
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
