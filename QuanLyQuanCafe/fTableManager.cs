using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            List<Table> tablelList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tablelList)
            {
                Button btn = new Button() { Width=TableDAO.TableWidth,Height=TableDAO.TableHeigh};
                btn.Text = item.Name + Environment.NewLine+item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;//type obj
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Green;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }



        #region Method
        private void ShowBill(int tableId)
        {
            
        }

        #endregion

        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableId = (sender as Table).ID;
            ShowBill(tableId);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        #endregion
    }
}
