
namespace GraficaDados
{
    partial class FrmPartida
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_rondas = new System.Windows.Forms.Label();
            this.btn_cancelarPartida = new System.Windows.Forms.Button();
            this.label_quienJuega = new System.Windows.Forms.Label();
            this.label_turnoJugador = new System.Windows.Forms.Label();
            this.pictureBox_gif = new System.Windows.Forms.PictureBox();
            this.pictureBox_dado5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dado4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dado3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dado2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dado1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_rondas);
            this.groupBox1.Controls.Add(this.btn_cancelarPartida);
            this.groupBox1.Controls.Add(this.label_quienJuega);
            this.groupBox1.Controls.Add(this.label_turnoJugador);
            this.groupBox1.Controls.Add(this.pictureBox_gif);
            this.groupBox1.Controls.Add(this.pictureBox_dado5);
            this.groupBox1.Controls.Add(this.pictureBox_dado4);
            this.groupBox1.Controls.Add(this.pictureBox_dado3);
            this.groupBox1.Controls.Add(this.pictureBox_dado2);
            this.groupBox1.Controls.Add(this.pictureBox_dado1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_rondas
            // 
            this.label_rondas.AutoSize = true;
            this.label_rondas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_rondas.Location = new System.Drawing.Point(857, 146);
            this.label_rondas.Name = "label_rondas";
            this.label_rondas.Size = new System.Drawing.Size(105, 45);
            this.label_rondas.TabIndex = 9;
            this.label_rondas.Text = "label1";
            // 
            // btn_cancelarPartida
            // 
            this.btn_cancelarPartida.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_cancelarPartida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelarPartida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancelarPartida.Location = new System.Drawing.Point(857, 67);
            this.btn_cancelarPartida.Name = "btn_cancelarPartida";
            this.btn_cancelarPartida.Size = new System.Drawing.Size(147, 41);
            this.btn_cancelarPartida.TabIndex = 8;
            this.btn_cancelarPartida.Text = "cancelar partida";
            this.btn_cancelarPartida.UseVisualStyleBackColor = false;
            this.btn_cancelarPartida.Click += new System.EventHandler(this.btn_cancelarPartida_Click);
            // 
            // label_quienJuega
            // 
            this.label_quienJuega.AutoSize = true;
            this.label_quienJuega.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_quienJuega.Location = new System.Drawing.Point(21, 219);
            this.label_quienJuega.Name = "label_quienJuega";
            this.label_quienJuega.Size = new System.Drawing.Size(222, 45);
            this.label_quienJuega.TabIndex = 7;
            this.label_quienJuega.Text = "Es el turno de:";
            // 
            // label_turnoJugador
            // 
            this.label_turnoJugador.AutoSize = true;
            this.label_turnoJugador.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_turnoJugador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_turnoJugador.Location = new System.Drawing.Point(21, 264);
            this.label_turnoJugador.Name = "label_turnoJugador";
            this.label_turnoJugador.Size = new System.Drawing.Size(90, 37);
            this.label_turnoJugador.TabIndex = 6;
            this.label_turnoJugador.Text = "label1";
            // 
            // pictureBox_gif
            // 
            this.pictureBox_gif.Location = new System.Drawing.Point(857, 219);
            this.pictureBox_gif.Name = "pictureBox_gif";
            this.pictureBox_gif.Size = new System.Drawing.Size(101, 111);
            this.pictureBox_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_gif.TabIndex = 5;
            this.pictureBox_gif.TabStop = false;
            // 
            // pictureBox_dado5
            // 
            this.pictureBox_dado5.Location = new System.Drawing.Point(597, 67);
            this.pictureBox_dado5.Name = "pictureBox_dado5";
            this.pictureBox_dado5.Size = new System.Drawing.Size(101, 111);
            this.pictureBox_dado5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dado5.TabIndex = 4;
            this.pictureBox_dado5.TabStop = false;
            // 
            // pictureBox_dado4
            // 
            this.pictureBox_dado4.Location = new System.Drawing.Point(428, 67);
            this.pictureBox_dado4.Name = "pictureBox_dado4";
            this.pictureBox_dado4.Size = new System.Drawing.Size(101, 111);
            this.pictureBox_dado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dado4.TabIndex = 3;
            this.pictureBox_dado4.TabStop = false;
            // 
            // pictureBox_dado3
            // 
            this.pictureBox_dado3.Location = new System.Drawing.Point(288, 67);
            this.pictureBox_dado3.Name = "pictureBox_dado3";
            this.pictureBox_dado3.Size = new System.Drawing.Size(101, 111);
            this.pictureBox_dado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dado3.TabIndex = 2;
            this.pictureBox_dado3.TabStop = false;
            // 
            // pictureBox_dado2
            // 
            this.pictureBox_dado2.Location = new System.Drawing.Point(152, 67);
            this.pictureBox_dado2.Name = "pictureBox_dado2";
            this.pictureBox_dado2.Size = new System.Drawing.Size(101, 111);
            this.pictureBox_dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dado2.TabIndex = 1;
            this.pictureBox_dado2.TabStop = false;
            // 
            // pictureBox_dado1
            // 
            this.pictureBox_dado1.Location = new System.Drawing.Point(21, 67);
            this.pictureBox_dado1.Name = "pictureBox_dado1";
            this.pictureBox_dado1.Size = new System.Drawing.Size(101, 111);
            this.pictureBox_dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dado1.TabIndex = 0;
            this.pictureBox_dado1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.33552F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.47525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.52475F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1243, 505);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 133);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1243, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1259, 544);
            this.Name = "FrmPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPartida_FormClosing);
            this.Load += new System.EventHandler(this.FrmPartida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dado1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_dado5;
        private System.Windows.Forms.PictureBox pictureBox_dado4;
        private System.Windows.Forms.PictureBox pictureBox_dado3;
        private System.Windows.Forms.PictureBox pictureBox_dado2;
        private System.Windows.Forms.PictureBox pictureBox_dado1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox_gif;
        private System.Windows.Forms.Label label_turnoJugador;
        private System.Windows.Forms.Label label_quienJuega;
        private System.Windows.Forms.Button btn_cancelarPartida;
        private System.Windows.Forms.Label label_rondas;
    }
}