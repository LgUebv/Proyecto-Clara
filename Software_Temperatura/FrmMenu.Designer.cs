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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbUsers = new System.Windows.Forms.PictureBox();
            this.ptbSensores = new System.Windows.Forms.PictureBox();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlSensores = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnS1Z2 = new Software_Temperatura.Controls.ToggleButtons();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnS1Z1 = new Software_Temperatura.Controls.ToggleButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrTemps = new System.Windows.Forms.Timer(this.components);
            this.tmrSaveTemps = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.pnlSensores.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlUsuarios.Controls.Add(this.pnlSensores);
            this.pnlUsuarios.Controls.Add(this.btnAdd);
            this.pnlUsuarios.Controls.Add(this.txtUsuarios);
            this.pnlUsuarios.Controls.Add(this.dtgvUsuarios);
            this.pnlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsuarios.Location = new System.Drawing.Point(0, 46);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(824, 405);
            this.pnlUsuarios.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.Image = global::Software_Temperatura.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(783, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 26);
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
            this.txtUsuarios.Location = new System.Drawing.Point(12, 14);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(739, 26);
            this.txtUsuarios.TabIndex = 1;
            this.txtUsuarios.Text = "Buscar ";
            this.txtUsuarios.TextChanged += new System.EventHandler(this.txtUsuarios_TextChanged);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(12, 46);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 51;
            this.dtgvUsuarios.Size = new System.Drawing.Size(802, 333);
            this.dtgvUsuarios.TabIndex = 0;
            this.dtgvUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellEnter);
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
            this.pnlSensores.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSensores.Name = "pnlSensores";
            this.pnlSensores.Size = new System.Drawing.Size(824, 405);
            this.pnlSensores.TabIndex = 2;
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
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnS1Z2);
            this.panel3.Location = new System.Drawing.Point(11, 182);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 145);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(768, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label24.Location = new System.Drawing.Point(725, 34);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 17);
            this.label24.TabIndex = 13;
            this.label24.Text = "label24";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(9, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sensor 2";
            // 
            // btnS1Z2
            // 
            this.btnS1Z2.AutoSize = true;
            this.btnS1Z2.Checked = true;
            this.btnS1Z2.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.btnS1Z1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 145);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(764, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label19.Location = new System.Drawing.Point(725, 31);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "label19";
            // 
            // btnS1Z1
            // 
            this.btnS1Z1.AutoSize = true;
            this.btnS1Z1.Checked = true;
            this.btnS1Z1.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(9, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor 1";
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
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 451);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.pnlSensores.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
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
    }
}

