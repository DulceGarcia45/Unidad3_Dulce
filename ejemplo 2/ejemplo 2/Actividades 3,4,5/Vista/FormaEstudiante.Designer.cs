namespace ejemplo_2.Actividades_3_4_5.Vista
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numcontrol = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.textonumcontrol = new System.Windows.Forms.TextBox();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoEdad = new System.Windows.Forms.TextBox();
            this.textoGenero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos Alumnos";
            // 
            // numcontrol
            // 
            this.numcontrol.AutoSize = true;
            this.numcontrol.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcontrol.Location = new System.Drawing.Point(86, 127);
            this.numcontrol.Name = "numcontrol";
            this.numcontrol.Size = new System.Drawing.Size(239, 31);
            this.numcontrol.TabIndex = 2;
            this.numcontrol.Text = "Numero control";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(86, 194);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(128, 31);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // Edad
            // 
            this.edad.AutoSize = true;
            this.edad.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(86, 253);
            this.edad.Name = "Edad";
            this.edad.Size = new System.Drawing.Size(83, 31);
            this.edad.TabIndex = 4;
            this.edad.Text = "Edad";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.Location = new System.Drawing.Point(86, 306);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(115, 31);
            this.Genero.TabIndex = 5;
            this.Genero.Text = "Genero";
            // 
            // textonumcontrol
            // 
            this.textonumcontrol.Location = new System.Drawing.Point(348, 127);
            this.textonumcontrol.Name = "textonumcontrol";
            this.textonumcontrol.Size = new System.Drawing.Size(273, 20);
            this.textonumcontrol.TabIndex = 6;
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(348, 194);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(273, 20);
            this.textoNombre.TabIndex = 7;
            this.textoNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textoEdad
            // 
            this.textoEdad.Location = new System.Drawing.Point(348, 246);
            this.textoEdad.Name = "textoEdad";
            this.textoEdad.Size = new System.Drawing.Size(273, 20);
            this.textoEdad.TabIndex = 8;
            // 
            // textoGenero
            // 
            this.textoGenero.Location = new System.Drawing.Point(348, 299);
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(273, 20);
            this.textoGenero.TabIndex = 9;
            // 
            // FormaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(724, 447);
            this.Controls.Add(this.textoGenero);
            this.Controls.Add(this.textoEdad);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.textonumcontrol);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.numcontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormaEstudiante";
            this.Text = "FormaEstudiante";
            this.Load += new System.EventHandler(this.FormaEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numcontrol;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.TextBox textonumcontrol;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoEdad;
        private System.Windows.Forms.TextBox textoGenero;
    }
}