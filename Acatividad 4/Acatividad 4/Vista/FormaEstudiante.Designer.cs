namespace Acatividad_4.Vista
{
    partial class FormaEstudiante
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
            this.bottonMostrar = new System.Windows.Forms.Button();
            this.textonumcontrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoEdad = new System.Windows.Forms.TextBox();
            this.textoGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bottonMostrar
            // 
            this.bottonMostrar.Location = new System.Drawing.Point(613, 368);
            this.bottonMostrar.Name = "bottonMostrar";
            this.bottonMostrar.Size = new System.Drawing.Size(75, 23);
            this.bottonMostrar.TabIndex = 0;
            this.bottonMostrar.Text = "Mostrar";
            this.bottonMostrar.UseVisualStyleBackColor = true;
            this.bottonMostrar.Click += new System.EventHandler(this.botonmostrar_Click);
            // 
            // textonumcontrol
            // 
            this.textonumcontrol.Location = new System.Drawing.Point(431, 137);
            this.textonumcontrol.Name = "textonumcontrol";
            this.textonumcontrol.Size = new System.Drawing.Size(257, 20);
            this.textonumcontrol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos del alumno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(431, 190);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(257, 20);
            this.textoNombre.TabIndex = 3;
            // 
            // textoEdad
            // 
            this.textoEdad.Location = new System.Drawing.Point(431, 242);
            this.textoEdad.Name = "textoEdad";
            this.textoEdad.Size = new System.Drawing.Size(257, 20);
            this.textoEdad.TabIndex = 4;
            // 
            // textoGenero
            // 
            this.textoGenero.Location = new System.Drawing.Point(431, 291);
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(257, 20);
            this.textoGenero.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "NumControl";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(812, 417);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoGenero);
            this.Controls.Add(this.textoEdad);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textonumcontrol);
            this.Controls.Add(this.bottonMostrar);
            this.Name = "FormaEstudiante";
            this.Text = "FormaEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bottonMostrar;
        private System.Windows.Forms.TextBox textonumcontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoEdad;
        private System.Windows.Forms.TextBox textoGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}