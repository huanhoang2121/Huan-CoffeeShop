using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopHue.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckOut;
        private int status;

        public Bill(int id, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row[0];

            var dateCheckOutTemp = row[1];
            if(dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.Status = (int)row[3];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
