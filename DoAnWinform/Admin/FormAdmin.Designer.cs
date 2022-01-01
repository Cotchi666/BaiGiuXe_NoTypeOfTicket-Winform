
namespace DoAnWinform
{
    partial class FormAdmin
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
            this.pnadmin = new System.Windows.Forms.Panel();
            this.btdanhsachnhanvien = new System.Windows.Forms.Button();
            this.chao = new System.Windows.Forms.Label();
            this.loainv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnadmin
            // 
            this.pnadmin.BackColor = System.Drawing.SystemColors.Control;
            this.pnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnadmin.Location = new System.Drawing.Point(241, 34);
            this.pnadmin.Margin = new System.Windows.Forms.Padding(4);
            this.pnadmin.Name = "pnadmin";
            this.pnadmin.Size = new System.Drawing.Size(765, 437);
            this.pnadmin.TabIndex = 0;
            this.pnadmin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnadmin_Paint);
            // 
            // btdanhsachnhanvien
            // 
            this.btdanhsachnhanvien.BackColor = System.Drawing.Color.Orange;
            this.btdanhsachnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdanhsachnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdanhsachnhanvien.Location = new System.Drawing.Point(-3, 183);
            this.btdanhsachnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.btdanhsachnhanvien.Name = "btdanhsachnhanvien";
            this.btdanhsachnhanvien.Size = new System.Drawing.Size(245, 69);
            this.btdanhsachnhanvien.TabIndex = 1;
            this.btdanhsachnhanvien.Text = "Danh sách nhân viên";
            this.btdanhsachnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdanhsachnhanvien.UseVisualStyleBackColor = false;
            this.btdanhsachnhanvien.Click += new System.EventHandler(this.btdanhsachnhanvien_Click);
            // 
            // chao
            // 
            this.chao.AutoSize = true;
            this.chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chao.Location = new System.Drawing.Point(236, 5);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(67, 25);
            this.chao.TabIndex = 2;
            this.chao.Text = "Chào";
            // 
            // loainv
            // 
            this.loainv.AutoSize = true;
            this.loainv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loainv.Location = new System.Drawing.Point(642, 6);
            this.loainv.Name = "loainv";
            this.loainv.Size = new System.Drawing.Size(67, 25);
            this.loainv.TabIndex = 3;
            this.loainv.Text = "Chào";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1015, 474);
            this.Controls.Add(this.loainv);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.btdanhsachnhanvien);
            this.Controls.Add(this.pnadmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnadmin;
        private System.Windows.Forms.Button btdanhsachnhanvien;
        private System.Windows.Forms.Label chao;
        private System.Windows.Forms.Label loainv;
    }
}