using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MeramecNetFlixProject.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = "Data Source = mc-sluggo.stlcc.edu; Initial Catalog = IS253_Emery; Persist Security Info = True; User ID = emery; Password = emery";

            SqlCommand scmd = new SqlCommand("select count (*) as itemCount from Member where login_name=@usr and password=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", tb_uName.Text);
            scmd.Parameters.AddWithValue("@pwd", tb_pWord.Text);
            scn.Open();
            
            if(scmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Access granted");
            }
            scn.Close();
        }
    }
}
