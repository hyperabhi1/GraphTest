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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.weightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.userMappingListBox = new System.Windows.Forms.ListBox();
            this.databasePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weightChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // weightChart
            // 
            chartArea1.Name = "ChartArea1";
            this.weightChart.ChartAreas.Add(chartArea1);
            this.weightChart.Location = new System.Drawing.Point(12, 35);
            this.weightChart.Name = "weightChart";
            this.weightChart.Size = new System.Drawing.Size(1346, 352);
            this.weightChart.TabIndex = 0;
            this.weightChart.Text = "Weight Chart";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonAddUser.Location = new System.Drawing.Point(12, 654);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(95, 25);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(112, 654);
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
            this.buttonDelete.Location = new System.Drawing.Point(216, 654);
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
            this.distanceNumericUpDown.Location = new System.Drawing.Point(426, 654);
            this.distanceNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(70, 24);
            this.distanceNumericUpDown.TabIndex = 14;
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
            this.heightNumericUpDown.Location = new System.Drawing.Point(589, 654);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(70, 24);
            this.heightNumericUpDown.TabIndex = 16;
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
            this.weightNumericUpDown.Location = new System.Drawing.Point(773, 654);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(70, 24);
            this.weightNumericUpDown.TabIndex = 18;
            // 
            // durationNumericUpDown
            // 
            this.durationNumericUpDown.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.durationNumericUpDown.Location = new System.Drawing.Point(962, 654);
            this.durationNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.durationNumericUpDown.Name = "durationNumericUpDown";
            this.durationNumericUpDown.Size = new System.Drawing.Size(70, 24);
            this.durationNumericUpDown.TabIndex = 18;
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
            this.caloriesNumericUpDown.Location = new System.Drawing.Point(1116, 654);
            this.caloriesNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.caloriesNumericUpDown.Name = "caloriesNumericUpDown";
            this.caloriesNumericUpDown.Size = new System.Drawing.Size(70, 24);
            this.caloriesNumericUpDown.TabIndex = 16;
            // 
            // dailyStatusUpdateButton
            // 
            this.dailyStatusUpdateButton.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.dailyStatusUpdateButton.Location = new System.Drawing.Point(330, 654);
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
            this.cancelButton.Location = new System.Drawing.Point(1204, 654);
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
            this.saveButton.Location = new System.Drawing.Point(1288, 654);
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
            this.distanceLabel.Location = new System.Drawing.Point(327, 658);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(96, 17);
            this.distanceLabel.TabIndex = 22;
            this.distanceLabel.Text = "Distance(m)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.heightLabel.Location = new System.Drawing.Point(503, 658);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(80, 17);
            this.heightLabel.TabIndex = 23;
            this.heightLabel.Text = "Height(m)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.weightLabel.Location = new System.Drawing.Point(675, 658);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(88, 17);
            this.weightLabel.TabIndex = 24;
            this.weightLabel.Text = "Weight(Kg)";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.durationLabel.Location = new System.Drawing.Point(860, 658);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(96, 17);
            this.durationLabel.TabIndex = 25;
            this.durationLabel.Text = "Duration(m)";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Consolas", 10.25F, System.Drawing.FontStyle.Bold);
            this.caloriesLabel.Location = new System.Drawing.Point(1038, 658);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(72, 17);
            this.caloriesLabel.TabIndex = 26;
            this.caloriesLabel.Text = "Calories";
            // 
            // userMappingListBox
            // 
            this.userMappingListBox.FormattingEnabled = true;
            this.userMappingListBox.Location = new System.Drawing.Point(12, 399);
            this.userMappingListBox.Name = "userMappingListBox";
            this.userMappingListBox.Size = new System.Drawing.Size(195, 251);
            this.userMappingListBox.TabIndex = 27;
            this.userMappingListBox.SelectedIndexChanged += new System.EventHandler(this.userMappingListBox_SelectedIndexChanged);
            // 
            // databasePictureBox
            // 
            this.databasePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.databasePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("databasePictureBox.Image")));
            this.databasePictureBox.Location = new System.Drawing.Point(213, 438);
            this.databasePictureBox.Name = "databasePictureBox";
            this.databasePictureBox.Size = new System.Drawing.Size(38, 31);
            this.databasePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.databasePictureBox.TabIndex = 29;
            this.databasePictureBox.TabStop = false;
            this.databasePictureBox.Click += new System.EventHandler(this.databasePictureBox_Click);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRefresh.Image = global::GraphExperiment.Properties.Resources.Refresh;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(213, 399);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(38, 33);
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
            this.ClientSize = new System.Drawing.Size(1362, 691);
            this.Controls.Add(this.databasePictureBox);
            this.Controls.Add(this.userMappingListBox);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
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
            this.Controls.Add(this.weightChart);
            this.Controls.Add(this.distanceLabel);
            this.MaximumSize = new System.Drawing.Size(1386, 730);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart weightChart;
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
        private System.Windows.Forms.ListBox userMappingListBox;
        private System.Windows.Forms.PictureBox databasePictureBox;
    }
}