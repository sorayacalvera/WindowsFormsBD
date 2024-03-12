namespace WindowsFormsBD
{
    partial class FormBDConexion
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
            this.butConectar = new System.Windows.Forms.Button();
            this.butDesconectar = new System.Windows.Forms.Button();
            this.labMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butConectar
            // 
            this.butConectar.Location = new System.Drawing.Point(46, 34);
            this.butConectar.Name = "butConectar";
            this.butConectar.Size = new System.Drawing.Size(103, 23);
            this.butConectar.TabIndex = 0;
            this.butConectar.Text = "Conectar";
            this.butConectar.UseVisualStyleBackColor = true;
            this.butConectar.Click += new System.EventHandler(this.butConectar_Click);
            // 
            // butDesconectar
            // 
            this.butDesconectar.Location = new System.Drawing.Point(46, 95);
            this.butDesconectar.Name = "butDesconectar";
            this.butDesconectar.Size = new System.Drawing.Size(103, 23);
            this.butDesconectar.TabIndex = 1;
            this.butDesconectar.Text = "Desconectar";
            this.butDesconectar.UseVisualStyleBackColor = true;
            this.butDesconectar.Click += new System.EventHandler(this.butDesconectar_Click);
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Location = new System.Drawing.Point(198, 55);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(44, 16);
            this.labMessage.TabIndex = 2;
            this.labMessage.Text = "label1";
            // 
            // FormBDConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.butDesconectar);
            this.Controls.Add(this.butConectar);
            this.Name = "FormBDConexion";
            this.Text = "BDConexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConectar;
        private System.Windows.Forms.Button butDesconectar;
        private System.Windows.Forms.Label labMessage;
    }
}