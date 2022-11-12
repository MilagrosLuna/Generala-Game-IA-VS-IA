
namespace GraficaDados
{
    partial class FrmFinPartida
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_partida = new System.Windows.Forms.Label();
            this.lbl_puntuacion = new System.Windows.Forms.Label();
            this.lbl_ganador = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.40319F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.43666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 470);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_partida);
            this.groupBox1.Controls.Add(this.lbl_puntuacion);
            this.groupBox1.Controls.Add(this.lbl_ganador);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Partida";
            // 
            // lbl_partida
            // 
            this.lbl_partida.AutoSize = true;
            this.lbl_partida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_partida.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_partida.ForeColor = System.Drawing.Color.White;
            this.lbl_partida.Location = new System.Drawing.Point(50, 101);
            this.lbl_partida.Name = "lbl_partida";
            this.lbl_partida.Size = new System.Drawing.Size(155, 65);
            this.lbl_partida.TabIndex = 2;
            this.lbl_partida.Text = "label1";
            // 
            // lbl_puntuacion
            // 
            this.lbl_puntuacion.AutoSize = true;
            this.lbl_puntuacion.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_puntuacion.Location = new System.Drawing.Point(50, 340);
            this.lbl_puntuacion.Name = "lbl_puntuacion";
            this.lbl_puntuacion.Size = new System.Drawing.Size(155, 65);
            this.lbl_puntuacion.TabIndex = 1;
            this.lbl_puntuacion.Text = "label1";
            // 
            // lbl_ganador
            // 
            this.lbl_ganador.AutoSize = true;
            this.lbl_ganador.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ganador.Location = new System.Drawing.Point(50, 275);
            this.lbl_ganador.Name = "lbl_ganador";
            this.lbl_ganador.Size = new System.Drawing.Size(144, 65);
            this.lbl_ganador.TabIndex = 0;
            this.lbl_ganador.Text = "sasad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GraficaDados.Properties.Resources.trofeo;
            this.pictureBox1.Location = new System.Drawing.Point(562, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFinPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(907, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(923, 509);
            this.Name = "FrmFinPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fin Partida";
            this.Load += new System.EventHandler(this.FrmFinPartida_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ganador;
        private System.Windows.Forms.Label lbl_puntuacion;
        private System.Windows.Forms.Label lbl_partida;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}