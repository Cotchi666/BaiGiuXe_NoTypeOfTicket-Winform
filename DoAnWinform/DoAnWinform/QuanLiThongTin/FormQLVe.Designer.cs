
namespace DoAnWinform
{
    partial class FormQLVe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vetrong = new System.Windows.Forms.Label();
            this.tonsove = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewve = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewve)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vetrong);
            this.groupBox1.Controls.Add(this.tonsove);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vé";
            // 
            // vetrong
            // 
            this.vetrong.AutoSize = true;
            this.vetrong.Location = new System.Drawing.Point(510, 33);
            this.vetrong.Name = "vetrong";
            this.vetrong.Size = new System.Drawing.Size(86, 18);
            this.vetrong.TabIndex = 3;
            this.vetrong.Text = "Tổng số vé:";
            // 
            // tonsove
            // 
            this.tonsove.AutoSize = true;
            this.tonsove.Location = new System.Drawing.Point(138, 33);
            this.tonsove.Name = "tonsove";
            this.tonsove.Size = new System.Drawing.Size(86, 18);
            this.tonsove.TabIndex = 2;
            this.tonsove.Text = "Tổng số vé:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vé chưa phát ra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số vé:";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewve
            // 
            this.dataGridViewve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewve.Location = new System.Drawing.Point(1, 178);
            this.dataGridViewve.Name = "dataGridViewve";
            this.dataGridViewve.Size = new System.Drawing.Size(760, 257);
            this.dataGridViewve.TabIndex = 1;
            //this.dataGridViewve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewve_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Danh sách tổng số vé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 35);
            this.button2.TabIndex = 3;
            this.button2.Tag = " ";
            this.button2.Text = "Danh sách vé đang dùng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 35);
            this.button3.TabIndex = 4;
            this.button3.Tag = " ";
            this.button3.Text = "Danh sách vé trống";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 35);
            this.button4.TabIndex = 5;
            this.button4.Tag = " ";
            this.button4.Text = "Tạo thêm vé";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // danhsachve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 435);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewve);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "danhsachve";
            this.Text = "danhsachve";
            //this.Load += new System.EventHandler(this.danhsachve_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label vetrong;
        private System.Windows.Forms.Label tonsove;
    }

}
