namespace U05_I01_Inicio
{
    partial class frmInicio
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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.btn_Saludar = new System.Windows.Forms.Button();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Apellido = new System.Windows.Forms.Label();
            this.cbx_MeteriaFavorita = new System.Windows.Forms.ComboBox();
            this.lb_MeteriaFavorita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(12, 74);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(226, 27);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(318, 74);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(226, 27);
            this.txt_Apellido.TabIndex = 1;
            this.txt_Apellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Saludar
            // 
            this.btn_Saludar.Location = new System.Drawing.Point(341, 201);
            this.btn_Saludar.Name = "btn_Saludar";
            this.btn_Saludar.Size = new System.Drawing.Size(203, 30);
            this.btn_Saludar.TabIndex = 2;
            this.btn_Saludar.Text = "Saludar";
            this.btn_Saludar.UseVisualStyleBackColor = true;
            this.btn_Saludar.Click += new System.EventHandler(this.btn_Saludar_Click);
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Nombre.Location = new System.Drawing.Point(12, 42);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(67, 20);
            this.lb_Nombre.TabIndex = 3;
            this.lb_Nombre.Text = "Nombre";
            // 
            // lb_Apellido
            // 
            this.lb_Apellido.AutoSize = true;
            this.lb_Apellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Apellido.Location = new System.Drawing.Point(318, 42);
            this.lb_Apellido.Name = "lb_Apellido";
            this.lb_Apellido.Size = new System.Drawing.Size(74, 20);
            this.lb_Apellido.TabIndex = 4;
            this.lb_Apellido.Text = "Apellidos";
            // 
            // cbx_MeteriaFavorita
            // 
            this.cbx_MeteriaFavorita.FormattingEnabled = true;
            this.cbx_MeteriaFavorita.Location = new System.Drawing.Point(12, 140);
            this.cbx_MeteriaFavorita.Name = "cbx_MeteriaFavorita";
            this.cbx_MeteriaFavorita.Size = new System.Drawing.Size(532, 28);
            this.cbx_MeteriaFavorita.TabIndex = 5;
            // 
            // lb_MeteriaFavorita
            // 
            this.lb_MeteriaFavorita.AutoSize = true;
            this.lb_MeteriaFavorita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MeteriaFavorita.Location = new System.Drawing.Point(12, 117);
            this.lb_MeteriaFavorita.Name = "lb_MeteriaFavorita";
            this.lb_MeteriaFavorita.Size = new System.Drawing.Size(124, 20);
            this.lb_MeteriaFavorita.TabIndex = 6;
            this.lb_MeteriaFavorita.Text = "Materia Favorita";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 243);
            this.Controls.Add(this.lb_MeteriaFavorita);
            this.Controls.Add(this.cbx_MeteriaFavorita);
            this.Controls.Add(this.lb_Apellido);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.btn_Saludar);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Name = "frmInicio";
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private Button btn_Saludar;
        private Label lb_Nombre;
        private Label lb_Apellido;
        private ComboBox cbx_MeteriaFavorita;
        private Label lb_MeteriaFavorita;
    }
}