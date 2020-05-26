using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new BillInfoDAO();
                } return BillInfoDAO.instance;
            }
            private set => instance = value;
        }

        public BillInfoDAO() { }
    }
}
