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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.healthStatsDataSet = new GraphExperiment.HealthStatsDataSet();
            this.userMappingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userMappingTableAdapter = new GraphExperiment.HealthStatsDataSetTableAdapters.UserMappingTableAdapter();
            this.tableAdapterManager = new GraphExperiment.HealthStatsDataSetTableAdapters.TableAdapterManager();
            this.userProfileTableAdapter = new GraphExperiment.HealthStatsDataSetTableAdapters.UserProfileTableAdapter();
            this.userMappingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userMappingListBox = new System.Windows.Forms.ListBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.userProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userProfileDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthStatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMappingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMappingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileDataGridView)).BeginInit();
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
            this.chart1.Size = new System.Drawing.Size(1346, 435);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(353, 476);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(80, 23);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // healthStatsDataSet
            // 
            this.healthStatsDataSet.DataSetName = "HealthStatsDataSet";
            this.healthStatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userMappingBindingSource
            // 
            this.userMappingBindingSource.DataMember = "UserMapping";
            this.userMappingBindingSource.DataSource = this.healthStatsDataSet;
            // 
            // userMappingTableAdapter
            // 
            this.userMappingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyStatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GraphExperiment.HealthStatsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserMappingTableAdapter = this.userMappingTableAdapter;
            this.tableAdapterManager.UserProfileTableAdapter = this.userProfileTableAdapter;
            // 
            // userProfileTableAdapter
            // 
            this.userProfileTableAdapter.ClearBeforeFill = true;
            // 
            // userMappingBindingSource1
            // 
            this.userMappingBindingSource1.DataMember = "UserMapping";
            this.userMappingBindingSource1.DataSource = this.healthStatsDataSet;
            // 
            // userMappingListBox
            // 
            this.userMappingListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.healthStatsDataSet, "UserMapping.FirstName", true));
            this.userMappingListBox.DataSource = this.userMappingBindingSource;
            this.userMappingListBox.DisplayMember = "FirstName";
            this.userMappingListBox.Font = new System.Drawing.Font("Consolas", 15.25F, System.Drawing.FontStyle.Bold);
            this.userMappingListBox.FormattingEnabled = true;
            this.userMappingListBox.ItemHeight = 23;
            this.userMappingListBox.Location = new System.Drawing.Point(12, 476);
            this.userMappingListBox.Name = "userMappingListBox";
            this.userMappingListBox.Size = new System.Drawing.Size(123, 211);
            this.userMappingListBox.TabIndex = 3;
            this.userMappingListBox.ValueMember = "UserId";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRefresh.Image = global::GraphExperiment.Properties.Resources.Refresh;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(439, 476);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 4;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // userProfileBindingSource
            // 
            this.userProfileBindingSource.DataMember = "UserProfile";
            this.userProfileBindingSource.DataSource = this.healthStatsDataSet;
            // 
            // userProfileDataGridView
            // 
            this.userProfileDataGridView.AllowUserToAddRows = false;
            this.userProfileDataGridView.AllowUserToDeleteRows = false;
            this.userProfileDataGridView.AllowUserToResizeColumns = false;
            this.userProfileDataGridView.AllowUserToResizeRows = false;
            this.userProfileDataGridView.AutoGenerateColumns = false;
            this.userProfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userProfileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.userProfileDataGridView.DataSource = this.userProfileBindingSource;
            this.userProfileDataGridView.Location = new System.Drawing.Point(545, 476);
            this.userProfileDataGridView.Name = "userProfileDataGridView";
            this.userProfileDataGridView.ReadOnly = true;
            this.userProfileDataGridView.RowHeadersVisible = false;
            this.userProfileDataGridView.Size = new System.Drawing.Size(703, 213);
            this.userProfileDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn4.HeaderText = "Age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Height";
            this.dataGridViewTextBoxColumn5.HeaderText = "Height";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn6.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(353, 505);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit User";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 691);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.userProfileDataGridView);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.userMappingListBox);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.chart1);
            this.MaximumSize = new System.Drawing.Size(1386, 730);
            this.MinimumSize = new System.Drawing.Size(1386, 730);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthStatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMappingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMappingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonAddUser;
        private HealthStatsDataSet healthStatsDataSet;
        private System.Windows.Forms.BindingSource userMappingBindingSource;
        private HealthStatsDataSetTableAdapters.UserMappingTableAdapter userMappingTableAdapter;
        private HealthStatsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource userMappingBindingSource1;
        private System.Windows.Forms.ListBox userMappingListBox;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private HealthStatsDataSetTableAdapters.UserProfileTableAdapter userProfileTableAdapter;
        private System.Windows.Forms.BindingSource userProfileBindingSource;
        private System.Windows.Forms.DataGridView userProfileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button buttonEdit;
    }
}