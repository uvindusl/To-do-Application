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
    public partial class updatetask : MetroSetForm
    {
        public event EventHandler updatetasks;
        public string username { get; set; }

        public updatetask()
        {
            InitializeComponent();
        }

        private SqlConnection connection()
        {
            string cs = @"Data Source=HPNotebook; Initial Catalog=taskdb; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            return conn;
        }

        

        private void updatetask_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT tname FROM task WHERE status='In Progress' AND username=@uname ";
            SqlCommand com = new SqlCommand(query, conn);
            com.Parameters.AddWithValue("@uname", username);

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                combotaskname.Items.Add(dr["tname"].ToString());
            }
            combotaskname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            combotaskname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combotaskname.AutoCompleteSource = AutoCompleteSource.ListItems;

            conn.Close();
        }

        private void combotaskname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT tdate,description,time FROM task WHERE tname=@tname";
            SqlCommand com = new SqlCommand(query, conn);
            com.Parameters.AddWithValue("@tname", this.combotaskname.Text);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            this.date.Value = dr["tdate"] != DBNull.Value ? Convert.ToDateTime(dr["tdate"]) : DateTime.Now;
            TimeSpan timeValue = (TimeSpan)dr["time"];
            this.timepick.Value = DateTime.Today.Add(timeValue);
            this.descriptiontxt.Text = dr["description"].ToString();

            dr.Close();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void update()
        {
            if (combotaskname.Text == "")
            {
                MetroSetMessageBox.Show(this, "Please Enter the Task Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (date.Text == "")
            {
                MetroSetMessageBox.Show(this, "Please Enter the Task Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (timepick.Text == "")
            {
                MetroSetMessageBox.Show(this, "Please Enter the Task Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = connection();
            conn.Open();
            string query = "UPDATE task SET tdate=@tdate,description=@description,time=@time WHERE tname=@tname";
            SqlCommand com = new SqlCommand(query, conn);
            com.Parameters.AddWithValue("@tdate", DateTime.Parse(date.Text).ToString("yyyy-MM-dd"));
            com.Parameters.AddWithValue("@description", descriptiontxt.Text);
            com.Parameters.AddWithValue("@time", timepick.Value.TimeOfDay);
            com.Parameters.AddWithValue("@tname", combotaskname.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("Task Updated Successfully");
            updatetasksadd(EventArgs.Empty);
            this.Close();
            conn.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void updatetasksadd(EventArgs e)
        {
            updatetasks?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
