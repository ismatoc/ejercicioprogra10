namespace SingleResponsibility
{
    partial class Form1
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
            this.BtnReporte = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nombre_projecto = new System.Windows.Forms.TextBox();
            this.hora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnReporte
            // 
            this.BtnReporte.Location = new System.Drawing.Point(130, 256);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(249, 28);
            this.BtnReporte.TabIndex = 0;
            this.BtnReporte.Text = "Crear Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(206, 98);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(236, 22);
            this.codigo.TabIndex = 1;
            // 
            // nombre_projecto
            // 
            this.nombre_projecto.Location = new System.Drawing.Point(206, 140);
            this.nombre_projecto.Name = "nombre_projecto";
            this.nombre_projecto.Size = new System.Drawing.Size(236, 22);
            this.nombre_projecto.TabIndex = 2;
            // 
            // hora
            // 
            this.hora.Location = new System.Drawing.Point(206, 187);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(236, 22);
            this.hora.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Proyecto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear Planificador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tarea
            // 
            this.Tarea.Location = new System.Drawing.Point(637, 115);
            this.Tarea.Name = "Tarea";
            this.Tarea.Size = new System.Drawing.Size(200, 22);
            this.Tarea.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 412);
            this.Controls.Add(this.Tarea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.nombre_projecto);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.BtnReporte);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nombre_projecto;
        private System.Windows.Forms.TextBox hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tarea;
    }
}

