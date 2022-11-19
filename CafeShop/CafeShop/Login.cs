using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CafeShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == " ")
            {
                MessageBox.Show("Enter Username : ");
            }
            else if(txtPass.Text == " ")
            {
                MessageBox.Show("Enter Password :";
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
