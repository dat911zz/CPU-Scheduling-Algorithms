
namespace CPU_Scheduling_Algorithms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.CountTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.GanttChartPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotThoiGianDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotThoiGianXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreemptiveBtn = new System.Windows.Forms.RadioButton();
            this.NonPreemptiveBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.RunBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FCFS_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SJF_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Priority_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.RR_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnThuậtToánTạiĐâyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Algorithm = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(42, 446);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(810, 143);
            this.txtConsole.TabIndex = 22;
            this.txtConsole.WordWrap = false;
            // 
            // CountTime
            // 
            this.CountTime.AutoSize = true;
            this.CountTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTime.Location = new System.Drawing.Point(97, 394);
            this.CountTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountTime.Name = "CountTime";
            this.CountTime.Size = new System.Drawing.Size(16, 18);
            this.CountTime.TabIndex = 18;
            this.CountTime.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Gantt Chart";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Red;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(196, 231);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(84, 52);
            this.ClearBtn.TabIndex = 26;
            this.ClearBtn.Text = "Reset";
            this.toolTip1.SetToolTip(this.ClearBtn, "Nút làm lại cuộc đời");
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // GanttChartPanel
            // 
            this.GanttChartPanel.AutoScroll = true;
            this.GanttChartPanel.AutoScrollMargin = new System.Drawing.Size(5000, 0);
            this.GanttChartPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GanttChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GanttChartPanel.Location = new System.Drawing.Point(42, 305);
            this.GanttChartPanel.Margin = new System.Windows.Forms.Padding(4);
            this.GanttChartPanel.Name = "GanttChartPanel";
            this.GanttChartPanel.Size = new System.Drawing.Size(810, 84);
            this.GanttChartPanel.TabIndex = 25;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(681, 113);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(84, 42);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Remove";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(681, 65);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(84, 42);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.CotThoiGianDen,
            this.CotThoiGianXuLy});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(286, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(387, 216);
            this.dataGridView1.TabIndex = 19;
            // 
            // stt
            // 
            this.stt.HeaderText = "Tiến trình";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // CotThoiGianDen
            // 
            this.CotThoiGianDen.HeaderText = "Thời gian đến";
            this.CotThoiGianDen.MinimumWidth = 6;
            this.CotThoiGianDen.Name = "CotThoiGianDen";
            this.CotThoiGianDen.Width = 125;
            // 
            // CotThoiGianXuLy
            // 
            this.CotThoiGianXuLy.HeaderText = "Thời gian xử lý";
            this.CotThoiGianXuLy.MinimumWidth = 6;
            this.CotThoiGianXuLy.Name = "CotThoiGianXuLy";
            this.CotThoiGianXuLy.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PreemptiveBtn);
            this.panel1.Controls.Add(this.NonPreemptiveBtn);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(116, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 86);
            this.panel1.TabIndex = 21;
            // 
            // PreemptiveBtn
            // 
            this.PreemptiveBtn.AutoSize = true;
            this.PreemptiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreemptiveBtn.Location = new System.Drawing.Point(8, 44);
            this.PreemptiveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PreemptiveBtn.Name = "PreemptiveBtn";
            this.PreemptiveBtn.Size = new System.Drawing.Size(133, 20);
            this.PreemptiveBtn.TabIndex = 3;
            this.PreemptiveBtn.Text = "Không độc quyền";
            this.PreemptiveBtn.UseVisualStyleBackColor = true;
            // 
            // NonPreemptiveBtn
            // 
            this.NonPreemptiveBtn.AutoSize = true;
            this.NonPreemptiveBtn.Checked = true;
            this.NonPreemptiveBtn.Location = new System.Drawing.Point(8, 18);
            this.NonPreemptiveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NonPreemptiveBtn.Name = "NonPreemptiveBtn";
            this.NonPreemptiveBtn.Size = new System.Drawing.Size(97, 21);
            this.NonPreemptiveBtn.TabIndex = 2;
            this.NonPreemptiveBtn.TabStop = true;
            this.NonPreemptiveBtn.Text = "Độc quyền";
            this.NonPreemptiveBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Result";
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(681, 231);
            this.RunBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(84, 52);
            this.RunBtn.TabIndex = 20;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Định Thời CPU";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.chọnThuậtToánTạiĐâyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 31);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FCFS_menu,
            this.SJF_menu,
            this.Priority_menu,
            this.RR_menu});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 27);
            this.toolStripMenuItem1.Text = "Chọn Thuật Toán";
            // 
            // FCFS_menu
            // 
            this.FCFS_menu.DoubleClickEnabled = true;
            this.FCFS_menu.Name = "FCFS_menu";
            this.FCFS_menu.Size = new System.Drawing.Size(224, 28);
            this.FCFS_menu.Text = "FCFS";
            this.FCFS_menu.Click += new System.EventHandler(this.FCFS_menu_Click);
            // 
            // SJF_menu
            // 
            this.SJF_menu.Name = "SJF_menu";
            this.SJF_menu.Size = new System.Drawing.Size(224, 28);
            this.SJF_menu.Text = "SJF";
            this.SJF_menu.Click += new System.EventHandler(this.SJF_menu_Click);
            // 
            // Priority_menu
            // 
            this.Priority_menu.Name = "Priority_menu";
            this.Priority_menu.Size = new System.Drawing.Size(224, 28);
            this.Priority_menu.Text = "Priority";
            this.Priority_menu.Click += new System.EventHandler(this.Priority_menu_Click);
            // 
            // RR_menu
            // 
            this.RR_menu.Name = "RR_menu";
            this.RR_menu.Size = new System.Drawing.Size(224, 28);
            this.RR_menu.Text = "Round Robin";
            this.RR_menu.Click += new System.EventHandler(this.RR_menu_Click);
            // 
            // chọnThuậtToánTạiĐâyToolStripMenuItem
            // 
            this.chọnThuậtToánTạiĐâyToolStripMenuItem.Enabled = false;
            this.chọnThuậtToánTạiĐâyToolStripMenuItem.Name = "chọnThuậtToánTạiĐâyToolStripMenuItem";
            this.chọnThuậtToánTạiĐâyToolStripMenuItem.ShowShortcutKeys = false;
            this.chọnThuậtToánTạiĐâyToolStripMenuItem.Size = new System.Drawing.Size(216, 27);
            this.chọnThuậtToánTạiĐâyToolStripMenuItem.Text = "<---- Chọn thuật toán tại đây";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Algorithm);
            this.panel2.Location = new System.Drawing.Point(116, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 42);
            this.panel2.TabIndex = 34;
            // 
            // Algorithm
            // 
            this.Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Algorithm.ForeColor = System.Drawing.Color.Black;
            this.Algorithm.Location = new System.Drawing.Point(14, 8);
            this.Algorithm.Margin = new System.Windows.Forms.Padding(4);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.ReadOnly = true;
            this.Algorithm.Size = new System.Drawing.Size(134, 24);
            this.Algorithm.TabIndex = 0;
            this.Algorithm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.CountTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.GanttChartPanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label CountTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel GanttChartPanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton PreemptiveBtn;
        private System.Windows.Forms.RadioButton NonPreemptiveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FCFS_menu;
        private System.Windows.Forms.ToolStripMenuItem SJF_menu;
        private System.Windows.Forms.ToolStripMenuItem Priority_menu;
        private System.Windows.Forms.ToolStripMenuItem RR_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Algorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotThoiGianDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotThoiGianXuLy;
        private System.Windows.Forms.ToolStripMenuItem chọnThuậtToánTạiĐâyToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

