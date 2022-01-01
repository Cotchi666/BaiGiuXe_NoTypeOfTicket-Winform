
namespace DoAnWinform
{
    partial class FormManHinhChinh
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
            this.btadmin = new System.Windows.Forms.Button();
            this.bttrogiup = new System.Windows.Forms.Button();
            this.btthongke = new System.Windows.Forms.Button();
            this.btquanlyxe = new System.Windows.Forms.Button();
            this.pnmain = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btadmin
            // 
            this.btadmin.BackColor = System.Drawing.SystemColors.Control;
            this.btadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadmin.Location = new System.Drawing.Point(7, 16);
            this.btadmin.Margin = new System.Windows.Forms.Padding(4);
            this.btadmin.Name = "btadmin";
            this.btadmin.Size = new System.Drawing.Size(112, 28);
            this.btadmin.TabIndex = 2;
            this.btadmin.Text = "Tài khoản";
            this.btadmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btadmin.UseVisualStyleBackColor = false;
            this.btadmin.Click += new System.EventHandler(this.btadmin_Click);
            // 
            // bttrogiup
            // 
            this.bttrogiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttrogiup.Location = new System.Drawing.Point(180, 52);
            this.bttrogiup.Margin = new System.Windows.Forms.Padding(4);
            this.bttrogiup.Name = "bttrogiup";
            this.bttrogiup.Size = new System.Drawing.Size(109, 31);
            this.bttrogiup.TabIndex = 5;
            this.bttrogiup.Text = "Trợ giúp";
            this.bttrogiup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttrogiup.UseVisualStyleBackColor = true;
            this.bttrogiup.Click += new System.EventHandler(this.bttrogiup_Click);
            // 
            // btthongke
            // 
            this.btthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthongke.Location = new System.Drawing.Point(180, 13);
            this.btthongke.Margin = new System.Windows.Forms.Padding(4);
            this.btthongke.Name = "btthongke";
            this.btthongke.Size = new System.Drawing.Size(112, 31);
            this.btthongke.TabIndex = 4;
            this.btthongke.Text = "Thống kê";
            this.btthongke.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btthongke.UseVisualStyleBackColor = true;
            this.btthongke.Click += new System.EventHandler(this.btthongke_Click_1);
            // 
            // btquanlyxe
            // 
            this.btquanlyxe.BackColor = System.Drawing.SystemColors.Control;
            this.btquanlyxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquanlyxe.Location = new System.Drawing.Point(7, 52);
            this.btquanlyxe.Margin = new System.Windows.Forms.Padding(4);
            this.btquanlyxe.Name = "btquanlyxe";
            this.btquanlyxe.Size = new System.Drawing.Size(112, 27);
            this.btquanlyxe.TabIndex = 3;
            this.btquanlyxe.Text = "Quản lý";
            this.btquanlyxe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btquanlyxe.UseVisualStyleBackColor = false;
            this.btquanlyxe.Click += new System.EventHandler(this.btquanlyxe_Click_1);
            // 
            // pnmain
            // 
            this.pnmain.Location = new System.Drawing.Point(-3, 87);
            this.pnmain.Margin = new System.Windows.Forms.Padding(4);
            this.pnmain.Name = "pnmain";
            this.pnmain.Size = new System.Drawing.Size(1008, 471);
            this.pnmain.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(443, 13);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(509, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // FormManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1005, 558);
            this.Controls.Add(this.bttrogiup);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btthongke);
            this.Controls.Add(this.btadmin);
            this.Controls.Add(this.btquanlyxe);
            this.Controls.Add(this.pnmain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý bãi đỗ xe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btadmin;
        private System.Windows.Forms.Button bttrogiup;
        private System.Windows.Forms.Button btthongke;
        private System.Windows.Forms.Button btquanlyxe;
        private System.Windows.Forms.Panel pnmain;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}