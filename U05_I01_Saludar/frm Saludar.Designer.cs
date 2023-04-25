namespace U05_I01_Saludar
{
    partial class frmSaludar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Saludar = new System.Windows.Forms.Label();
            this.lb_Saludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Saludar
            // 
            this.lb_Saludar.AutoSize = true;
            this.lb_Saludar.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Saludar.Location = new System.Drawing.Point(257, 49);
            this.lb_Saludar.Name = "lb_Saludar";
            this.lb_Saludar.Size = new System.Drawing.Size(264, 31);
            this.lb_Saludar.TabIndex = 0;
            this.lb_Saludar.Text = "¡Hola, Windows Forms!";
            // 
            // lb_Saludo
            // 
            this.lb_Saludo.AutoSize = true;
            this.lb_Saludo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Saludo.Location = new System.Drawing.Point(277, 109);
            this.lb_Saludo.Name = "lb_Saludo";
            this.lb_Saludo.Size = new System.Drawing.Size(0, 25);
            this.lb_Saludo.TabIndex = 1;
            // 
            // frmSaludar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.lb_Saludo);
            this.Controls.Add(this.lb_Saludar);
            this.Name = "frmSaludar";
            this.Text = "Saludar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Saludar;
        private Label lb_Saludo;
    }
}