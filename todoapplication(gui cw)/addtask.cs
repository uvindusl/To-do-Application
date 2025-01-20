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
    public partial class addtask : MetroSetForm
    {

        public event EventHandler TaskAdded;
        public string username { get; set; }

        public addtask()
        {
            InitializeComponent();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private SqlConnection connection()
        {
            string cs = @"Data Source=HPNotebook; Initial Catalog=taskdb; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            return conn;
        }

        private void savetask()
        {
            try
            {
                if(tnametxt.Text == "")
                {
                    MetroSetMessageBox.Show(this, "Please Enter the Task Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(date.Text == "")
                {
                    MetroSetMessageBox.Show(this, "Please Enter the Task Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(timepick.Text == "")
                {
                    MetroSetMessageBox.Show(this, "Please Enter the Task Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DateTime dt = Convert.ToDateTime(timepick.Value);

                    SqlConnection conn = connection();
                    conn.Open();
                    string sql = "INSERT INTO task (tname,tdate,status,description,username,time) VALUES (@tname,@tdate,@status,@description,@uname,@time)";
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.Parameters.AddWithValue("@tname", tnametxt.Text);
                    com.Parameters.AddWithValue("@tdate", DateTime.Parse(date.Text).ToString("yyyy-MM-dd"));
                    com.Parameters.AddWithValue("@status", "In Progress");
                    com.Parameters.AddWithValue("@description", descriptiontxt.Text);
                    com.Parameters.AddWithValue("@uname", username);
                    com.Parameters.AddWithValue("@time", dt.ToShortTimeString());
                    int ret = com.ExecuteNonQuery();
                    string sql1 = "INSERT INTO ptask (tname,uname) VALUES (@tname,@uname)";
                    SqlCommand com1 = new SqlCommand(sql1, conn);
                    com1.Parameters.AddWithValue("@tname", tnametxt.Text);
                    com1.Parameters.AddWithValue("@uname", username);
                    com1.ExecuteNonQuery();
                    if (ret >= 1)
                    {
                        MetroSetMessageBox.Show(this, "Task Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OnTaskAdded(EventArgs.Empty);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add Task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }

        protected virtual void OnTaskAdded(EventArgs e)
        {
            TaskAdded?.Invoke(this, e);
        }


        private void savetaskbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savetask();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
