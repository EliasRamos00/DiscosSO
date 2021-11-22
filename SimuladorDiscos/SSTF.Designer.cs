
namespace SimuladorDiscos
{
    partial class SSTF
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTiempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblLabelTimer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.276673F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.14887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.14887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.14887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.276722F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTimer, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLabelTimer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 487);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProceso,
            this.dgvLlegada,
            this.dgvCPU,
            this.dgvPrioridad,
            this.dgvTiempo,
            this.dgvTiempoEspera});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(58, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 355);
            this.dataGridView1.TabIndex = 7;
            // 
            // dgvProceso
            // 
            this.dgvProceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProceso.HeaderText = "Peticiones";
            this.dgvProceso.Name = "dgvProceso";
            // 
            // dgvLlegada
            // 
            this.dgvLlegada.HeaderText = "Llegada";
            this.dgvLlegada.Name = "dgvLlegada";
            this.dgvLlegada.Width = 70;
            // 
            // dgvCPU
            // 
            this.dgvCPU.HeaderText = "CPU";
            this.dgvCPU.Name = "dgvCPU";
            this.dgvCPU.Width = 70;
            // 
            // dgvPrioridad
            // 
            this.dgvPrioridad.HeaderText = "Pista";
            this.dgvPrioridad.Name = "dgvPrioridad";
            this.dgvPrioridad.Width = 70;
            // 
            // dgvTiempo
            // 
            this.dgvTiempo.HeaderText = "Tiempo de Retorno";
            this.dgvTiempo.Name = "dgvTiempo";
            this.dgvTiempo.Width = 70;
            // 
            // dgvTiempoEspera
            // 
            this.dgvTiempoEspera.HeaderText = "Tiempo de Espera";
            this.dgvTiempoEspera.Name = "dgvTiempoEspera";
            this.dgvTiempoEspera.Width = 70;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(127, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Inicio";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(639, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 36);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Detener";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(406, 42);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 37);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "--:--";
            this.lblTimer.TextChanged += new System.EventHandler(this.lblTimer_TextChanged);
            // 
            // lblLabelTimer
            // 
            this.lblLabelTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLabelTimer.AutoSize = true;
            this.lblLabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelTimer.Location = new System.Drawing.Point(397, 13);
            this.lblLabelTimer.Name = "lblLabelTimer";
            this.lblLabelTimer.Size = new System.Drawing.Size(83, 29);
            this.lblLabelTimer.TabIndex = 5;
            this.lblLabelTimer.Text = "Timer:";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(135, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SSTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 487);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SSTF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSTF";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblLabelTimer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTiempoEspera;
    }
}