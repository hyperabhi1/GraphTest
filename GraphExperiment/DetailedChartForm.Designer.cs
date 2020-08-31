namespace GraphExperiment
{
    partial class DetailedChartForm
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
            this.durationCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.distanceCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.caloriesCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.bmiCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.effortCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.durationLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.bmilabel = new System.Windows.Forms.Label();
            this.effortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // durationCartesianChart
            // 
            this.durationCartesianChart.Location = new System.Drawing.Point(9, 9);
            this.durationCartesianChart.Name = "durationCartesianChart";
            this.durationCartesianChart.Size = new System.Drawing.Size(1345, 125);
            this.durationCartesianChart.TabIndex = 0;
            this.durationCartesianChart.Text = "Duration";
            // 
            // distanceCartesianChart
            // 
            this.distanceCartesianChart.Location = new System.Drawing.Point(9, 149);
            this.distanceCartesianChart.Name = "distanceCartesianChart";
            this.distanceCartesianChart.Size = new System.Drawing.Size(1345, 125);
            this.distanceCartesianChart.TabIndex = 0;
            this.distanceCartesianChart.Text = "Distance";
            // 
            // caloriesCartesianChart
            // 
            this.caloriesCartesianChart.Location = new System.Drawing.Point(9, 289);
            this.caloriesCartesianChart.Name = "caloriesCartesianChart";
            this.caloriesCartesianChart.Size = new System.Drawing.Size(1345, 125);
            this.caloriesCartesianChart.TabIndex = 0;
            this.caloriesCartesianChart.Text = "Calories";
            // 
            // bmiCartesianChart
            // 
            this.bmiCartesianChart.Location = new System.Drawing.Point(9, 429);
            this.bmiCartesianChart.Name = "bmiCartesianChart";
            this.bmiCartesianChart.Size = new System.Drawing.Size(1345, 125);
            this.bmiCartesianChart.TabIndex = 0;
            this.bmiCartesianChart.Text = "BMI";
            // 
            // effortCartesianChart
            // 
            this.effortCartesianChart.Location = new System.Drawing.Point(9, 569);
            this.effortCartesianChart.Name = "effortCartesianChart";
            this.effortCartesianChart.Size = new System.Drawing.Size(1345, 125);
            this.effortCartesianChart.TabIndex = 0;
            this.effortCartesianChart.Text = "Effort";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.BackColor = System.Drawing.SystemColors.Info;
            this.durationLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(1238, 9);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(105, 14);
            this.durationLabel.TabIndex = 1;
            this.durationLabel.Text = "Duration Graph";
            this.durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.BackColor = System.Drawing.SystemColors.Info;
            this.distanceLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(1238, 149);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(105, 14);
            this.distanceLabel.TabIndex = 2;
            this.distanceLabel.Text = "Distance Graph";
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.BackColor = System.Drawing.SystemColors.Info;
            this.caloriesLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(1238, 289);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(105, 14);
            this.caloriesLabel.TabIndex = 2;
            this.caloriesLabel.Text = "Calories Graph";
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bmilabel
            // 
            this.bmilabel.AutoSize = true;
            this.bmilabel.BackColor = System.Drawing.SystemColors.Info;
            this.bmilabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmilabel.Location = new System.Drawing.Point(1273, 429);
            this.bmilabel.Name = "bmilabel";
            this.bmilabel.Size = new System.Drawing.Size(70, 14);
            this.bmilabel.TabIndex = 2;
            this.bmilabel.Text = "BMI Graph";
            this.bmilabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // effortLabel
            // 
            this.effortLabel.AutoSize = true;
            this.effortLabel.BackColor = System.Drawing.SystemColors.Info;
            this.effortLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effortLabel.Location = new System.Drawing.Point(1252, 569);
            this.effortLabel.Name = "effortLabel";
            this.effortLabel.Size = new System.Drawing.Size(91, 14);
            this.effortLabel.TabIndex = 2;
            this.effortLabel.Text = "Effort Graph";
            this.effortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DetailedChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 701);
            this.Controls.Add(this.effortLabel);
            this.Controls.Add(this.bmilabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.effortCartesianChart);
            this.Controls.Add(this.bmiCartesianChart);
            this.Controls.Add(this.caloriesCartesianChart);
            this.Controls.Add(this.distanceCartesianChart);
            this.Controls.Add(this.durationCartesianChart);
            this.MaximumSize = new System.Drawing.Size(1386, 740);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "DetailedChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailedChartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DetailedChartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart durationCartesianChart;
        private LiveCharts.WinForms.CartesianChart distanceCartesianChart;
        private LiveCharts.WinForms.CartesianChart caloriesCartesianChart;
        private LiveCharts.WinForms.CartesianChart bmiCartesianChart;
        private LiveCharts.WinForms.CartesianChart effortCartesianChart;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label bmilabel;
        private System.Windows.Forms.Label effortLabel;
    }
}