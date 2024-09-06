namespace Software_Temperatura
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbUsers = new System.Windows.Forms.PictureBox();
            this.ptbSensores = new System.Windows.Forms.PictureBox();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.pnlSensores = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tmrTemps = new System.Windows.Forms.Timer(this.components);
            this.tmrSaveTemps = new System.Windows.Forms.Timer(this.components);
            this.chrSensor1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnS1Z2 = new Software_Temperatura.Controls.ToggleButtons();
            this.btnS1Z1 = new Software_Temperatura.Controls.ToggleButtons();
            this.chrSensor2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            this.pnlSensores.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ptbUsers);
            this.panel1.Controls.Add(this.ptbSensores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 56);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1061, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ptbUsers
            // 
            this.ptbUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbUsers.Location = new System.Drawing.Point(143, -1);
            this.ptbUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbUsers.Name = "ptbUsers";
            this.ptbUsers.Size = new System.Drawing.Size(152, 58);
            this.ptbUsers.TabIndex = 1;
            this.ptbUsers.TabStop = false;
            this.ptbUsers.Click += new System.EventHandler(this.ptbUsers_Click);
            this.ptbUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbUsers_Paint);
            // 
            // ptbSensores
            // 
            this.ptbSensores.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbSensores.Location = new System.Drawing.Point(-1, -1);
            this.ptbSensores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbSensores.Name = "ptbSensores";
            this.ptbSensores.Size = new System.Drawing.Size(143, 58);
            this.ptbSensores.TabIndex = 0;
            this.ptbSensores.TabStop = false;
            this.ptbSensores.Click += new System.EventHandler(this.ptbSensores_Click);
            this.ptbSensores.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbSensores_Paint);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlUsuarios.Controls.Add(this.pnlSensores);
            this.pnlUsuarios.Controls.Add(this.btnAdd);
            this.pnlUsuarios.Controls.Add(this.txtUsuarios);
            this.pnlUsuarios.Controls.Add(this.dtgvUsuarios);
            this.pnlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsuarios.Location = new System.Drawing.Point(0, 56);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(1099, 499);
            this.pnlUsuarios.TabIndex = 1;
            // 
            // pnlSensores
            // 
            this.pnlSensores.AutoScroll = true;
            this.pnlSensores.BackColor = System.Drawing.Color.White;
            this.pnlSensores.Controls.Add(this.button1);
            this.pnlSensores.Controls.Add(this.panel3);
            this.pnlSensores.Controls.Add(this.panel2);
            this.pnlSensores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSensores.ForeColor = System.Drawing.Color.Black;
            this.pnlSensores.Location = new System.Drawing.Point(0, 0);
            this.pnlSensores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSensores.Name = "pnlSensores";
            this.pnlSensores.Size = new System.Drawing.Size(1099, 499);
            this.pnlSensores.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar Temperaturas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.btnS1Z2);
            this.panel3.Controls.Add(this.chrSensor2);
            this.panel3.Location = new System.Drawing.Point(15, 224);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 178);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1048, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "°";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(988, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 17);
            this.label24.TabIndex = 13;
            this.label24.Text = "label24";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnS1Z1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.chrSensor1);
            this.panel2.Location = new System.Drawing.Point(15, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 178);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1048, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "°";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(988, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "label19";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.Image = global::Software_Temperatura.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(1044, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 32);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.Color.Silver;
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarios.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuarios.Location = new System.Drawing.Point(16, 17);
            this.txtUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(985, 26);
            this.txtUsuarios.TabIndex = 1;
            this.txtUsuarios.Text = "Buscar ";
            this.txtUsuarios.TextChanged += new System.EventHandler(this.txtUsuarios_TextChanged);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(16, 57);
            this.dtgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 51;
            this.dtgvUsuarios.Size = new System.Drawing.Size(1069, 410);
            this.dtgvUsuarios.TabIndex = 0;
            this.dtgvUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellEnter);
            // 
            // tmrTemps
            // 
            this.tmrTemps.Interval = 1000;
            this.tmrTemps.Tick += new System.EventHandler(this.tmrTemps_Tick);
            // 
            // tmrSaveTemps
            // 
            this.tmrSaveTemps.Interval = 500;
            this.tmrSaveTemps.Tick += new System.EventHandler(this.tmrSaveTemps_Tick);
            // 
            // chrSensor1
            // 
            this.chrSensor1.BackColor = System.Drawing.Color.Transparent;
            this.chrSensor1.BorderSkin.PageColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chrSensor1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chrSensor1.Legends.Add(legend2);
            this.chrSensor1.Location = new System.Drawing.Point(3, -27);
            this.chrSensor1.Name = "chrSensor1";
            this.chrSensor1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.DarkSlateGray;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerSize = 6;
            series2.Name = "Sensor 1";
            series2.ShadowColor = System.Drawing.Color.White;
            series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series2.SmartLabelStyle.Enabled = false;
            this.chrSensor1.Series.Add(series2);
            this.chrSensor1.Size = new System.Drawing.Size(1018, 205);
            this.chrSensor1.TabIndex = 15;
            this.chrSensor1.Text = "chart1";
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.BackSecondaryColor = System.Drawing.Color.Transparent;
            title2.ForeColor = System.Drawing.Color.Transparent;
            title2.Name = "Sensor 1";
            title2.ShadowColor = System.Drawing.Color.Transparent;
            this.chrSensor1.Titles.Add(title2);
            // 
            // btnS1Z2
            // 
            this.btnS1Z2.AutoSize = true;
            this.btnS1Z2.Location = new System.Drawing.Point(1016, 2);
            this.btnS1Z2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnS1Z2.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnS1Z2.Name = "btnS1Z2";
            this.btnS1Z2.OffBackColor = System.Drawing.Color.Gray;
            this.btnS1Z2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnS1Z2.OnBackColor = System.Drawing.Color.Green;
            this.btnS1Z2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnS1Z2.Size = new System.Drawing.Size(45, 22);
            this.btnS1Z2.TabIndex = 7;
            this.btnS1Z2.UseVisualStyleBackColor = true;
            this.btnS1Z2.CheckedChanged += new System.EventHandler(this.btnS1Z2_CheckedChanged);
            // 
            // btnS1Z1
            // 
            this.btnS1Z1.AutoSize = true;
            this.btnS1Z1.Location = new System.Drawing.Point(1016, 2);
            this.btnS1Z1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnS1Z1.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnS1Z1.Name = "btnS1Z1";
            this.btnS1Z1.OffBackColor = System.Drawing.Color.Gray;
            this.btnS1Z1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnS1Z1.OnBackColor = System.Drawing.Color.Green;
            this.btnS1Z1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnS1Z1.Size = new System.Drawing.Size(45, 22);
            this.btnS1Z1.TabIndex = 7;
            this.btnS1Z1.UseVisualStyleBackColor = true;
            this.btnS1Z1.CheckedChanged += new System.EventHandler(this.btnS1Z1_CheckedChanged);
            // 
            // chrSensor2
            // 
            this.chrSensor2.BackColor = System.Drawing.Color.Transparent;
            this.chrSensor2.BorderSkin.PageColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chrSensor2.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chrSensor2.Legends.Add(legend1);
            this.chrSensor2.Location = new System.Drawing.Point(3, -20);
            this.chrSensor2.Name = "chrSensor2";
            this.chrSensor2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.DarkSlateGray;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerSize = 6;
            series1.Name = "Sensor 2";
            series1.ShadowColor = System.Drawing.Color.White;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series1.SmartLabelStyle.Enabled = false;
            this.chrSensor2.Series.Add(series1);
            this.chrSensor2.Size = new System.Drawing.Size(1018, 198);
            this.chrSensor2.TabIndex = 16;
            this.chrSensor2.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BackSecondaryColor = System.Drawing.Color.Transparent;
            title1.ForeColor = System.Drawing.Color.Transparent;
            title1.Name = "Sensor 1";
            title1.ShadowColor = System.Drawing.Color.Transparent;
            this.chrSensor2.Titles.Add(title1);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 555);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.pnlSensores.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbSensores;
        private System.Windows.Forms.PictureBox ptbUsers;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Panel pnlSensores;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Controls.ToggleButtons btnS1Z2;
        private Controls.ToggleButtons btnS1Z1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Timer tmrTemps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrSaveTemps;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrSensor1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrSensor2;
    }
}

