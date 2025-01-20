using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace todoapplication_gui_cw_
{
    public partial class Form1 : MetroSetForm
    {

        public string Username { get; set; }
        private Timer notificationTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeNotificationTimer();
        }



        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

        private const uint EM_SETCUEBANNER = 0x1501;

        private void SetWatermark(System.Windows.Forms.TextBox textBox, string watermarkText)
        {
            if (textBox != null && textBox.Handle != IntPtr.Zero)
            {
                SendMessage(textBox.Handle, EM_SETCUEBANNER, (IntPtr)1, watermarkText);
            }
        }

        private void InitializeNotificationTimer()
        {
            notificationTimer = new Timer();
            notificationTimer.Interval = 60000; // Check every minute
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = connection())
                {
                    conn.Open();
                    string sql = @"
                SELECT tname, description 
                FROM task 
                WHERE status = 'In Progress' 
                AND tdate = @today 
                AND ABS(DATEDIFF(MINUTE, @currentTime, time)) <= 1";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@today", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@currentTime", DateTime.Now.ToString("HH:mm"));

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string taskName = dr["tname"].ToString();
                                string description = dr["description"].ToString();
                                ShowNotification(taskName, description);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowNotification(string taskName, string description)
        {
            MetroSetMessageBox.Show(this,
                $"Task Due: {taskName}\nDescription: {description}",
                "Task Notification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void CheckForDueTasks()
        {
            try
            {
                using (SqlConnection conn = connection())
                {
                    conn.Open();
                    string sql = @"
            SELECT tname, description 
            FROM task 
            WHERE status = 'In Progress' 
            AND tdate = @today 
            AND ABS(DATEDIFF(MINUTE, @currentTime, time)) <= 1";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@today", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@currentTime", DateTime.Now.ToString("HH:mm"));

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string taskName = dr["tname"].ToString();
                                string description = dr["description"].ToString();
                                ShowNotification(taskName, description);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            loadDataToTable();
            SetupAutoCompleteForSearchTxt();
            SetWatermark(searchtxt, "Search tasks by name...");
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            getnameoftheuser();
            CheckForDueTasks();
            GetTaskCounts();
        }

        private void getnameoftheuser()
        {
            SqlConnection conn = connection();
            conn.Open();
            string query = "SELECT name FROM [user] WHERE uname=@uname";
            SqlCommand com = new SqlCommand(query, conn);
            com.Parameters.AddWithValue("@uname", Username);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            string name = Convert.ToString(dr.GetValue(0));
            string greeting = GetGreeting();
            this.testlabal.Text = $"{greeting}, {name}";
            dr.Close();
            
        }

        private string GetGreeting()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 5 && hour < 12)
            {
                return "Good Morning";
            }
            else if (hour >= 12 && hour < 17)
            {
                return "Good Afternoon";
            }
            else if (hour >= 17 && hour < 21)
            {
                return "Good Evening";
            }
            else
            {
                return "Good Night";
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void AddTaskForm_TaskAdded(object sender, EventArgs e)
        {
            // After a task is added, reload the data
            loadDataToTable();
            GetTaskCounts();
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
            string sql = " SELECT tname, tdate, status, description,time FROM task WHERE status='In Progress' AND username=@uname";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@uname", Username);

            SqlDataAdapter dp = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dp.Fill(ds);


            this.dataGridView1.DataSource = ds.Tables[0];

            conn.Close();

            CustomizeDataGridView();

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


        private void SetupAutoCompleteForSearchTxt()
        {
            try
            {
                using (SqlConnection conn = connection())
                {
                    conn.Open();

                    // SQL Query to fetch distinct task names (tname)
                    string sql = "SELECT DISTINCT tname FROM task WHERE status='In Progress' AND username=@uname";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uname", Username);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                            while (dr.Read())
                            {
                                autoCompleteData.Add(dr["tname"].ToString());
                            }

                            // Configure the TextBox for AutoComplete
                            searchtxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                            searchtxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            searchtxt.AutoCompleteCustomSource = autoCompleteData;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = connection())
                {
                    conn.Open();

                    // Define the SQL query
                    string sql = "SELECT tname, tdate, status, description,time FROM task WHERE tname = @tnam AND username=@uname";
                    using (SqlCommand com = new SqlCommand(sql, conn))
                    {
                        com.Parameters.AddWithValue("@tnam", this.searchtxt.Text);
                        com.Parameters.AddWithValue("@uname", Username);

                        // Use DataAdapter to fill the DataGridView
                        SqlDataAdapter dap = new SqlDataAdapter(com);
                        DataSet ds = new DataSet();
                        dap.Fill(ds);
                        this.dataGridView1.DataSource = ds.Tables[0];
                    }
                }

                // Customize the DataGridView after loading data
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            loadDataToTable();
            GetTaskCounts();
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure it's a checkbox column
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                string taskName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["tname"].Value);

                // Update the task status in the database
                UpdateTaskStatusInDatabase(taskName, isChecked);
            }
        }


        private void UpdateTaskStatusInDatabase(string tname, bool isChecked)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=HPNotebook; Initial Catalog=taskdb; Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "UPDATE task SET status = @status WHERE tname = @tname";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", isChecked ? "Completed" : "In Progress");
                        cmd.Parameters.AddWithValue("@tname", tname);
                        cmd.ExecuteNonQuery();
                    }

                    string sql2 = "INSERT INTO ctask (tname,cdatetime,uname) VALUES (@tname,@cdatetime,@uname)";
                    using (SqlCommand cmd2 = new SqlCommand(sql2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@tname", tname);
                        cmd2.Parameters.AddWithValue("@cdatetime", DateTime.Now);
                        cmd2.Parameters.AddWithValue("@uname", Username);
                        cmd2.ExecuteNonQuery();
                    }

                    string sql3 = "DELETE FROM [ptask] WHERE tname=@tname AND uname=@uname";
                    using (SqlCommand cmd3 = new SqlCommand(sql3, conn))
                    {
                        cmd3.Parameters.AddWithValue("@tname", tname);
                        cmd3.Parameters.AddWithValue("@uname", Username);
                        cmd3.ExecuteNonQuery();
                    }
                }


                // Reload data after update
                loadDataToTable();
                GetTaskCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating task status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetTaskCounts()
        {
            try
            {
                using (SqlConnection conn = connection())
                {
                    conn.Open();

                    // Query to get the total count, completed count, and in-progress count
                    string sql = @"
                 SELECT 
                (SELECT COUNT(*) FROM task WHERE username = @uname) AS TotalTasks,
                (SELECT COUNT(*) FROM task WHERE status = 'Completed' AND username = @uname) AS CompletedTasks,
                (SELECT COUNT(*) FROM task WHERE status = 'In Progress' AND username = @uname) AS InProgressTasks";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@uname", Username);

                        // Execute the query and read the results
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int totalTasks = Convert.ToInt32(dr["TotalTasks"]);
                                int completedTasks = Convert.ToInt32(dr["CompletedTasks"]);
                                int inProgressTasks = Convert.ToInt32(dr["InProgressTasks"]);

                                // Update the labels or UI controls with the counts
                                this.totalTasksLabel.Text = $"Total Tasks: {totalTasks}";
                                this.completedTasksLabel.Text = $"Completed Tasks: {completedTasks}";
                                this.inProgressTasksLabel.Text = $"In Progress Tasks: {inProgressTasks}";

                                if (totalTasks == 0)
                                {
                                    this.linkviewalltask.Enabled = false;
                                }
                                else
                                {
                                    this.linkviewalltask.Enabled = true;
                                }

                                if (completedTasks == 0)
                                {
                                    this.linkviewcom.Enabled = false;
                                }
                                else
                                {
                                    this.linkviewcom.Enabled = true;
                                }

                                if (inProgressTasks == 0)
                                {
                                    this.linkviewprogress.Enabled = false;
                                }
                                else
                                {
                                    this.linkviewprogress.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching task counts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroSetButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void metroSetLink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewallreports viewallreports = new viewallreports();
            viewallreports.username = Username;
            viewallreports.Show();
            this.Hide();
        }

        private void metroSetLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewprogrsstask viewprogrsstask = new viewprogrsstask();
            viewprogrsstask.username = Username;
            viewprogrsstask.Show();
            this.Hide();
        }

        private void metroSetLink3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewomtask viewomtasks = new viewomtask();
            viewomtasks.username = Username;
            viewomtasks.Show();
            this.Hide();
        }

        private void metroSetButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addtask addtask = new addtask();
            addtask.username = Username;
            addtask.TaskAdded += AddTaskForm_TaskAdded;
            addtask.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatetask update = new updatetask();
            update.username = Username;
            update.updatetasks += AddTaskForm_TaskAdded;
            update.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.username = Username;
            settings.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadDataToTable();
            GetTaskCounts();
        }
    }
}
    


