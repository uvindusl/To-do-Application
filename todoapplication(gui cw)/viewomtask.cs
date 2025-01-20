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
    public partial class viewomtask : MetroSetForm
    {
        public string username { get; set; }

        public viewomtask()
        {
            InitializeComponent();
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

        private SqlConnection connection()
        {
            string cs = @"Data Source=HPNotebook; Initial Catalog=taskdb; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            return conn;
        }

        private void loadDataToTable()
        {
            SqlConnection conn = connection();
            conn.Open();

            //Define command
            string sql = " SELECT tname, tdate, status, description,time FROM task WHERE status='Completed' AND username=@uname";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@uname", username);

            SqlDataAdapter dp = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dp.Fill(ds);


            this.dataGridView1.DataSource = ds.Tables[0];

            conn.Close();

            CustomizeDataGridView();

        }

        private void viewomtask_Load(object sender, EventArgs e)
        {
            loadDataToTable();
        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Username = username;
            form1.Show();
        }

        private void metroSetButton4_Click(object sender, EventArgs e)
        {
            comtaskreport comtaskreport = new comtaskreport();
            comtaskreport.Show();
        }
    }
}
