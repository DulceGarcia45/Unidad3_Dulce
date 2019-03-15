namespace ejemplo_2.Campeonato.Vista
{
    partial class Inicio_Campeonato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Campeonato));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.liga_futbol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Jornada = new System.Windows.Forms.Button();
            this.Campeonato = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Equipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.liga_futbol);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(656, 430);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // liga_futbol
            // 
            this.liga_futbol.AutoSize = true;
            this.liga_futbol.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liga_futbol.ForeColor = System.Drawing.SystemColors.Desktop;
            this.liga_futbol.Location = new System.Drawing.Point(185, 17);
            this.liga_futbol.Name = "liga_futbol";
            this.liga_futbol.Size = new System.Drawing.Size(308, 27);
            this.liga_futbol.TabIndex = 1;
            this.liga_futbol.Text = "Liga fut-bol campeonato";
            this.liga_futbol.Click += new System.EventHandler(this.liga_futbol_Click);
            this.liga_futbol.MouseEnter += new System.EventHandler(this.liga_futbol_MouseEnter);
            this.liga_futbol.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Controls.Add(this.Jornada, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Campeonato, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Equipo, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Jornada
            // 
            this.Jornada.BackColor = System.Drawing.Color.Lime;
            this.Jornada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Jornada.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jornada.Location = new System.Drawing.Point(278, 3);
            this.Jornada.Name = "Jornada";
            this.Jornada.Size = new System.Drawing.Size(269, 174);
            this.Jornada.TabIndex = 2;
            this.Jornada.Text = "Jornada";
            this.Jornada.UseVisualStyleBackColor = false;
            this.Jornada.Click += new System.EventHandler(this.Jornada_Click);
            this.Jornada.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.Jornada.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // Campeonato
            // 
            this.Campeonato.BackColor = System.Drawing.Color.Lime;
            this.Campeonato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Campeonato.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campeonato.Location = new System.Drawing.Point(3, 3);
            this.Campeonato.Name = "Campeonato";
            this.Campeonato.Size = new System.Drawing.Size(269, 174);
            this.Campeonato.TabIndex = 0;
            this.Campeonato.Text = "Campeonato";
            this.Campeonato.UseVisualStyleBackColor = false;
            this.Campeonato.Click += new System.EventHandler(this.Campeonato_Click);
            this.Campeonato.MouseEnter += new System.EventHandler(this.Campeonato_MouseEnter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(553, 183);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(94, 174);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Equipo
            // 
            this.Equipo.BackColor = System.Drawing.Color.Lime;
            this.Equipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equipo.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Equipo.Location = new System.Drawing.Point(3, 183);
            this.Equipo.Name = "Equipo";
            this.Equipo.Size = new System.Drawing.Size(269, 174);
            this.Equipo.TabIndex = 3;
            this.Equipo.Text = "Equipos";
            this.Equipo.UseVisualStyleBackColor = false;
            this.Equipo.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // Inicio_Campeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio_Campeonato";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Inicio_Campeonato";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Campeonato;
        private System.Windows.Forms.Label liga_futbol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Jornada;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Equipo;
    }
}