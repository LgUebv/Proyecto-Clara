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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ptbUsers = new System.Windows.Forms.PictureBox();
            this.ptbSensores = new System.Windows.Forms.PictureBox();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlSensores = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.ptbUsers);
            this.panel1.Controls.Add(this.ptbSensores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = global::Software_Temperatura.Properties.Resources.logout_icon;
            this.pictureBox3.Location = new System.Drawing.Point(756, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ptbUsers
            // 
            this.ptbUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbUsers.Location = new System.Drawing.Point(106, -1);
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
            this.ptbSensores.Size = new System.Drawing.Size(103, 47);
            this.ptbSensores.TabIndex = 0;
            this.ptbSensores.TabStop = false;
            this.ptbSensores.Click += new System.EventHandler(this.ptbSensores_Click);
            this.ptbSensores.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbSensores_Paint);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Controls.Add(this.btnAdd);
            this.pnlUsuarios.Controls.Add(this.txtUsuarios);
            this.pnlUsuarios.Controls.Add(this.dtgvUsuarios);
            this.pnlUsuarios.Location = new System.Drawing.Point(0, 51);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(800, 396);
            this.pnlUsuarios.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.Image = global::Software_Temperatura.Properties.Resources.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(757, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 26);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarios.Location = new System.Drawing.Point(12, 14);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(739, 26);
            this.txtUsuarios.TabIndex = 1;
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(12, 46);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.Size = new System.Drawing.Size(776, 333);
            this.dtgvUsuarios.TabIndex = 0;
            this.dtgvUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellEnter);
            // 
            // pnlSensores
            // 
            this.pnlSensores.AutoScroll = true;
            this.pnlSensores.Location = new System.Drawing.Point(0, 51);
            this.pnlSensores.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSensores.Name = "pnlSensores";
            this.pnlSensores.Size = new System.Drawing.Size(800, 396);
            this.pnlSensores.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.pnlSensores);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensores)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbSensores;
        private System.Windows.Forms.PictureBox ptbUsers;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Panel pnlSensores;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.PictureBox btnAdd;
    }
}

