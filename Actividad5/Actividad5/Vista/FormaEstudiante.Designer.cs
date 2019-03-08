namespace Actividad5.Vista
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
            this.datosEstudiante = new System.Windows.Forms.Label();
            this.textonumcontrol = new System.Windows.Forms.TextBox();
            this.buttonmostrar = new System.Windows.Forms.Button();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoEdad = new System.Windows.Forms.TextBox();
            this.textoGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datosEstudiante
            // 
            this.datosEstudiante.AutoSize = true;
            this.datosEstudiante.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosEstudiante.Location = new System.Drawing.Point(289, 9);
            this.datosEstudiante.Name = "datosEstudiante";
            this.datosEstudiante.Size = new System.Drawing.Size(244, 22);
            this.datosEstudiante.TabIndex = 0;
            this.datosEstudiante.Text = "Datos del Estudiante";
            // 
            // textonumcontrol
            // 
            this.textonumcontrol.Location = new System.Drawing.Point(501, 101);
            this.textonumcontrol.Name = "textonumcontrol";
            this.textonumcontrol.Size = new System.Drawing.Size(313, 20);
            this.textonumcontrol.TabIndex = 1;
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.Location = new System.Drawing.Point(713, 345);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(89, 30);
            this.buttonmostrar.TabIndex = 2;
            this.buttonmostrar.Text = "Mostrar";
            this.buttonmostrar.UseVisualStyleBackColor = true;
            this.buttonmostrar.Click += new System.EventHandler(this.buttonmostrar_Click);
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(501, 157);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(313, 20);
            this.textoNombre.TabIndex = 3;
            // 
            // textoEdad
            // 
            this.textoEdad.Location = new System.Drawing.Point(501, 205);
            this.textoEdad.Name = "textoEdad";
            this.textoEdad.Size = new System.Drawing.Size(313, 20);
            this.textoEdad.TabIndex = 4;
            // 
            // textoGenero
            // 
            this.textoGenero.Location = new System.Drawing.Point(501, 259);
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(313, 20);
            this.textoGenero.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "NumControl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // FormaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(891, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoGenero);
            this.Controls.Add(this.textoEdad);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.buttonmostrar);
            this.Controls.Add(this.textonumcontrol);
            this.Controls.Add(this.datosEstudiante);
            this.Name = "FormaEstudiante";
            this.Text = "FormaEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datosEstudiante;
        private System.Windows.Forms.TextBox textonumcontrol;
        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoEdad;
        private System.Windows.Forms.TextBox textoGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}