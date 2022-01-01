
namespace DoAnWinform
{
    partial class FormThongKe
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
            this.pnthongke = new System.Windows.Forms.Panel();
            this.bthientai = new System.Windows.Forms.Button();
            this.btdsxedagui = new System.Windows.Forms.Button();
            this.chao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loainv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnthongke
            // 
            this.pnthongke.BackColor = System.Drawing.SystemColors.Control;
            this.pnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnthongke.Location = new System.Drawing.Point(241, 34);
            this.pnthongke.Name = "pnthongke";
            this.pnthongke.Size = new System.Drawing.Size(762, 435);
            this.pnthongke.TabIndex = 4;
            //this.pnthongke.Paint += new System.Windows.Forms.PaintEventHandler(this.pnadmin_Paint);
            // 
            // bthientai
            // 
            this.bthientai.BackColor = System.Drawing.Color.Orange;
            this.bthientai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthientai.ForeColor = System.Drawing.Color.White;
            this.bthientai.Location = new System.Drawing.Point(-3, 260);
            this.bthientai.Name = "bthientai";
            this.bthientai.Size = new System.Drawing.Size(245, 69);
            this.bthientai.TabIndex = 5;
            this.bthientai.Text = "Hiện tại";
            this.bthientai.UseVisualStyleBackColor = false;
            this.bthientai.Click += new System.EventHandler(this.btdanhsachnhanvien_Click);
            // 
            // btdsxedagui
            // 
            this.btdsxedagui.BackColor = System.Drawing.Color.Orange;
            this.btdsxedagui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdsxedagui.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdsxedagui.ForeColor = System.Drawing.Color.White;
            this.btdsxedagui.Location = new System.Drawing.Point(-3, 183);
            this.btdsxedagui.Name = "btdsxedagui";
            this.btdsxedagui.Size = new System.Drawing.Size(245, 69);
            this.btdsxedagui.TabIndex = 6;
            this.btdsxedagui.Text = "Danh sách Đã gửi tại bến";
            this.btdsxedagui.UseVisualStyleBackColor = false;
            this.btdsxedagui.Click += new System.EventHandler(this.btdsxedagui_Click);
            // 
            // chao
            // 
            this.chao.AutoSize = true;
            this.chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chao.ForeColor = System.Drawing.Color.White;
            this.chao.Location = new System.Drawing.Point(236, 6);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(67, 25);
            this.chao.TabIndex = 7;
            this.chao.Text = "Chào";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-3, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Danh sách xe đăng ký vé tháng";
            this.button1.UseVisualStyleBackColor = false;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loainv
            // 
            this.loainv.AutoSize = true;
            this.loainv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loainv.ForeColor = System.Drawing.Color.White;
            this.loainv.Location = new System.Drawing.Point(642, 6);
            this.loainv.Name = "loainv";
            this.loainv.Size = new System.Drawing.Size(67, 25);
            this.loainv.TabIndex = 10;
            this.loainv.Text = "Chào";
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1002, 468);
            this.Controls.Add(this.loainv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.btdsxedagui);
            this.Controls.Add(this.bthientai);
            this.Controls.Add(this.pnthongke);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "thongke";
            this.Text = "thongke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnthongke;
        private System.Windows.Forms.Button bthientai;
        private System.Windows.Forms.Button btdsxedagui;
        private System.Windows.Forms.Label chao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loainv;
    }
}