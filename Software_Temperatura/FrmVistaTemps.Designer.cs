namespace Software_Temperatura
{
    partial class FrmVistaTemps
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
            this.dtgvSensores = new System.Windows.Forms.DataGridView();
            this.txtSensores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tgbMostrar = new Software_Temperatura.Controls.ToggleButtons();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSensores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSensores
            // 
            this.dtgvSensores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSensores.Location = new System.Drawing.Point(14, 76);
            this.dtgvSensores.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtgvSensores.Name = "dtgvSensores";
            this.dtgvSensores.Size = new System.Drawing.Size(741, 377);
            this.dtgvSensores.TabIndex = 0;
            // 
            // txtSensores
            // 
            this.txtSensores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSensores.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSensores.Location = new System.Drawing.Point(14, 41);
            this.txtSensores.Name = "txtSensores";
            this.txtSensores.Size = new System.Drawing.Size(488, 27);
            this.txtSensores.TabIndex = 1;
            this.txtSensores.TextChanged += new System.EventHandler(this.txtSensores_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(749, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tgbMostrar
            // 
            this.tgbMostrar.AutoSize = true;
            this.tgbMostrar.Location = new System.Drawing.Point(710, 41);
            this.tgbMostrar.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgbMostrar.Name = "tgbMostrar";
            this.tgbMostrar.OffBackColor = System.Drawing.Color.Gray;
            this.tgbMostrar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgbMostrar.OnBackColor = System.Drawing.Color.Green;
            this.tgbMostrar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbMostrar.Size = new System.Drawing.Size(45, 22);
            this.tgbMostrar.TabIndex = 4;
            this.tgbMostrar.UseVisualStyleBackColor = true;
            this.tgbMostrar.CheckedChanged += new System.EventHandler(this.tgbMostrar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ver sensores no activados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar:";
            // 
            // FrmVistaTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(774, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tgbMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSensores);
            this.Controls.Add(this.dtgvSensores);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmVistaTemps";
            this.Text = "FrmVistaTemps";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSensores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSensores;
        private System.Windows.Forms.TextBox txtSensores;
        private System.Windows.Forms.Label label1;
        private Controls.ToggleButtons tgbMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}