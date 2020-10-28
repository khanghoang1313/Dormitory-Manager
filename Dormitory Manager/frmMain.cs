using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dormitory_Manager
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void AddUC(Control cr)
        {
            cr.Dock = DockStyle.Fill;
            fluentMain.Controls.Clear();
            fluentMain.Controls.Add(cr);
        }

        private void aceRoominfo_Click(object sender, EventArgs e)
        {
            UC_Room a = new UC_Room();
            AddUC(a);
        }

        private void aceService_Click(object sender, EventArgs e)
        {
            UC_Service a = new UC_Service();
            AddUC(a);
        }

        private void aceHistory_Click(object sender, EventArgs e)
        {
            UC_History a = new UC_History();
            AddUC(a);
        }

        private void aceCustomerinfo_Click(object sender, EventArgs e)
        {
            UC_Customerinfo a = new UC_Customerinfo();
            AddUC(a);
        }

        private void aceTenacyList_Click(object sender, EventArgs e)
        {
            UC_TenacyList a = new UC_TenacyList();
            AddUC(a);
        }

        private void aceDesposit_Click(object sender, EventArgs e)
        {
            UC_Desposit a = new UC_Desposit();
            AddUC(a);
        }

        private void aceCheck_Click(object sender, EventArgs e)
        {
            UC_Check a = new UC_Check();
            AddUC(a);
        }

        private void aceStaffinfo_Click(object sender, EventArgs e)
        {
            UC_Staffinfo a = new UC_Staffinfo();
            AddUC(a);
        }
    }
}
