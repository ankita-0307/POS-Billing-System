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

namespace demo3
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxShowPass.Checked == false)
            {
                txtPass.PasswordChar = '*';
            }
            else
            {
                txtPass.PasswordChar = '\0';
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection connstring = new SqlConnection("Data Source=LAPTOP-QQ6IARCN\\SQLEXPRESS;Initial Catalog=BSC;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Admin_Registration_db]
           ([firstname]
           ,[lastname]
           ,[username]
           ,[password])
     VALUES
           ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtUserName.Text + "', '" + txtPass.Text + "')", connstring);
            connstring.Open();
            cmd.ExecuteNonQuery();
            connstring.Close();
            MessageBox.Show("Registration Successful");
        }
    }
}
