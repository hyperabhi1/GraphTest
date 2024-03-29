﻿namespace GraphExperiment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.durationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caloriesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dailyStatusUpdateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.specifyTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setTimeButton = new System.Windows.Forms.Button();
            this.userProfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.weightCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.detailGraphButton = new System.Windows.Forms.Button();
            this.weightlbl = new System.Windows.Forms.Label();
            this.cumulativeDetailGraphButton = new System.Windows.Forms.Button();
            this.compareGraphButton = new System.Windows.Forms.Button();
            this.databasePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonAddUser.Location = new System.Drawing.Point(9, 671);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(95, 25);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(109, 671);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 25);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit User";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(209, 671);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 25);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete User";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.distanceNumericUpDown.Location = new System.Drawing.Point(399, 672);
            this.distanceNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.distanceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(60, 24);
            this.distanceNumericUpDown.TabIndex = 14;
            this.distanceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.DecimalPlaces = 2;
            this.heightNumericUpDown.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.heightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.heightNumericUpDown.Location = new System.Drawing.Point(532, 672);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.heightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(60, 24);
            this.heightNumericUpDown.TabIndex = 16;
            this.heightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.DecimalPlaces = 2;
            this.weightNumericUpDown.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.weightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.weightNumericUpDown.Location = new System.Drawing.Point(673, 672);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.weightNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(60, 24);
            this.weightNumericUpDown.TabIndex = 18;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // durationNumericUpDown
            // 
            this.durationNumericUpDown.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.durationNumericUpDown.Location = new System.Drawing.Point(823, 672);
            this.durationNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.durationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationNumericUpDown.Name = "durationNumericUpDown";
            this.durationNumericUpDown.Size = new System.Drawing.Size(60, 24);
            this.durationNumericUpDown.TabIndex = 18;
            this.durationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // caloriesNumericUpDown
            // 
            this.caloriesNumericUpDown.DecimalPlaces = 2;
            this.caloriesNumericUpDown.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.caloriesNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.caloriesNumericUpDown.Location = new System.Drawing.Point(951, 672);
            this.caloriesNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.caloriesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.caloriesNumericUpDown.Name = "caloriesNumericUpDown";
            this.caloriesNumericUpDown.Size = new System.Drawing.Size(60, 24);
            this.caloriesNumericUpDown.TabIndex = 16;
            this.caloriesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dailyStatusUpdateButton
            // 
            this.dailyStatusUpdateButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.dailyStatusUpdateButton.Location = new System.Drawing.Point(320, 671);
            this.dailyStatusUpdateButton.Name = "dailyStatusUpdateButton";
            this.dailyStatusUpdateButton.Size = new System.Drawing.Size(377, 25);
            this.dailyStatusUpdateButton.TabIndex = 19;
            this.dailyStatusUpdateButton.Text = "Hi ##########! wanna update today\'s status?";
            this.dailyStatusUpdateButton.UseVisualStyleBackColor = true;
            this.dailyStatusUpdateButton.Visible = false;
            this.dailyStatusUpdateButton.Click += new System.EventHandler(this.dailyStatusUpdateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(1212, 671);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 25);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(1285, 671);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 25);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.distanceLabel.Location = new System.Drawing.Point(308, 674);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(96, 17);
            this.distanceLabel.TabIndex = 22;
            this.distanceLabel.Text = "Distance(m)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.heightLabel.Location = new System.Drawing.Point(457, 674);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(80, 17);
            this.heightLabel.TabIndex = 23;
            this.heightLabel.Text = "Height(m)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.weightLabel.Location = new System.Drawing.Point(590, 674);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(88, 17);
            this.weightLabel.TabIndex = 24;
            this.weightLabel.Text = "Weight(Kg)";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.durationLabel.Location = new System.Drawing.Point(732, 674);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(96, 17);
            this.durationLabel.TabIndex = 25;
            this.durationLabel.Text = "Duration(m)";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.caloriesLabel.Location = new System.Drawing.Point(882, 675);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(72, 17);
            this.caloriesLabel.TabIndex = 26;
            this.caloriesLabel.Text = "Calories";
            // 
            // specifyTimeDateTimePicker
            // 
            this.specifyTimeDateTimePicker.CustomFormat = "yyyy-MMM-dd HH:mm:ss";
            this.specifyTimeDateTimePicker.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.specifyTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.specifyTimeDateTimePicker.Location = new System.Drawing.Point(1025, 672);
            this.specifyTimeDateTimePicker.Name = "specifyTimeDateTimePicker";
            this.specifyTimeDateTimePicker.Size = new System.Drawing.Size(181, 24);
            this.specifyTimeDateTimePicker.TabIndex = 30;
            // 
            // setTimeButton
            // 
            this.setTimeButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.setTimeButton.Location = new System.Drawing.Point(1025, 671);
            this.setTimeButton.Name = "setTimeButton";
            this.setTimeButton.Size = new System.Drawing.Size(181, 25);
            this.setTimeButton.TabIndex = 31;
            this.setTimeButton.Text = "Specify Time";
            this.setTimeButton.UseVisualStyleBackColor = true;
            this.setTimeButton.Click += new System.EventHandler(this.setTimeButton_Click);
            // 
            // userProfilesDataGridView
            // 
            this.userProfilesDataGridView.AllowUserToAddRows = false;
            this.userProfilesDataGridView.AllowUserToDeleteRows = false;
            this.userProfilesDataGridView.AllowUserToResizeColumns = false;
            this.userProfilesDataGridView.AllowUserToResizeRows = false;
            this.userProfilesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userProfilesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userProfilesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userProfilesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userProfilesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.userProfilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userProfilesDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.userProfilesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userProfilesDataGridView.Location = new System.Drawing.Point(71, 639);
            this.userProfilesDataGridView.Name = "userProfilesDataGridView";
            this.userProfilesDataGridView.ReadOnly = true;
            this.userProfilesDataGridView.RowHeadersVisible = false;
            this.userProfilesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userProfilesDataGridView.Size = new System.Drawing.Size(1284, 25);
            this.userProfilesDataGridView.TabIndex = 32;
            this.userProfilesDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userProfilesDataGridView_ColumnHeaderMouseClick);
            // 
            // weightCartesianChart
            // 
            this.weightCartesianChart.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.weightCartesianChart.Location = new System.Drawing.Point(9, 9);
            this.weightCartesianChart.Name = "weightCartesianChart";
            this.weightCartesianChart.Size = new System.Drawing.Size(1345, 609);
            this.weightCartesianChart.TabIndex = 33;
            this.weightCartesianChart.Text = "Weight Chart";
            // 
            // detailGraphButton
            // 
            this.detailGraphButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.detailGraphButton.Location = new System.Drawing.Point(983, 671);
            this.detailGraphButton.Name = "detailGraphButton";
            this.detailGraphButton.Size = new System.Drawing.Size(137, 25);
            this.detailGraphButton.TabIndex = 34;
            this.detailGraphButton.Text = "Detail Graph";
            this.detailGraphButton.UseVisualStyleBackColor = true;
            this.detailGraphButton.Visible = false;
            this.detailGraphButton.Click += new System.EventHandler(this.detailedGraphButton_Click);
            // 
            // weightlbl
            // 
            this.weightlbl.AutoSize = true;
            this.weightlbl.BackColor = System.Drawing.SystemColors.Info;
            this.weightlbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightlbl.Location = new System.Drawing.Point(1247, 9);
            this.weightlbl.Name = "weightlbl";
            this.weightlbl.Size = new System.Drawing.Size(91, 14);
            this.weightlbl.TabIndex = 35;
            this.weightlbl.Text = "Weight Graph";
            this.weightlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cumulativeDetailGraphButton
            // 
            this.cumulativeDetailGraphButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.cumulativeDetailGraphButton.Location = new System.Drawing.Point(1126, 671);
            this.cumulativeDetailGraphButton.Name = "cumulativeDetailGraphButton";
            this.cumulativeDetailGraphButton.Size = new System.Drawing.Size(229, 25);
            this.cumulativeDetailGraphButton.TabIndex = 36;
            this.cumulativeDetailGraphButton.Text = "Cumulative Detail Graph";
            this.cumulativeDetailGraphButton.UseVisualStyleBackColor = true;
            this.cumulativeDetailGraphButton.Visible = false;
            this.cumulativeDetailGraphButton.Click += new System.EventHandler(this.cumulativeDetailGraphButton_Click);
            // 
            // compareGraphButton
            // 
            this.compareGraphButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.compareGraphButton.Location = new System.Drawing.Point(849, 671);
            this.compareGraphButton.Name = "compareGraphButton";
            this.compareGraphButton.Size = new System.Drawing.Size(128, 25);
            this.compareGraphButton.TabIndex = 37;
            this.compareGraphButton.Text = "Compare Graph";
            this.compareGraphButton.UseVisualStyleBackColor = true;
            this.compareGraphButton.Visible = false;
            this.compareGraphButton.Click += new System.EventHandler(this.compareGraphButton_Click);
            // 
            // databasePictureBox
            // 
            this.databasePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.databasePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("databasePictureBox.Image")));
            this.databasePictureBox.Location = new System.Drawing.Point(40, 639);
            this.databasePictureBox.Name = "databasePictureBox";
            this.databasePictureBox.Size = new System.Drawing.Size(25, 25);
            this.databasePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.databasePictureBox.TabIndex = 29;
            this.databasePictureBox.TabStop = false;
            this.databasePictureBox.Click += new System.EventHandler(this.databasePictureBox_Click);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRefresh.Image = global::GraphExperiment.Properties.Resources.Refresh;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(9, 639);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 4;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 701);
            this.Controls.Add(this.compareGraphButton);
            this.Controls.Add(this.cumulativeDetailGraphButton);
            this.Controls.Add(this.weightlbl);
            this.Controls.Add(this.detailGraphButton);
            this.Controls.Add(this.weightCartesianChart);
            this.Controls.Add(this.userProfilesDataGridView);
            this.Controls.Add(this.setTimeButton);
            this.Controls.Add(this.specifyTimeDateTimePicker);
            this.Controls.Add(this.databasePictureBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dailyStatusUpdateButton);
            this.Controls.Add(this.distanceNumericUpDown);
            this.Controls.Add(this.caloriesNumericUpDown);
            this.Controls.Add(this.heightNumericUpDown);
            this.Controls.Add(this.durationNumericUpDown);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.caloriesLabel);
            this.MaximumSize = new System.Drawing.Size(1386, 740);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfilesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.NumericUpDown durationNumericUpDown;
        private System.Windows.Forms.NumericUpDown caloriesNumericUpDown;
        private System.Windows.Forms.Button dailyStatusUpdateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.PictureBox databasePictureBox;
        private System.Windows.Forms.DateTimePicker specifyTimeDateTimePicker;
        private System.Windows.Forms.Button setTimeButton;
        private System.Windows.Forms.DataGridView userProfilesDataGridView;
        private LiveCharts.WinForms.CartesianChart weightCartesianChart;
        private System.Windows.Forms.Button detailGraphButton;
        private System.Windows.Forms.Label weightlbl;
        private System.Windows.Forms.Button cumulativeDetailGraphButton;
        private System.Windows.Forms.Button compareGraphButton;
    }
}