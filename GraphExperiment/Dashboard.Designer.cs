namespace GraphExperiment
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.userMappingListBox = new System.Windows.Forms.ListBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.userProfileDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.latestProfileDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latestProfileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 35);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1346, 404);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(213, 656);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(80, 23);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // userMappingListBox
            // 
            this.userMappingListBox.DisplayMember = "UserId";
            this.userMappingListBox.Font = new System.Drawing.Font("Consolas", 15.25F, System.Drawing.FontStyle.Bold);
            this.userMappingListBox.FormattingEnabled = true;
            this.userMappingListBox.ItemHeight = 23;
            this.userMappingListBox.Location = new System.Drawing.Point(12, 445);
            this.userMappingListBox.Name = "userMappingListBox";
            this.userMappingListBox.Size = new System.Drawing.Size(195, 234);
            this.userMappingListBox.TabIndex = 3;
            this.userMappingListBox.SelectedIndexChanged += new System.EventHandler(this.userMappingListBox_SelectedIndexChanged);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRefresh.Image = global::GraphExperiment.Properties.Resources.Refresh;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(213, 445);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 4;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // userProfileDataGridView
            // 
            this.userProfileDataGridView.AllowUserToAddRows = false;
            this.userProfileDataGridView.AllowUserToDeleteRows = false;
            this.userProfileDataGridView.AllowUserToResizeColumns = false;
            this.userProfileDataGridView.AllowUserToResizeRows = false;
            this.userProfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userProfileDataGridView.Location = new System.Drawing.Point(878, 561);
            this.userProfileDataGridView.Name = "userProfileDataGridView";
            this.userProfileDataGridView.ReadOnly = true;
            this.userProfileDataGridView.RowHeadersVisible = false;
            this.userProfileDataGridView.Size = new System.Drawing.Size(480, 118);
            this.userProfileDataGridView.TabIndex = 4;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(299, 656);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit User";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(385, 656);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete User";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // latestProfileDataGridView
            // 
            this.latestProfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.latestProfileDataGridView.Location = new System.Drawing.Point(878, 445);
            this.latestProfileDataGridView.Name = "latestProfileDataGridView";
            this.latestProfileDataGridView.Size = new System.Drawing.Size(480, 110);
            this.latestProfileDataGridView.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 691);
            this.Controls.Add(this.latestProfileDataGridView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.userProfileDataGridView);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.userMappingListBox);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.chart1);
            this.MaximumSize = new System.Drawing.Size(1386, 730);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latestProfileDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ListBox userMappingListBox;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.DataGridView userProfileDataGridView;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView latestProfileDataGridView;
    }
}