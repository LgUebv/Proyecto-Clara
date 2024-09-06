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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbUsers = new System.Windows.Forms.PictureBox();
            this.ptbSensores = new System.Windows.Forms.PictureBox();
            this.tmrTemps = new System.Windows.Forms.Timer(this.components);
            this.tmrSaveTemps = new System.Windows.Forms.Timer(this.components);
            this.pnlSensores = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnS1Z2 = new Software_Temperatura.Controls.ToggleButtons();
            this.chrSensor2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnS1Z1 = new Software_Temperatura.Controls.ToggleButtons();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chrSensor1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).BeginInit();
            this.pnlSensores.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
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
            // tmrTemps
            // 
            this.tmrTemps.Interval = 1000;
            this.tmrTemps.Tick += new System.EventHandler(this.tmrTemps_Tick);
            // 
            // tmrSaveTemps
            // 
            this.tmrSaveTemps.Interval = 15000;
            this.tmrSaveTemps.Tick += new System.EventHandler(this.tmrSaveTemps_Tick);
            // 
            // pnlSensores
            // 
            this.pnlSensores.AutoScroll = true;
            this.pnlSensores.BackColor = System.Drawing.Color.White;
            this.pnlSensores.Controls.Add(this.button1);
            this.pnlSensores.Controls.Add(this.panel3);
            this.pnlSensores.Controls.Add(this.panel2);
            this.pnlSensores.ForeColor = System.Drawing.Color.Black;
            this.pnlSensores.Location = new System.Drawing.Point(0, 57);
            this.pnlSensores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSensores.Name = "pnlSensores";
            this.pnlSensores.Size = new System.Drawing.Size(1099, 498);
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
            this.label5.ForeColor = System.Drawing.Color.Black;
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
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(988, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 17);
            this.label24.TabIndex = 13;
            this.label24.Text = "label24";
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
            // chrSensor2
            // 
            this.chrSensor2.BackColor = System.Drawing.Color.Transparent;
            this.chrSensor2.BorderSkin.PageColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chrSensor2.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chrSensor2.Legends.Add(legend3);
            this.chrSensor2.Location = new System.Drawing.Point(3, -20);
            this.chrSensor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrSensor2.Name = "chrSensor2";
            this.chrSensor2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.DarkSlateGray;
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.LabelBorderColor = System.Drawing.Color.White;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.MarkerSize = 6;
            series3.Name = "Sensor 2";
            series3.ShadowColor = System.Drawing.Color.White;
            series3.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series3.SmartLabelStyle.Enabled = false;
            this.chrSensor2.Series.Add(series3);
            this.chrSensor2.Size = new System.Drawing.Size(1019, 198);
            this.chrSensor2.TabIndex = 16;
            this.chrSensor2.Text = "chart1";
            title3.BackColor = System.Drawing.Color.Transparent;
            title3.BackSecondaryColor = System.Drawing.Color.Transparent;
            title3.ForeColor = System.Drawing.Color.Transparent;
            title3.Name = "Sensor 1";
            title3.ShadowColor = System.Drawing.Color.Transparent;
            this.chrSensor2.Titles.Add(title3);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
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
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(988, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "label19";
            // 
            // chrSensor1
            // 
            this.chrSensor1.BackColor = System.Drawing.Color.Transparent;
            this.chrSensor1.BorderSkin.PageColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineWidth = 0;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chrSensor1.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chrSensor1.Legends.Add(legend4);
            this.chrSensor1.Location = new System.Drawing.Point(3, -27);
            this.chrSensor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrSensor1.Name = "chrSensor1";
            this.chrSensor1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series4.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Color = System.Drawing.Color.DarkSlateGray;
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.LabelBorderColor = System.Drawing.Color.White;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerSize = 6;
            series4.Name = "Sensor 1";
            series4.ShadowColor = System.Drawing.Color.White;
            series4.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series4.SmartLabelStyle.Enabled = false;
            this.chrSensor1.Series.Add(series4);
            this.chrSensor1.Size = new System.Drawing.Size(1019, 206);
            this.chrSensor1.TabIndex = 15;
            this.chrSensor1.Text = "chart1";
            title4.BackColor = System.Drawing.Color.Transparent;
            title4.BackSecondaryColor = System.Drawing.Color.Transparent;
            title4.ForeColor = System.Drawing.Color.Transparent;
            title4.Name = "Sensor 1";
            title4.ShadowColor = System.Drawing.Color.Transparent;
            this.chrSensor1.Titles.Add(title4);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.Image = global::Software_Temperatura.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(1043, 102);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 32);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarios.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarios.Location = new System.Drawing.Point(15, 102);
            this.txtUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(1019, 26);
            this.txtUsuarios.TabIndex = 4;
            this.txtUsuarios.TextChanged += new System.EventHandler(this.txtUsuarios_TextChanged_1);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(15, 143);
            this.dtgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 51;
            this.dtgvUsuarios.Size = new System.Drawing.Size(1069, 396);
            this.dtgvUsuarios.TabIndex = 3;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar usuarios";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 555);
            this.Controls.Add(this.pnlSensores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.dtgvUsuarios);
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
            this.pnlSensores.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbSensores;
        private System.Windows.Forms.PictureBox ptbUsers;
        private System.Windows.Forms.Timer tmrTemps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrSaveTemps;
        private System.Windows.Forms.Panel pnlSensores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label24;
        private Controls.ToggleButtons btnS1Z2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrSensor2;
        private System.Windows.Forms.Panel panel2;
        private Controls.ToggleButtons btnS1Z1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrSensor1;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Label label1;
    }
}

