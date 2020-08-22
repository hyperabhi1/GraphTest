namespace GraphExperiment
{
    partial class EditUser
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label genderLabel;
            this.healthStatsDataSet = new GraphExperiment.HealthStatsDataSet();
            this.userProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userProfileTableAdapter = new GraphExperiment.HealthStatsDataSetTableAdapters.UserProfileTableAdapter();
            this.tableAdapterManager = new GraphExperiment.HealthStatsDataSetTableAdapters.TableAdapterManager();
            this.userMappingTableAdapter = new GraphExperiment.HealthStatsDataSetTableAdapters.UserMappingTableAdapter();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.userMappingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.healthStatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMappingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            firstNameLabel.Location = new System.Drawing.Point(12, 23);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(108, 19);
            firstNameLabel.TabIndex = 18;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            lastNameLabel.Location = new System.Drawing.Point(12, 69);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(99, 19);
            lastNameLabel.TabIndex = 20;
            lastNameLabel.Text = "Last Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            genderLabel.Location = new System.Drawing.Point(12, 115);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(72, 19);
            genderLabel.TabIndex = 28;
            genderLabel.Text = "Gender:";
            // 
            // healthStatsDataSet
            // 
            this.healthStatsDataSet.DataSetName = "HealthStatsDataSet";
            this.healthStatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userProfileBindingSource
            // 
            this.userProfileBindingSource.DataMember = "UserProfile";
            this.userProfileBindingSource.DataSource = this.healthStatsDataSet;
            // 
            // userProfileTableAdapter
            // 
            this.userProfileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyStatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GraphExperiment.HealthStatsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserMappingTableAdapter = this.userMappingTableAdapter;
            this.tableAdapterManager.UserProfileTableAdapter = this.userProfileTableAdapter;
            // 
            // userMappingTableAdapter
            // 
            this.userMappingTableAdapter.ClearBeforeFill = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(109, 160);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 27);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Save";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.firstNameTextBox.Location = new System.Drawing.Point(161, 21);
            this.firstNameTextBox.MaxLength = 10;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 27);
            this.firstNameTextBox.TabIndex = 19;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.lastNameTextBox.Location = new System.Drawing.Point(161, 67);
            this.lastNameTextBox.MaxLength = 10;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 27);
            this.lastNameTextBox.TabIndex = 21;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderComboBox.Location = new System.Drawing.Point(161, 113);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 27);
            this.genderComboBox.TabIndex = 29;
            // 
            // userMappingBindingSource
            // 
            this.userMappingBindingSource.DataMember = "UserMapping";
            this.userMappingBindingSource.DataSource = this.healthStatsDataSet;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(294, 201);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.MaximumSize = new System.Drawing.Size(310, 240);
            this.MinimumSize = new System.Drawing.Size(310, 240);
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.EditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.healthStatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMappingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HealthStatsDataSet healthStatsDataSet;
        private System.Windows.Forms.BindingSource userProfileBindingSource;
        private HealthStatsDataSetTableAdapters.UserProfileTableAdapter userProfileTableAdapter;
        private HealthStatsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private HealthStatsDataSetTableAdapters.UserMappingTableAdapter userMappingTableAdapter;
        private System.Windows.Forms.BindingSource userMappingBindingSource;
    }
}