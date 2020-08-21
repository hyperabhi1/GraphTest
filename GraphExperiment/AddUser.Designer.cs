namespace GraphExperiment
{
    partial class AddUser
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
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label genderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.healthStatsDataSet = new GraphExperiment.HealthStatsDataSet();
            this.userProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userProfileTableAdapter = new GraphExperiment.HealthStatsDataSetTableAdapters.UserProfileTableAdapter();
            this.tableAdapterManager = new GraphExperiment.HealthStatsDataSetTableAdapters.TableAdapterManager();
            this.userProfileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userProfileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            userIdLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.healthStatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingNavigator)).BeginInit();
            this.userProfileBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            userIdLabel.Location = new System.Drawing.Point(8, 50);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(81, 19);
            userIdLabel.TabIndex = 1;
            userIdLabel.Text = "User Id:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            firstNameLabel.Location = new System.Drawing.Point(8, 96);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(108, 19);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            lastNameLabel.Location = new System.Drawing.Point(8, 142);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(99, 19);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            ageLabel.Location = new System.Drawing.Point(8, 188);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(45, 19);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "Age:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            heightLabel.Location = new System.Drawing.Point(8, 234);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(72, 19);
            heightLabel.TabIndex = 9;
            heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            weightLabel.Location = new System.Drawing.Point(8, 280);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(72, 19);
            weightLabel.TabIndex = 11;
            weightLabel.Text = "Weight:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            genderLabel.Location = new System.Drawing.Point(8, 326);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(72, 19);
            genderLabel.TabIndex = 13;
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
            this.tableAdapterManager.UpdateOrder = GraphExperiment.HealthStatsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserProfileTableAdapter = this.userProfileTableAdapter;
            // 
            // userProfileBindingNavigator
            // 
            this.userProfileBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userProfileBindingNavigator.BindingSource = this.userProfileBindingSource;
            this.userProfileBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userProfileBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userProfileBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userProfileBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.toolStripProgressBar1});
            this.userProfileBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userProfileBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userProfileBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userProfileBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userProfileBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userProfileBindingNavigator.Name = "userProfileBindingNavigator";
            this.userProfileBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userProfileBindingNavigator.Size = new System.Drawing.Size(294, 25);
            this.userProfileBindingNavigator.TabIndex = 0;
            this.userProfileBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userProfileBindingNavigatorSaveItem
            // 
            this.userProfileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userProfileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userProfileBindingNavigatorSaveItem.Image")));
            this.userProfileBindingNavigatorSaveItem.Name = "userProfileBindingNavigatorSaveItem";
            this.userProfileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userProfileBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 15);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProfileBindingSource, "UserId", true));
            this.userIdTextBox.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.userIdTextBox.Location = new System.Drawing.Point(157, 48);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(121, 27);
            this.userIdTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProfileBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.firstNameTextBox.Location = new System.Drawing.Point(157, 94);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(121, 27);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProfileBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.lastNameTextBox.Location = new System.Drawing.Point(157, 140);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(121, 27);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userProfileBindingSource, "Age", true));
            this.ageNumericUpDown.DecimalPlaces = 2;
            this.ageNumericUpDown.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.ageNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ageNumericUpDown.Location = new System.Drawing.Point(157, 186);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(121, 27);
            this.ageNumericUpDown.TabIndex = 8;
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userProfileBindingSource, "Height", true));
            this.heightNumericUpDown.DecimalPlaces = 2;
            this.heightNumericUpDown.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.heightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.heightNumericUpDown.Location = new System.Drawing.Point(157, 232);
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(121, 27);
            this.heightNumericUpDown.TabIndex = 10;
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userProfileBindingSource, "Weight", true));
            this.weightNumericUpDown.DecimalPlaces = 2;
            this.weightNumericUpDown.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.weightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.weightNumericUpDown.Location = new System.Drawing.Point(157, 278);
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(121, 27);
            this.weightNumericUpDown.TabIndex = 12;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProfileBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(157, 324);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 27);
            this.genderComboBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(heightLabel);
            this.Controls.Add(this.heightNumericUpDown);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.userProfileBindingNavigator);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.healthStatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingNavigator)).EndInit();
            this.userProfileBindingNavigator.ResumeLayout(false);
            this.userProfileBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HealthStatsDataSet healthStatsDataSet;
        private System.Windows.Forms.BindingSource userProfileBindingSource;
        private HealthStatsDataSetTableAdapters.UserProfileTableAdapter userProfileTableAdapter;
        private HealthStatsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userProfileBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userProfileBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button button1;
    }
}