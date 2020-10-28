using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Manager
{
    public partial class addStaff : Form
    {
        Models.StaffMod mod = new Models.StaffMod();
        public addStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string birth = dtpBirth.Value.ToString("yyyy/MM/dd");
            string Sex = "";
            if (robMale.Checked == true)
            {
                Sex = robMale.Text.ToString();
            }
            if (robFemale.Checked == true)
            {
                Sex = robFemale.Text.ToString();
            }
            if (robOther.Checked == true)
            {
                Sex = robOther.Text.ToString();
            }
            string id = txtID.Text;
            string phone = txtPhone.Text;
            string mail = txtMail.Text;
            string addr = txtAddress.Text;
            if (fname != "" && lname != "" && id != "" && addr != "")
            {
                mod.addStaff(fname, lname, birth, Sex, id, phone, mail, addr);
                Close();
            }
        }
    }
}
