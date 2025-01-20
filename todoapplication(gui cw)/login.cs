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
    public partial class login : MetroSetForm
    {
        public login()
        {
            InitializeComponent();
            this.txtusername.KeyPress += new KeyPressEventHandler(txtusername_KeyPress);
            this.txtpassword.KeyPress += new KeyPressEventHandler(txtpassword_KeyPress);
        }

        private SqlConnection connection()
        {
            string cs = @"Data Source=HPNotebook; Initial Catalog=taskdb; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            return conn;
        }

        private void logincode()
        {
            try
            {
                if (this.txtusername.Text == "")
                {
                    MetroSetMessageBox.Show(this, "Please Enter the Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (this.txtpassword.Text == "")
                {
                    MetroSetMessageBox.Show(this, "Please Enter the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SqlConnection conn = connection();
                    conn.Open();
                    string sql = "SELECT * FROM [user] WHERE uname = @username AND password = @password";
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.Parameters.AddWithValue("@username", txtusername.Text);
                    com.Parameters.AddWithValue("@password", txtpassword.Text);
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.Read()) // Check if a record is found
                    {
                        dr.Close();
                        string sql2 = "TRUNCATE TABLE login";
                        SqlCommand com2 = new SqlCommand(sql2, conn);
                        com2.ExecuteNonQuery();

                        string sql1 = "INSERT INTO login (username) VALUES (@uname)";
                        SqlCommand com1 = new SqlCommand(sql1, conn);
                        com1.Parameters.AddWithValue("@uname", txtusername.Text);
                        int ret = com1.ExecuteNonQuery();

                        string username = txtusername.Text;
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Username = username;
                        form1.Show();
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, "Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MetroSetMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logincode();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logincode();
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register r1 = new register();
            r1.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logincode();
        }
    }
}
