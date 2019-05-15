using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeramecNetFlixProject
{
    public partial class Member : Form
    {
        
        int memberStatus;   // 1 = active, 0 = inactive

        public Member()
        {
            InitializeComponent();

            if(iS253_EmeryDataSet.Member.member_statusColumn.Equals(1))
            {
                rb_active.Checked = true;
            }
            else
            {
                rb_inact.Checked = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iS253_EmeryDataSet);

        }

        private void memberBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iS253_EmeryDataSet);

        }

        private void memberBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iS253_EmeryDataSet);

        }

        private void Member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS253_EmeryDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.iS253_EmeryDataSet.Member);

        }

        private void firstnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_active_CheckedChanged(object sender, EventArgs e)
        {
            memberStatus = 1;
            
        }

        private void rb_inact_CheckedChanged(object sender, EventArgs e)
        {
            memberStatus = 0;
        }
    }
}
