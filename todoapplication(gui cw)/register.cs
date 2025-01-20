using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todoapplication_gui_cw_
{
    public partial class register : MetroSetForm
    {
        public register()
        {
            InitializeComponent();
        }

        private SqlConnection connection()
        {
            string cs = @"Data Source=HPNotebook; Initial Catalog=taskdb; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            return conn;
        }

        private void registercode()
        {
            String email = this.txtemail.Text;
            int atops = email.IndexOf("@");
            int dotops = email.LastIndexOf(".");

            string no = this.txtphoneno.Text;

            if(txtname.Text == "")
            {
                MessageBox.Show("Please Enter the Name");
            }
            else if(txtemail.Text == "")
            {
                MessageBox.Show("Please Enter the Email");
            }
            else if (atops < 1 || dotops + 2 >= email.Length || atops + 2 > dotops)
            {
                MessageBox.Show("Please Enter a valid Email");
            }
            else if (txtphoneno.Text == "")
            {
                MessageBox.Show("Please Enter the Phone Number");
            }
            else if (no.Length != 10)
            {
                MessageBox.Show("Please Enter a valid Phone Number");
            }
            else if (txtpasword.Text == "")
            {
                MessageBox.Show("Please Enter the Password");
            }
            else if (txtpasword.Text.Length < 8)
            {
                MessageBox.Show("Password must be atleast 8 characters long");
            }
            else if(txtconpass.Text == "")
            {
                MessageBox.Show("Please Enter the Confirm Password");
            }
            else if(txtpasword.Text != txtconpass.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                SqlConnection conn = connection();
                conn.Open();
                string sql = "INSERT INTO [user] (uname,email,phoneno,password,name) VALUES (@uname,@email,@phoneno,@password,@name)";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@uname", txtusername.Text);
                com.Parameters.AddWithValue("@email", txtemail.Text);
                com.Parameters.AddWithValue("@phoneno", txtphoneno.Text);
                com.Parameters.AddWithValue("@password", txtpasword.Text);
                com.Parameters.AddWithValue("@name", txtname.Text);
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registration Successful");
                this.Close();
                login login = new login();
                login.Show();
            }
        }

        private void txtphoneno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            registercode();
        }

        private void checkpass1_CheckedChanged(object sender, EventArgs e)
        {
            txtpasword.UseSystemPasswordChar = !checkpass1.Checked;
        }

        private void checkpass2_CheckedChanged(object sender, EventArgs e)
        {
            txtconpass.UseSystemPasswordChar = !checkpass2.Checked;
        }

        private void metroSetLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registercode();
        }
    }
}
