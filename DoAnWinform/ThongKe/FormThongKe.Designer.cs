
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
            this.chao = new System.Windows.Forms.Label();
            this.loainv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnthongke
            // 
            this.pnthongke.BackColor = System.Drawing.SystemColors.Control;
            this.pnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnthongke.Location = new System.Drawing.Point(90, 34);
            this.pnthongke.Name = "pnthongke";
            this.pnthongke.Size = new System.Drawing.Size(796, 435);
            this.pnthongke.TabIndex = 4;
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
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1002, 468);
            this.Controls.Add(this.loainv);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.pnthongke);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThongKe";
            this.Text = "thongke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnthongke;
        private System.Windows.Forms.Label chao;
        private System.Windows.Forms.Label loainv;
    }
}