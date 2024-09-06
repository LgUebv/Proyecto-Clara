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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbUsers = new System.Windows.Forms.PictureBox();
            this.ptbSensores = new System.Windows.Forms.PictureBox();
            this.tmrTemps = new System.Windows.Forms.Timer(this.components);
            this.tmrSaveTemps = new System.Windows.Forms.Timer(this.components);
            this.pnlSensores = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chrSensor1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chrSensor2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label24 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnS1Z2 = new Software_Temperatura.Controls.ToggleButtons();
            this.btnS1Z1 = new Software_Temperatura.Controls.ToggleButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).BeginInit();
            this.pnlSensores.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor2)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 46);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(796, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ptbUsers
            // 
            this.ptbUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbUsers.Location = new System.Drawing.Point(107, -1);
            this.ptbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.ptbUsers.Name = "ptbUsers";
            this.ptbUsers.Size = new System.Drawing.Size(114, 47);
            this.ptbUsers.TabIndex = 1;
            this.ptbUsers.TabStop = false;
            this.ptbUsers.Click += new System.EventHandler(this.ptbUsers_Click);
            this.ptbUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbUsers_Paint);
            // 
            // ptbSensores
            // 
            this.ptbSensores.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbSensores.Location = new System.Drawing.Point(-1, -1);
            this.ptbSensores.Margin = new System.Windows.Forms.Padding(2);
            this.ptbSensores.Name = "ptbSensores";
            this.ptbSensores.Size = new System.Drawing.Size(107, 47);
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
            this.tmrSaveTemps.Interval = 500;
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
            this.pnlSensores.Location = new System.Drawing.Point(0, 46);
            this.pnlSensores.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSensores.Name = "pnlSensores";
            this.pnlSensores.Size = new System.Drawing.Size(824, 405);
            this.pnlSensores.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnS1Z1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.chrSensor1);
            this.panel2.Location = new System.Drawing.Point(11, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 145);
            this.panel2.TabIndex = 3;
            // 
            // chrSensor1
            // 
            this.chrSensor1.BackColor = System.Drawing.Color.Transparent;
            this.chrSensor1.BorderSkin.PageColor = System.Drawing.Color.Silver;
            chartArea13.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea13.AxisX.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.LineWidth = 0;
            chartArea13.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea13.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea13.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea13.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea13.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea13.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea13.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea13.BackColor = System.Drawing.Color.Transparent;
            chartArea13.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            chartArea13.BorderColor = System.Drawing.Color.White;
            chartArea13.Name = "ChartArea1";
            this.chrSensor1.ChartAreas.Add(chartArea13);
            legend13.BackColor = System.Drawing.Color.Transparent;
            legend13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            legend13.IsTextAutoFit = false;
            legend13.Name = "Legend1";
            this.chrSensor1.Legends.Add(legend13);
            this.chrSensor1.Location = new System.Drawing.Point(2, -22);
            this.chrSensor1.Margin = new System.Windows.Forms.Padding(2);
            this.chrSensor1.Name = "chrSensor1";
            this.chrSensor1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series13.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series13.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            series13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series13.Color = System.Drawing.Color.DarkSlateGray;
            series13.LabelBackColor = System.Drawing.Color.White;
            series13.LabelBorderColor = System.Drawing.Color.White;
            series13.LabelForeColor = System.Drawing.Color.White;
            series13.Legend = "Legend1";
            series13.MarkerSize = 6;
            series13.Name = "Sensor 1";
            series13.ShadowColor = System.Drawing.Color.White;
            series13.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series13.SmartLabelStyle.Enabled = false;
            this.chrSensor1.Series.Add(series13);
            this.chrSensor1.Size = new System.Drawing.Size(764, 167);
            this.chrSensor1.TabIndex = 15;
            this.chrSensor1.Text = "chart1";
            title13.BackColor = System.Drawing.Color.Transparent;
            title13.BackSecondaryColor = System.Drawing.Color.Transparent;
            title13.ForeColor = System.Drawing.Color.Transparent;
            title13.Name = "Sensor 1";
            title13.ShadowColor = System.Drawing.Color.Transparent;
            this.chrSensor1.Titles.Add(title13);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(741, 30);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "label19";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(786, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "°";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.btnS1Z2);
            this.panel3.Controls.Add(this.chrSensor2);
            this.panel3.Location = new System.Drawing.Point(11, 182);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 145);
            this.panel3.TabIndex = 4;
            // 
            // chrSensor2
            // 
            this.chrSensor2.BackColor = System.Drawing.Color.Transparent;
            this.chrSensor2.BorderSkin.PageColor = System.Drawing.Color.Silver;
            chartArea14.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea14.AxisX.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.LineWidth = 0;
            chartArea14.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea14.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea14.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea14.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea14.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea14.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea14.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea14.BackColor = System.Drawing.Color.Transparent;
            chartArea14.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            chartArea14.BorderColor = System.Drawing.Color.White;
            chartArea14.Name = "ChartArea1";
            this.chrSensor2.ChartAreas.Add(chartArea14);
            legend14.BackColor = System.Drawing.Color.Transparent;
            legend14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            legend14.IsTextAutoFit = false;
            legend14.Name = "Legend1";
            this.chrSensor2.Legends.Add(legend14);
            this.chrSensor2.Location = new System.Drawing.Point(2, -16);
            this.chrSensor2.Margin = new System.Windows.Forms.Padding(2);
            this.chrSensor2.Name = "chrSensor2";
            this.chrSensor2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series14.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series14.BackSecondaryColor = System.Drawing.Color.Aquamarine;
            series14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series14.Color = System.Drawing.Color.DarkSlateGray;
            series14.LabelBackColor = System.Drawing.Color.White;
            series14.LabelBorderColor = System.Drawing.Color.White;
            series14.LabelForeColor = System.Drawing.Color.White;
            series14.Legend = "Legend1";
            series14.MarkerSize = 6;
            series14.Name = "Sensor 2";
            series14.ShadowColor = System.Drawing.Color.White;
            series14.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series14.SmartLabelStyle.Enabled = false;
            this.chrSensor2.Series.Add(series14);
            this.chrSensor2.Size = new System.Drawing.Size(764, 161);
            this.chrSensor2.TabIndex = 16;
            this.chrSensor2.Text = "chart1";
            title14.BackColor = System.Drawing.Color.Transparent;
            title14.BackSecondaryColor = System.Drawing.Color.Transparent;
            title14.ForeColor = System.Drawing.Color.Transparent;
            title14.Name = "Sensor 1";
            title14.ShadowColor = System.Drawing.Color.Transparent;
            this.chrSensor2.Titles.Add(title14);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(741, 34);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 17);
            this.label24.TabIndex = 13;
            this.label24.Text = "label24";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(786, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "°";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar Temperaturas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.Image = global::Software_Temperatura.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(782, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 26);
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
            this.txtUsuarios.Location = new System.Drawing.Point(11, 83);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(765, 26);
            this.txtUsuarios.TabIndex = 4;
            this.txtUsuarios.TextChanged += new System.EventHandler(this.txtUsuarios_TextChanged_1);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(11, 116);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 51;
            this.dtgvUsuarios.Size = new System.Drawing.Size(802, 322);
            this.dtgvUsuarios.TabIndex = 3;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // btnS1Z2
            // 
            this.btnS1Z2.AutoSize = true;
            this.btnS1Z2.Location = new System.Drawing.Point(762, 2);
            this.btnS1Z2.Margin = new System.Windows.Forms.Padding(2);
            this.btnS1Z2.MinimumSize = new System.Drawing.Size(34, 18);
            this.btnS1Z2.Name = "btnS1Z2";
            this.btnS1Z2.OffBackColor = System.Drawing.Color.Gray;
            this.btnS1Z2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnS1Z2.OnBackColor = System.Drawing.Color.Green;
            this.btnS1Z2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnS1Z2.Size = new System.Drawing.Size(34, 18);
            this.btnS1Z2.TabIndex = 7;
            this.btnS1Z2.UseVisualStyleBackColor = true;
            this.btnS1Z2.CheckedChanged += new System.EventHandler(this.btnS1Z2_CheckedChanged);
            // 
            // btnS1Z1
            // 
            this.btnS1Z1.AutoSize = true;
            this.btnS1Z1.Location = new System.Drawing.Point(762, 2);
            this.btnS1Z1.Margin = new System.Windows.Forms.Padding(2);
            this.btnS1Z1.MinimumSize = new System.Drawing.Size(34, 18);
            this.btnS1Z1.Name = "btnS1Z1";
            this.btnS1Z1.OffBackColor = System.Drawing.Color.Gray;
            this.btnS1Z1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnS1Z1.OnBackColor = System.Drawing.Color.Green;
            this.btnS1Z1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnS1Z1.Size = new System.Drawing.Size(34, 18);
            this.btnS1Z1.TabIndex = 7;
            this.btnS1Z1.UseVisualStyleBackColor = true;
            this.btnS1Z1.CheckedChanged += new System.EventHandler(this.btnS1Z1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar usuarios";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 451);
            this.Controls.Add(this.pnlSensores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.dtgvUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).EndInit();
            this.pnlSensores.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrSensor2)).EndInit();
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

