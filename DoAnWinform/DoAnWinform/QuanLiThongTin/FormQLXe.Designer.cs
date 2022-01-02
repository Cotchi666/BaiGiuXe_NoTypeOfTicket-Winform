
namespace DoAnWinform.QuanLiThongTin
{
    partial class FormQLXe
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
            this.btquanlyxe = new System.Windows.Forms.Button();
            this.pnaqlxe = new System.Windows.Forms.Panel();
            this.btquanlyve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chao = new System.Windows.Forms.Label();
            this.loainv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btquanlyxe
            // 
            this.btquanlyxe.BackColor = System.Drawing.Color.OrangeRed;
            this.btquanlyxe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btquanlyxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquanlyxe.ForeColor = System.Drawing.Color.White;
            this.btquanlyxe.Location = new System.Drawing.Point(825, 239);
            this.btquanlyxe.Margin = new System.Windows.Forms.Padding(4);
            this.btquanlyxe.Name = "btquanlyxe";
            this.btquanlyxe.Size = new System.Drawing.Size(136, 36);
            this.btquanlyxe.TabIndex = 3;
            this.btquanlyxe.Text = "Thông tin xe";
            this.btquanlyxe.UseVisualStyleBackColor = false;
            this.btquanlyxe.Click += new System.EventHandler(this.btdanhsachnhanvien_Click);
            // 
            // pnaqlxe
            // 
            this.pnaqlxe.BackColor = System.Drawing.SystemColors.Control;
            this.pnaqlxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnaqlxe.Location = new System.Drawing.Point(13, 20);
            this.pnaqlxe.Margin = new System.Windows.Forms.Padding(4);
            this.pnaqlxe.Name = "pnaqlxe";
            this.pnaqlxe.Size = new System.Drawing.Size(766, 438);
            this.pnaqlxe.TabIndex = 2;
            // 
            // btquanlyve
            // 
            this.btquanlyve.BackColor = System.Drawing.Color.DarkOrange;
            this.btquanlyve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btquanlyve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquanlyve.ForeColor = System.Drawing.Color.White;
            this.btquanlyve.Location = new System.Drawing.Point(825, 283);
            this.btquanlyve.Margin = new System.Windows.Forms.Padding(4);
            this.btquanlyve.Name = "btquanlyve";
            this.btquanlyve.Size = new System.Drawing.Size(136, 39);
            this.btquanlyve.TabIndex = 4;
            this.btquanlyve.Text = "Thông tin vé";
            this.btquanlyve.UseVisualStyleBackColor = false;
            this.btquanlyve.Click += new System.EventHandler(this.btquanlyve_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(824, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thông tin bãi xe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chao
            // 
            this.chao.AutoSize = true;
            this.chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chao.ForeColor = System.Drawing.Color.White;
            this.chao.Location = new System.Drawing.Point(786, 20);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(118, 25);
            this.chao.TabIndex = 6;
            this.chao.Text = "Nhân viên";
            // 
            // loainv
            // 
            this.loainv.AutoSize = true;
            this.loainv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loainv.ForeColor = System.Drawing.Color.White;
            this.loainv.Location = new System.Drawing.Point(786, 59);
            this.loainv.Name = "loainv";
            this.loainv.Size = new System.Drawing.Size(98, 25);
            this.loainv.TabIndex = 8;
            this.loainv.Text = "Chức vụ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(928, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 45);
            this.panel1.TabIndex = 0;
            // 
            // FormQLXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1022, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btquanlyve);
            this.Controls.Add(this.btquanlyxe);
            this.Controls.Add(this.loainv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.pnaqlxe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQLXe";
            this.Text = "quanlyxe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btquanlyxe;
        private System.Windows.Forms.Panel pnaqlxe;
        private System.Windows.Forms.Button btquanlyve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label chao;
        private System.Windows.Forms.Label loainv;
        private System.Windows.Forms.Panel panel1;
    }
}