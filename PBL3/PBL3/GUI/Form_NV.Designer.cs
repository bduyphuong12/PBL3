
namespace PBL3.GUI
{
    partial class Form_NV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbsort = new System.Windows.Forms.ComboBox();
            this.btsort = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btshow = new System.Windows.Forms.Button();
            this.datagridNV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbnhanvien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridNV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cbbsort);
            this.groupBox1.Controls.Add(this.btsort);
            this.groupBox1.Controls.Add(this.btsearch);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btedit);
            this.groupBox1.Controls.Add(this.btadd);
            this.groupBox1.Controls.Add(this.btshow);
            this.groupBox1.Controls.Add(this.datagridNV);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 344);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cbbsort
            // 
            this.cbbsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsort.FormattingEnabled = true;
            this.cbbsort.Location = new System.Drawing.Point(633, 27);
            this.cbbsort.Name = "cbbsort";
            this.cbbsort.Size = new System.Drawing.Size(160, 24);
            this.cbbsort.TabIndex = 32;
            // 
            // btsort
            // 
            this.btsort.BackColor = System.Drawing.Color.White;
            this.btsort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsort.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btsort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btsort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btsort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btsort.Image = ((System.Drawing.Image)(resources.GetObject("btsort.Image")));
            this.btsort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsort.Location = new System.Drawing.Point(809, 25);
            this.btsort.Name = "btsort";
            this.btsort.Size = new System.Drawing.Size(83, 27);
            this.btsort.TabIndex = 31;
            this.btsort.Text = "Sort";
            this.btsort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsort.UseVisualStyleBackColor = false;
            this.btsort.Click += new System.EventHandler(this.btsort_Click_1);
            // 
            // btsearch
            // 
            this.btsearch.BackColor = System.Drawing.Color.White;
            this.btsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsearch.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btsearch.Image = ((System.Drawing.Image)(resources.GetObject("btsearch.Image")));
            this.btsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsearch.Location = new System.Drawing.Point(174, 27);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(115, 27);
            this.btsearch.TabIndex = 25;
            this.btsearch.Text = "Search";
            this.btsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click_1);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(304, 30);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(160, 22);
            this.txtsearch.TabIndex = 30;
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.White;
            this.btxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxoa.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btxoa.Image = ((System.Drawing.Image)(resources.GetObject("btxoa.Image")));
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(29, 265);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(114, 31);
            this.btxoa.TabIndex = 29;
            this.btxoa.Text = "Delete";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click_1);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.White;
            this.btedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btedit.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedit.Location = new System.Drawing.Point(29, 207);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(114, 30);
            this.btedit.TabIndex = 28;
            this.btedit.Text = "Edit";
            this.btedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click_1);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.White;
            this.btadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btadd.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btadd.Image = ((System.Drawing.Image)(resources.GetObject("btadd.Image")));
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(29, 146);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(114, 31);
            this.btadd.TabIndex = 27;
            this.btadd.Text = "Add";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click_1);
            // 
            // btshow
            // 
            this.btshow.BackColor = System.Drawing.Color.White;
            this.btshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btshow.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.btshow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btshow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btshow.Image = ((System.Drawing.Image)(resources.GetObject("btshow.Image")));
            this.btshow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btshow.Location = new System.Drawing.Point(29, 86);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(114, 33);
            this.btshow.TabIndex = 26;
            this.btshow.Text = "Show";
            this.btshow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btshow.UseVisualStyleBackColor = false;
            this.btshow.Click += new System.EventHandler(this.btshow_Click_1);
            // 
            // datagridNV
            // 
            this.datagridNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridNV.Location = new System.Drawing.Point(174, 66);
            this.datagridNV.Name = "datagridNV";
            this.datagridNV.Size = new System.Drawing.Size(718, 271);
            this.datagridNV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbnhanvien);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 55);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbnhanvien
            // 
            this.lbnhanvien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbnhanvien.AutoSize = true;
            this.lbnhanvien.BackColor = System.Drawing.Color.White;
            this.lbnhanvien.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnhanvien.ForeColor = System.Drawing.Color.Red;
            this.lbnhanvien.Location = new System.Drawing.Point(404, 12);
            this.lbnhanvien.Name = "lbnhanvien";
            this.lbnhanvien.Size = new System.Drawing.Size(154, 29);
            this.lbnhanvien.TabIndex = 1;
            this.lbnhanvien.Text = "NHÂN VIÊN";
            this.lbnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(927, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Nhân Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbsort;
        private System.Windows.Forms.Button btsort;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btshow;
        private System.Windows.Forms.DataGridView datagridNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnhanvien;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}