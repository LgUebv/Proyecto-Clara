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
            this.toggleButtons1 = new Software_Temperatura.Controls.ToggleButtons();
            this.toggleButtons2 = new Software_Temperatura.Controls.ToggleButtons();
            this.toggleButtons3 = new Software_Temperatura.Controls.ToggleButtons();
            this.SuspendLayout();
            // 
            // toggleButtons1
            // 
            this.toggleButtons1.AutoSize = true;
            this.toggleButtons1.Location = new System.Drawing.Point(79, 166);
            this.toggleButtons1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtons1.Name = "toggleButtons1";
            this.toggleButtons1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtons1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtons1.OnBackColor = System.Drawing.Color.Green;
            this.toggleButtons1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtons1.Size = new System.Drawing.Size(45, 22);
            this.toggleButtons1.TabIndex = 0;
            this.toggleButtons1.UseVisualStyleBackColor = true;
            // 
            // toggleButtons2
            // 
            this.toggleButtons2.AutoSize = true;
            this.toggleButtons2.Location = new System.Drawing.Point(359, 165);
            this.toggleButtons2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtons2.Name = "toggleButtons2";
            this.toggleButtons2.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtons2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtons2.OnBackColor = System.Drawing.Color.Green;
            this.toggleButtons2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtons2.Size = new System.Drawing.Size(45, 22);
            this.toggleButtons2.TabIndex = 1;
            this.toggleButtons2.UseVisualStyleBackColor = true;
            // 
            // toggleButtons3
            // 
            this.toggleButtons3.AutoSize = true;
            this.toggleButtons3.Location = new System.Drawing.Point(660, 164);
            this.toggleButtons3.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtons3.Name = "toggleButtons3";
            this.toggleButtons3.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtons3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtons3.OnBackColor = System.Drawing.Color.Green;
            this.toggleButtons3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtons3.Size = new System.Drawing.Size(45, 22);
            this.toggleButtons3.TabIndex = 2;
            this.toggleButtons3.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toggleButtons3);
            this.Controls.Add(this.toggleButtons2);
            this.Controls.Add(this.toggleButtons1);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ToggleButtons toggleButtons1;
        private Controls.ToggleButtons toggleButtons2;
        private Controls.ToggleButtons toggleButtons3;
    }
}

