namespace electromiag
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.restingCheckBox = new System.Windows.Forms.CheckBox();
            this.contractionCheckBox = new System.Windows.Forms.CheckBox();
            this.relaxationCheckBox = new System.Windows.Forms.CheckBox();
            this.emgChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spectrumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.emgChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restingCheckBox
            // 
            this.restingCheckBox.AutoSize = true;
            this.restingCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restingCheckBox.Location = new System.Drawing.Point(21, 36);
            this.restingCheckBox.Name = "restingCheckBox";
            this.restingCheckBox.Size = new System.Drawing.Size(93, 29);
            this.restingCheckBox.TabIndex = 1;
            this.restingCheckBox.Text = "Покой";
            this.restingCheckBox.UseVisualStyleBackColor = true;
            this.restingCheckBox.CheckedChanged += new System.EventHandler(this.restingCheckBox_CheckedChanged);
            // 
            // contractionCheckBox
            // 
            this.contractionCheckBox.AutoSize = true;
            this.contractionCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractionCheckBox.Location = new System.Drawing.Point(133, 36);
            this.contractionCheckBox.Name = "contractionCheckBox";
            this.contractionCheckBox.Size = new System.Drawing.Size(149, 29);
            this.contractionCheckBox.TabIndex = 2;
            this.contractionCheckBox.Text = "Сокращение";
            this.contractionCheckBox.UseVisualStyleBackColor = true;
            this.contractionCheckBox.CheckedChanged += new System.EventHandler(this.contractionCheckBox_CheckedChanged);
            // 
            // relaxationCheckBox
            // 
            this.relaxationCheckBox.AutoSize = true;
            this.relaxationCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.relaxationCheckBox.Location = new System.Drawing.Point(288, 36);
            this.relaxationCheckBox.Name = "relaxationCheckBox";
            this.relaxationCheckBox.Size = new System.Drawing.Size(159, 29);
            this.relaxationCheckBox.TabIndex = 3;
            this.relaxationCheckBox.Text = "Расслабление";
            this.relaxationCheckBox.UseVisualStyleBackColor = true;
            this.relaxationCheckBox.CheckedChanged += new System.EventHandler(this.relaxationCheckBox_CheckedChanged);
            // 
            // emgChart
            // 
            this.emgChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emgChart.BackColor = System.Drawing.Color.LightPink;
            chartArea1.Name = "ChartArea1";
            this.emgChart.ChartAreas.Add(chartArea1);
            this.emgChart.Location = new System.Drawing.Point(4, 6);
            this.emgChart.Margin = new System.Windows.Forms.Padding(2);
            this.emgChart.Name = "emgChart";
            this.emgChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            this.emgChart.Series.Add(series1);
            this.emgChart.Size = new System.Drawing.Size(932, 267);
            this.emgChart.TabIndex = 15;
            this.emgChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Электромиаграмма";
            this.emgChart.Titles.Add(title1);
            // 
            // spectrumChart
            // 
            this.spectrumChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spectrumChart.BackColor = System.Drawing.Color.LightPink;
            chartArea2.Name = "ChartArea1";
            this.spectrumChart.ChartAreas.Add(chartArea2);
            this.spectrumChart.Location = new System.Drawing.Point(4, 264);
            this.spectrumChart.Margin = new System.Windows.Forms.Padding(2);
            this.spectrumChart.Name = "spectrumChart";
            this.spectrumChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Name = "Series1";
            this.spectrumChart.Series.Add(series2);
            this.spectrumChart.Size = new System.Drawing.Size(932, 263);
            this.spectrumChart.TabIndex = 16;
            this.spectrumChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Фурье Спектр";
            this.spectrumChart.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выбор Состояния";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 532);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 96);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightPink;
            this.tabPage1.Controls.Add(this.relaxationCheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.restingCheckBox);
            this.tabPage1.Controls.Add(this.contractionCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 70);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Состояние";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightPink;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 70);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Загрузка из файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(947, 628);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.spectrumChart);
            this.Controls.Add(this.emgChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroMiagram";
            ((System.ComponentModel.ISupportInitialize)(this.emgChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox restingCheckBox;
        private System.Windows.Forms.CheckBox contractionCheckBox;
        private System.Windows.Forms.CheckBox relaxationCheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart emgChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart spectrumChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

