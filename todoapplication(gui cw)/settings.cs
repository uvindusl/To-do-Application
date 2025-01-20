using MetroSet_UI.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace todoapplication_gui_cw_
{
    public partial class settings : MetroSetForm
    {
        public string username { get; set; }
        public settings()
        {
            InitializeComponent();
        }

        private SqlConnection connection()
        {
            string cs = @"Data Source=HPNotebook; Initial Catalog=taskdb; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            return conn;
        }

        public void loaduserdata()
        {
            this.txtusername.Text = username;
            string cs = @"Data Source=HPNotebook; Initial Catalog=taskdb; Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                string sql = "SELECT name,email,phoneno FROM [user] WHERE uname = @uname";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@uname", username);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    txtname.Text = reader["name"].ToString();
                    txtemail.Text = reader["email"].ToString();
                    txtphone.Text = reader["phoneno"].ToString();
                }
                conn.Close();
            }
            
        }

        private void settings_Load(object sender, EventArgs e)
        {
            loaduserdata();
            loadDataToTable();
            
        }

        private void CustomizeDataGridView()
        {
            // Align headers
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Align text in all columns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Auto-size columns and rows
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Optional: Adjust column widths to fill the grid
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add row headers if needed
            dataGridView1.RowHeadersVisible = true;
        }

        private void loadDataToTable()
        {
            SqlConnection conn = connection();
            conn.Open();

            //Define command
            string sql = " SELECT tname, tdate, status, description,time FROM task WHERE username=@uname";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@uname", username);

            SqlDataAdapter dp = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dp.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];

            conn.Close();

            CustomizeDataGridView();

        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Username = username;
            f1.Show();
        }

        private void update()
        {
            try
            {
                String email = this.txtemail.Text;
                int atops = email.IndexOf("@");
                int dotops = email.LastIndexOf(".");

                string no = this.txtphone.Text;

                if (txtname.Text == "")
                {
                    MessageBox.Show("Please Enter the Name");
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Please Enter the Email");
                }
                else if (atops < 1 || dotops + 2 >= email.Length || atops + 2 > dotops)
                {
                    MessageBox.Show("Please Enter a valid Email");
                }
                else if (txtphone.Text == "")
                {
                    MessageBox.Show("Please Enter the Phone Number");
                }
                else if (no.Length != 10)
                {
                    MessageBox.Show("Please Enter a valid Phone Number");
                }
                else
                {
                    SqlConnection conn = connection();
                    conn.Open();
                    string sql = "UPDATE [user] SET name=@name,email=@email,phoneno=@phone WHERE uname=@uname";
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.Parameters.AddWithValue("@name", txtname.Text);
                    com.Parameters.AddWithValue("@email", txtemail.Text);
                    com.Parameters.AddWithValue("@phone", txtphone.Text);
                    com.Parameters.AddWithValue("@uname", username);
                    int ret = com.ExecuteNonQuery();
                    if (ret >= 1)
                    {
                        MetroSetMessageBox.Show(this, "User Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, "Failed to Update User Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
                
            }
            catch (Exception ex)
            {
                MetroSetMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete()
        {
            try
            {
                SqlConnection conn = connection();
                conn.Open();
                string sql = "DELETE FROM [user] WHERE uname=@uname";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@uname", username);
                int ret = com.ExecuteNonQuery();
                if (ret >= 1)
                {
                    MetroSetMessageBox.Show(this, "User Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    login l = new login();
                    l.Show();
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Failed to Delete User Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MetroSetMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletetasks()
        {
            try
            {
                SqlConnection conn = connection();
                conn.Open();
                string sql = "DELETE  FROM [task] WHERE username=@uname";
                string sql2 = "DELETE  FROM [ctask] WHERE uname=@uname";
                string sql3 = "DELETE  FROM [ptask] WHERE uname=@uname";
                SqlCommand com2 = new SqlCommand(sql2, conn);
                SqlCommand com3 = new SqlCommand(sql3 , conn);
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@uname", username);
                com2.Parameters.AddWithValue("@uname", username);
                com3.Parameters.AddWithValue("@uname", username);
                int ret = com.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                com3.ExecuteNonQuery();
                if (ret >= 1)
                {
                    MetroSetMessageBox.Show(this, "User Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataToTable();
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Failed to Delete User Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MetroSetMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete();
            deletetasks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deletetasks();
        }
    }
}
