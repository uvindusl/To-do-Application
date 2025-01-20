namespace todoapplication_gui_cw_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.linkviewalltask = new MetroSet_UI.Controls.MetroSetLink();
            this.totalTasksLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkviewprogress = new MetroSet_UI.Controls.MetroSetLink();
            this.inProgressTasksLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetPanel3 = new MetroSet_UI.Controls.MetroSetPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkviewcom = new MetroSet_UI.Controls.MetroSetLink();
            this.completedTasksLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.complete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroSetPanel4 = new MetroSet_UI.Controls.MetroSetPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.testlabal = new MetroSet_UI.Controls.MetroSetLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroSetPanel5 = new MetroSet_UI.Controls.MetroSetPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroSetPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroSetPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroSetPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroSetPanel4.SuspendLayout();
            this.metroSetPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.linkviewalltask);
            this.metroSetPanel1.Controls.Add(this.totalTasksLabel);
            this.metroSetPanel1.Controls.Add(this.pictureBox1);
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(34, 262);
            this.metroSetPanel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(322, 76);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 1;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // linkviewalltask
            // 
            this.linkviewalltask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkviewalltask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkviewalltask.IsDerivedStyle = true;
            this.linkviewalltask.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkviewalltask.Location = new System.Drawing.Point(12, 42);
            this.linkviewalltask.Name = "linkviewalltask";
            this.linkviewalltask.Size = new System.Drawing.Size(192, 23);
            this.linkviewalltask.Style = MetroSet_UI.Enums.Style.Dark;
            this.linkviewalltask.StyleManager = null;
            this.linkviewalltask.TabIndex = 3;
            this.linkviewalltask.TabStop = true;
            this.linkviewalltask.Text = "View All Tasks";
            this.linkviewalltask.ThemeAuthor = "Narwin";
            this.linkviewalltask.ThemeName = "MetroLite";
            this.linkviewalltask.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.linkviewalltask.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metroSetLink1_LinkClicked);
            // 
            // totalTasksLabel
            // 
            this.totalTasksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalTasksLabel.IsDerivedStyle = true;
            this.totalTasksLabel.Location = new System.Drawing.Point(12, 11);
            this.totalTasksLabel.Name = "totalTasksLabel";
            this.totalTasksLabel.Size = new System.Drawing.Size(259, 19);
            this.totalTasksLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.totalTasksLabel.StyleManager = null;
            this.totalTasksLabel.TabIndex = 2;
            this.totalTasksLabel.Text = "Total Task";
            this.totalTasksLabel.ThemeAuthor = "Narwin";
            this.totalTasksLabel.ThemeName = "MetroLite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(276, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.pictureBox2);
            this.metroSetPanel2.Controls.Add(this.linkviewprogress);
            this.metroSetPanel2.Controls.Add(this.inProgressTasksLabel);
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(469, 262);
            this.metroSetPanel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(334, 76);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 2;
            this.metroSetPanel2.ThemeAuthor = "Narwin";
            this.metroSetPanel2.ThemeName = "MetroLite";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(287, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // linkviewprogress
            // 
            this.linkviewprogress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkviewprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkviewprogress.IsDerivedStyle = true;
            this.linkviewprogress.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkviewprogress.Location = new System.Drawing.Point(14, 42);
            this.linkviewprogress.Name = "linkviewprogress";
            this.linkviewprogress.Size = new System.Drawing.Size(192, 23);
            this.linkviewprogress.Style = MetroSet_UI.Enums.Style.Dark;
            this.linkviewprogress.StyleManager = null;
            this.linkviewprogress.TabIndex = 4;
            this.linkviewprogress.TabStop = true;
            this.linkviewprogress.Text = "View In Progress Tasks";
            this.linkviewprogress.ThemeAuthor = "Narwin";
            this.linkviewprogress.ThemeName = "MetroLite";
            this.linkviewprogress.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.linkviewprogress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metroSetLink2_LinkClicked);
            // 
            // inProgressTasksLabel
            // 
            this.inProgressTasksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inProgressTasksLabel.IsDerivedStyle = true;
            this.inProgressTasksLabel.Location = new System.Drawing.Point(14, 11);
            this.inProgressTasksLabel.Name = "inProgressTasksLabel";
            this.inProgressTasksLabel.Size = new System.Drawing.Size(264, 19);
            this.inProgressTasksLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.inProgressTasksLabel.StyleManager = null;
            this.inProgressTasksLabel.TabIndex = 3;
            this.inProgressTasksLabel.Text = "In Progress";
            this.inProgressTasksLabel.ThemeAuthor = "Narwin";
            this.inProgressTasksLabel.ThemeName = "MetroLite";
            // 
            // metroSetPanel3
            // 
            this.metroSetPanel3.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel3.BorderThickness = 1;
            this.metroSetPanel3.Controls.Add(this.pictureBox3);
            this.metroSetPanel3.Controls.Add(this.linkviewcom);
            this.metroSetPanel3.Controls.Add(this.completedTasksLabel);
            this.metroSetPanel3.IsDerivedStyle = true;
            this.metroSetPanel3.Location = new System.Drawing.Point(924, 262);
            this.metroSetPanel3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.metroSetPanel3.Name = "metroSetPanel3";
            this.metroSetPanel3.Size = new System.Drawing.Size(320, 76);
            this.metroSetPanel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel3.StyleManager = null;
            this.metroSetPanel3.TabIndex = 3;
            this.metroSetPanel3.ThemeAuthor = "Narwin";
            this.metroSetPanel3.ThemeName = "MetroLite";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(274, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // linkviewcom
            // 
            this.linkviewcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkviewcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkviewcom.IsDerivedStyle = true;
            this.linkviewcom.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkviewcom.Location = new System.Drawing.Point(12, 42);
            this.linkviewcom.Name = "linkviewcom";
            this.linkviewcom.Size = new System.Drawing.Size(192, 23);
            this.linkviewcom.Style = MetroSet_UI.Enums.Style.Dark;
            this.linkviewcom.StyleManager = null;
            this.linkviewcom.TabIndex = 5;
            this.linkviewcom.TabStop = true;
            this.linkviewcom.Text = "View Completed Tasks";
            this.linkviewcom.ThemeAuthor = "Narwin";
            this.linkviewcom.ThemeName = "MetroLite";
            this.linkviewcom.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.linkviewcom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metroSetLink3_LinkClicked);
            // 
            // completedTasksLabel
            // 
            this.completedTasksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.completedTasksLabel.IsDerivedStyle = true;
            this.completedTasksLabel.Location = new System.Drawing.Point(11, 11);
            this.completedTasksLabel.Name = "completedTasksLabel";
            this.completedTasksLabel.Size = new System.Drawing.Size(242, 19);
            this.completedTasksLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.completedTasksLabel.StyleManager = null;
            this.completedTasksLabel.TabIndex = 4;
            this.completedTasksLabel.Text = "Completed";
            this.completedTasksLabel.ThemeAuthor = "Narwin";
            this.completedTasksLabel.ThemeName = "MetroLite";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complete});
            this.dataGridView1.Location = new System.Drawing.Point(34, 439);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 489);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // complete
            // 
            this.complete.HeaderText = "Complete";
            this.complete.MinimumWidth = 6;
            this.complete.Name = "complete";
            this.complete.Width = 125;
            // 
            // metroSetPanel4
            // 
            this.metroSetPanel4.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel4.BorderThickness = 1;
            this.metroSetPanel4.Controls.Add(this.button5);
            this.metroSetPanel4.Controls.Add(this.searchtxt);
            this.metroSetPanel4.Controls.Add(this.metroSetLabel1);
            this.metroSetPanel4.IsDerivedStyle = true;
            this.metroSetPanel4.Location = new System.Drawing.Point(33, 359);
            this.metroSetPanel4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.metroSetPanel4.Name = "metroSetPanel4";
            this.metroSetPanel4.Size = new System.Drawing.Size(1211, 72);
            this.metroSetPanel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel4.StyleManager = null;
            this.metroSetPanel4.TabIndex = 7;
            this.metroSetPanel4.ThemeAuthor = "Narwin";
            this.metroSetPanel4.ThemeName = "MetroLite";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1075, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 41);
            this.button5.TabIndex = 18;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(705, 15);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(352, 32);
            this.searchtxt.TabIndex = 2;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(24, 15);
            this.metroSetLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(363, 29);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Tasks List";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1183, 0);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 8;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // testlabal
            // 
            this.testlabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testlabal.IsDerivedStyle = true;
            this.testlabal.Location = new System.Drawing.Point(23, 16);
            this.testlabal.Name = "testlabal";
            this.testlabal.Size = new System.Drawing.Size(1138, 41);
            this.testlabal.Style = MetroSet_UI.Enums.Style.Light;
            this.testlabal.StyleManager = null;
            this.testlabal.TabIndex = 9;
            this.testlabal.Text = "metroSetLabel3";
            this.testlabal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.testlabal.ThemeAuthor = "Narwin";
            this.testlabal.ThemeName = "MetroLite";
            // 
            // metroSetPanel5
            // 
            this.metroSetPanel5.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel5.BorderThickness = 1;
            this.metroSetPanel5.Controls.Add(this.button4);
            this.metroSetPanel5.Controls.Add(this.button3);
            this.metroSetPanel5.Controls.Add(this.button2);
            this.metroSetPanel5.Controls.Add(this.button1);
            this.metroSetPanel5.Controls.Add(this.testlabal);
            this.metroSetPanel5.IsDerivedStyle = true;
            this.metroSetPanel5.Location = new System.Drawing.Point(34, 66);
            this.metroSetPanel5.Name = "metroSetPanel5";
            this.metroSetPanel5.Size = new System.Drawing.Size(1210, 158);
            this.metroSetPanel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel5.StyleManager = null;
            this.metroSetPanel5.TabIndex = 13;
            this.metroSetPanel5.ThemeAuthor = "Narwin";
            this.metroSetPanel5.ThemeName = "MetroLite";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(111, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 41);
            this.button4.TabIndex = 17;
            this.button4.Text = "User Account";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(373, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "Update Task";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(650, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add Task";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(928, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1282, 955);
            this.Controls.Add(this.metroSetPanel5);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.metroSetPanel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroSetPanel3);
            this.Controls.Add(this.metroSetPanel2);
            this.Controls.Add(this.metroSetPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(11, 72, 11, 12);
            this.SmallLineColor1 = System.Drawing.Color.Transparent;
            this.SmallLineColor2 = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroSetPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroSetPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroSetPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroSetPanel4.ResumeLayout(false);
            this.metroSetPanel4.PerformLayout();
            this.metroSetPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn complete;
        private MetroSet_UI.Controls.MetroSetLabel testlabal;
        private System.Windows.Forms.Timer timer1;
        private MetroSet_UI.Controls.MetroSetLabel totalTasksLabel;
        private MetroSet_UI.Controls.MetroSetLabel inProgressTasksLabel;
        private MetroSet_UI.Controls.MetroSetLabel completedTasksLabel;
        private MetroSet_UI.Controls.MetroSetLink linkviewalltask;
        private MetroSet_UI.Controls.MetroSetLink linkviewprogress;
        private MetroSet_UI.Controls.MetroSetLink linkviewcom;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button5;
    }
}

