
namespace GraficaDados
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_archivos = new System.Windows.Forms.Button();
            this.btn_historialPartidas = new System.Windows.Forms.Button();
            this.btn_GenerarPartida = new System.Windows.Forms.Button();
            this.flowLayoutPanelPartidas = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.91772F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelPartidas, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.24611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.75389F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_archivos);
            this.groupBox1.Controls.Add(this.btn_historialPartidas);
            this.groupBox1.Controls.Add(this.btn_GenerarPartida);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_archivos
            // 
            this.btn_archivos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_archivos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_archivos.Location = new System.Drawing.Point(388, 80);
            this.btn_archivos.Name = "btn_archivos";
            this.btn_archivos.Size = new System.Drawing.Size(177, 74);
            this.btn_archivos.TabIndex = 3;
            this.btn_archivos.Text = "archivos";
            this.btn_archivos.UseVisualStyleBackColor = true;
            this.btn_archivos.Click += new System.EventHandler(this.btn_archivos_Click);
            // 
            // btn_historialPartidas
            // 
            this.btn_historialPartidas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_historialPartidas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_historialPartidas.Location = new System.Drawing.Point(9, 80);
            this.btn_historialPartidas.Name = "btn_historialPartidas";
            this.btn_historialPartidas.Size = new System.Drawing.Size(177, 74);
            this.btn_historialPartidas.TabIndex = 2;
            this.btn_historialPartidas.Text = "ver historial de partidas";
            this.btn_historialPartidas.UseVisualStyleBackColor = true;
            this.btn_historialPartidas.Click += new System.EventHandler(this.btn_historialPartidas_Click);
            // 
            // btn_GenerarPartida
            // 
            this.btn_GenerarPartida.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GenerarPartida.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_GenerarPartida.Location = new System.Drawing.Point(763, 80);
            this.btn_GenerarPartida.Name = "btn_GenerarPartida";
            this.btn_GenerarPartida.Size = new System.Drawing.Size(217, 74);
            this.btn_GenerarPartida.TabIndex = 0;
            this.btn_GenerarPartida.Text = "Simular Partida Bots";
            this.btn_GenerarPartida.UseVisualStyleBackColor = true;
            this.btn_GenerarPartida.Click += new System.EventHandler(this.btn_GenerarPartida_Click);
            // 
            // flowLayoutPanelPartidas
            // 
            this.flowLayoutPanelPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPartidas.Location = new System.Drawing.Point(3, 241);
            this.flowLayoutPanelPartidas.Name = "flowLayoutPanelPartidas";
            this.flowLayoutPanelPartidas.Size = new System.Drawing.Size(989, 221);
            this.flowLayoutPanelPartidas.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1011, 504);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_GenerarPartida;
        private System.Windows.Forms.Button btn_historialPartidas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPartidas;
        private System.Windows.Forms.Button btn_archivos;
    }
}

