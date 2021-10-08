
namespace PBL3.GUI
{
    partial class Form_DOANH_THU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DOANH_THU));
            this.groupDT = new System.Windows.Forms.GroupBox();
            this.dataCT = new System.Windows.Forms.DataGridView();
            this.textTT = new System.Windows.Forms.TextBox();
            this.butEx = new System.Windows.Forms.Button();
            this.butCT = new System.Windows.Forms.Button();
            this.timeD = new System.Windows.Forms.DateTimePicker();
            this.timeT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTK = new System.Windows.Forms.DataGridView();
            this.lbnhanvien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTK)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDT
            // 
            this.groupDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupDT.Controls.Add(this.dataCT);
            this.groupDT.Controls.Add(this.textTT);
            this.groupDT.Controls.Add(this.butEx);
            this.groupDT.Controls.Add(this.butCT);
            this.groupDT.Controls.Add(this.timeD);
            this.groupDT.Controls.Add(this.timeT);
            this.groupDT.Controls.Add(this.label3);
            this.groupDT.Controls.Add(this.label2);
            this.groupDT.Controls.Add(this.label1);
            this.groupDT.Controls.Add(this.dataTK);
            this.groupDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDT.Location = new System.Drawing.Point(0, 0);
            this.groupDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDT.Name = "groupDT";
            this.groupDT.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDT.Size = new System.Drawing.Size(1067, 491);
            this.groupDT.TabIndex = 11;
            this.groupDT.TabStop = false;
            this.groupDT.Text = "Doanh Thu";
            // 
            // dataCT
            // 
            this.dataCT.BackgroundColor = System.Drawing.Color.White;
            this.dataCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCT.Location = new System.Drawing.Point(755, 122);
            this.dataCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataCT.Name = "dataCT";
            this.dataCT.RowHeadersWidth = 51;
            this.dataCT.Size = new System.Drawing.Size(272, 340);
            this.dataCT.TabIndex = 20;
            // 
            // textTT
            // 
            this.textTT.BackColor = System.Drawing.Color.White;
            this.textTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTT.Location = new System.Drawing.Point(133, 80);
            this.textTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTT.Name = "textTT";
            this.textTT.ReadOnly = true;
            this.textTT.Size = new System.Drawing.Size(273, 26);
            this.textTT.TabIndex = 19;
            // 
            // butEx
            // 
            this.butEx.BackColor = System.Drawing.Color.White;
            this.butEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEx.ForeColor = System.Drawing.Color.Red;
            this.butEx.Image = ((System.Drawing.Image)(resources.GetObject("butEx.Image")));
            this.butEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butEx.Location = new System.Drawing.Point(616, 62);
            this.butEx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butEx.Name = "butEx";
            this.butEx.Size = new System.Drawing.Size(111, 43);
            this.butEx.TabIndex = 18;
            this.butEx.Text = "Exit";
            this.butEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butEx.UseVisualStyleBackColor = false;
            this.butEx.Click += new System.EventHandler(this.butEx_Click);
            // 
            // butCT
            // 
            this.butCT.BackColor = System.Drawing.Color.White;
            this.butCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCT.ForeColor = System.Drawing.Color.Red;
            this.butCT.Image = ((System.Drawing.Image)(resources.GetObject("butCT.Image")));
            this.butCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCT.Location = new System.Drawing.Point(467, 62);
            this.butCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCT.Name = "butCT";
            this.butCT.Size = new System.Drawing.Size(121, 43);
            this.butCT.TabIndex = 17;
            this.butCT.Text = "Chi Tiết";
            this.butCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCT.UseVisualStyleBackColor = false;
            this.butCT.Click += new System.EventHandler(this.butCT_Click);
            // 
            // timeD
            // 
            this.timeD.Location = new System.Drawing.Point(467, 27);
            this.timeD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeD.Name = "timeD";
            this.timeD.Size = new System.Drawing.Size(265, 22);
            this.timeD.TabIndex = 16;
            this.timeD.ValueChanged += new System.EventHandler(this.timeD_ValueChanged);
            // 
            // timeT
            // 
            this.timeT.Location = new System.Drawing.Point(133, 27);
            this.timeT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeT.Name = "timeT";
            this.timeT.Size = new System.Drawing.Size(273, 22);
            this.timeT.TabIndex = 15;
            this.timeT.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.timeT.ValueChanged += new System.EventHandler(this.timeT_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ ";
            // 
            // dataTK
            // 
            this.dataTK.BackgroundColor = System.Drawing.Color.White;
            this.dataTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTK.Location = new System.Drawing.Point(20, 122);
            this.dataTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataTK.Name = "dataTK";
            this.dataTK.RowHeadersWidth = 51;
            this.dataTK.Size = new System.Drawing.Size(712, 340);
            this.dataTK.TabIndex = 11;
            this.dataTK.DataSourceChanged += new System.EventHandler(this.dataTK_DataSourceChanged);
            // 
            // lbnhanvien
            // 
            this.lbnhanvien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbnhanvien.AutoSize = true;
            this.lbnhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbnhanvien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnhanvien.ForeColor = System.Drawing.Color.Red;
            this.lbnhanvien.Location = new System.Drawing.Point(433, -1);
            this.lbnhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnhanvien.Name = "lbnhanvien";
            this.lbnhanvien.Size = new System.Drawing.Size(99, 18);
            this.lbnhanvien.TabIndex = 2;
            this.lbnhanvien.Text = "DOANH THU";
            this.lbnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lbnhanvien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 19);
            this.panel1.TabIndex = 12;
            // 
            // Form_DOANH_THU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupDT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_DOANH_THU";
            this.Text = "Form_DOANH_THU";
            this.groupDT.ResumeLayout(false);
            this.groupDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDT;
        private System.Windows.Forms.Button butEx;
        private System.Windows.Forms.Button butCT;
        private System.Windows.Forms.DateTimePicker timeD;
        private System.Windows.Forms.DateTimePicker timeT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataTK;
        private System.Windows.Forms.TextBox textTT;
        private System.Windows.Forms.DataGridView dataCT;
        private System.Windows.Forms.Label lbnhanvien;
        private System.Windows.Forms.Panel panel1;
    }
}