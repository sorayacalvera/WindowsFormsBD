namespace WindowsFormsBD
{
    partial class Form1
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
            this.labMessage = new System.Windows.Forms.Label();
            this.butInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Location = new System.Drawing.Point(80, 53);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(0, 16);
            this.labMessage.TabIndex = 1;
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(95, 214);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(75, 23);
            this.butInsert.TabIndex = 3;
            this.butInsert.Text = "Insertar nuevo empleado";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 390);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.labMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.Button butInsert;
    }
}

