
namespace SimuladorDiscos
{
    partial class Menu
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
            this.btnFCFS = new System.Windows.Forms.Button();
            this.btnSSTF = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSCAN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFCFS
            // 
            this.btnFCFS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFCFS.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnFCFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFCFS.Location = new System.Drawing.Point(50, 28);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.Size = new System.Drawing.Size(150, 46);
            this.btnFCFS.TabIndex = 0;
            this.btnFCFS.Text = "FCFS (First come first served)";
            this.btnFCFS.UseVisualStyleBackColor = false;
            this.btnFCFS.Click += new System.EventHandler(this.btnFCFS_Click);
            // 
            // btnSSTF
            // 
            this.btnSSTF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSSTF.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSSTF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSSTF.Location = new System.Drawing.Point(50, 105);
            this.btnSSTF.Name = "btnSSTF";
            this.btnSSTF.Size = new System.Drawing.Size(150, 46);
            this.btnSSTF.TabIndex = 1;
            this.btnSSTF.Text = "SSTF (Shortest seek time first)";
            this.btnSSTF.UseVisualStyleBackColor = false;
            this.btnSSTF.Click += new System.EventHandler(this.btnSSTF_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Location = new System.Drawing.Point(140, 241);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 24);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSCAN
            // 
            this.btnSCAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSCAN.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSCAN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSCAN.Location = new System.Drawing.Point(50, 180);
            this.btnSCAN.Name = "btnSCAN";
            this.btnSCAN.Size = new System.Drawing.Size(150, 48);
            this.btnSCAN.TabIndex = 2;
            this.btnSCAN.Text = "SCAN (Algoritmo del elevador o exploración)";
            this.btnSCAN.UseVisualStyleBackColor = false;
            this.btnSCAN.Click += new System.EventHandler(this.btnSCAN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnFCFS, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSSTF, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSCAN, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0991F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.35395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.09762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16505F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.21359F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 271);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFCFS;
        private System.Windows.Forms.Button btnSSTF;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSCAN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

