
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.loainv = new System.Windows.Forms.Label();
            this.chao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnadmin = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chao);
            this.panel2.Controls.Add(this.loainv);
            this.panel2.Location = new System.Drawing.Point(12, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 73);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // loainv
            // 
            this.loainv.AutoSize = true;
            this.loainv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loainv.ForeColor = System.Drawing.Color.Green;
            this.loainv.Location = new System.Drawing.Point(516, 24);
            this.loainv.Name = "loainv";
            this.loainv.Size = new System.Drawing.Size(67, 25);
            this.loainv.TabIndex = 3;
            this.loainv.Text = "Chào";
            // 
            // chao
            // 
            this.chao.AutoSize = true;
            this.chao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chao.ForeColor = System.Drawing.Color.Green;
            this.chao.Location = new System.Drawing.Point(60, 24);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(67, 25);
            this.chao.TabIndex = 2;
            this.chao.Text = "Chào";
            this.chao.Click += new System.EventHandler(this.chao_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnWinform.Properties.Resources._20180117_155433;
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 381);
            this.panel1.TabIndex = 4;
            // 
            // pnadmin
            // 
            this.pnadmin.BackColor = System.Drawing.SystemColors.Control;
            this.pnadmin.BackgroundImage = global::DoAnWinform.Properties.Resources.tải_xuống;
            this.pnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnadmin.Location = new System.Drawing.Point(773, 159);
            this.pnadmin.Margin = new System.Windows.Forms.Padding(4);
            this.pnadmin.Name = "pnadmin";
            this.pnadmin.Size = new System.Drawing.Size(229, 225);
            this.pnadmin.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1015, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnadmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.Text = "admin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnadmin;
        private System.Windows.Forms.Label loainv;
        private System.Windows.Forms.Label chao;
    }
}