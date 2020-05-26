using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCHeckIn, DateTime? dateCheckOut)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateChekOut = dateChekOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            this.DateChekOut = (DateTime?)row["dateChekOut"];
            this.Status = (int)row["status"];
        }

        private DateTime? dateCheckIn;

        private DateTime? dateChekOut;

        private int status;

        private int id;

        public int Id { get => id; set => id = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateChekOut { get => dateChekOut; set => dateChekOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
