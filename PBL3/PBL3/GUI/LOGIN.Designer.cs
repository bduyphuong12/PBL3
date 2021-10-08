
namespace PBL3.GUI
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.LogInBut = new System.Windows.Forms.Button();
            this.MatKhauText = new System.Windows.Forms.TextBox();
            this.TenDangNhapText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInBut
            // 
            this.LogInBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBut.ForeColor = System.Drawing.Color.Red;
            this.LogInBut.Location = new System.Drawing.Point(297, 182);
            this.LogInBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogInBut.Name = "LogInBut";
            this.LogInBut.Size = new System.Drawing.Size(108, 43);
            this.LogInBut.TabIndex = 12;
            this.LogInBut.Text = "Login";
            this.LogInBut.UseVisualStyleBackColor = true;
            this.LogInBut.Click += new System.EventHandler(this.LogInBut_Click);
            // 
            // MatKhauText
            // 
            this.MatKhauText.Location = new System.Drawing.Point(384, 138);
            this.MatKhauText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatKhauText.Name = "MatKhauText";
            this.MatKhauText.Size = new System.Drawing.Size(153, 22);
            this.MatKhauText.TabIndex = 11;
            this.MatKhauText.UseSystemPasswordChar = true;
            this.MatKhauText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatKhauText_KeyPress);
            // 
            // TenDangNhapText
            // 
            this.TenDangNhapText.Location = new System.Drawing.Point(384, 84);
            this.TenDangNhapText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TenDangNhapText.Name = "TenDangNhapText";
            this.TenDangNhapText.Size = new System.Drawing.Size(153, 22);
            this.TenDangNhapText.TabIndex = 10;
            this.TenDangNhapText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TenDangNhapText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(227, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(227, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 254);
            this.Controls.Add(this.LogInBut);
            this.Controls.Add(this.MatKhauText);
            this.Controls.Add(this.TenDangNhapText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LOGIN";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInBut;
        private System.Windows.Forms.TextBox MatKhauText;
        private System.Windows.Forms.TextBox TenDangNhapText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}