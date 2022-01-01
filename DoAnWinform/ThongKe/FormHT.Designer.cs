
namespace DoAnWinform
{
    partial class FormHT
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
            this.dataGridViewtkht = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tongxemayht = new System.Windows.Forms.Label();
            this.tongotoht = new System.Windows.Forms.Label();
            this.tongxeht = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txttimkiemadmim = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tongtong = new System.Windows.Forms.Label();
            this.tongototrong = new System.Windows.Forms.Label();
            this.tongxemaytrong = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtkht)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewtkht
            // 
            this.dataGridViewtkht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewtkht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtkht.Location = new System.Drawing.Point(2, 157);
            this.dataGridViewtkht.Name = "dataGridViewtkht";
            this.dataGridViewtkht.Size = new System.Drawing.Size(766, 278);
            this.dataGridViewtkht.TabIndex = 4;
           
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tongxemayht);
            this.groupBox1.Controls.Add(this.tongotoht);
            this.groupBox1.Controls.Add(this.tongxeht);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số xe trong bến xe hiện tại.";
            // 
            // tongxemayht
            // 
            this.tongxemayht.AutoSize = true;
            this.tongxemayht.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tongxemayht.Location = new System.Drawing.Point(612, 16);
            this.tongxemayht.Name = "tongxemayht";
            this.tongxemayht.Size = new System.Drawing.Size(44, 18);
            this.tongxemayht.TabIndex = 5;
            this.tongxemayht.Text = "số xe";
            // 
            // tongotoht
            // 
            this.tongotoht.AutoSize = true;
            this.tongotoht.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tongotoht.Location = new System.Drawing.Point(354, 16);
            this.tongotoht.Name = "tongotoht";
            this.tongotoht.Size = new System.Drawing.Size(44, 18);
            this.tongotoht.TabIndex = 4;
            this.tongotoht.Text = "số xe";
            // 
            // tongxeht
            // 
            this.tongxeht.AutoSize = true;
            this.tongxeht.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tongxeht.Location = new System.Drawing.Point(137, 16);
            this.tongxeht.Name = "tongxeht";
            this.tongxeht.Size = new System.Drawing.Size(44, 18);
            this.tongxeht.TabIndex = 3;
            this.tongxeht.Text = "số xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(544, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xe máy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(288, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xe ô tô:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số xe:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.txttimkiemadmim);
            this.panel6.Location = new System.Drawing.Point(22, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(729, 55);
            this.panel6.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm xe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttimkiemadmim
            // 
            this.txttimkiemadmim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemadmim.Location = new System.Drawing.Point(3, 18);
            this.txttimkiemadmim.Name = "txttimkiemadmim";
            this.txttimkiemadmim.Size = new System.Drawing.Size(157, 24);
            this.txttimkiemadmim.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(45, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tổng vị trí trống:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(288, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 18);
            this.label17.TabIndex = 1;
            this.label17.Text = "vị trí cho ô tô:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(544, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 18);
            this.label16.TabIndex = 2;
            this.label16.Text = "Vị trí cho xe máy:";
            // 
            // tongtong
            // 
            this.tongtong.AutoSize = true;
            this.tongtong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tongtong.Location = new System.Drawing.Point(161, 20);
            this.tongtong.Name = "tongtong";
            this.tongtong.Size = new System.Drawing.Size(44, 18);
            this.tongtong.TabIndex = 3;
            this.tongtong.Text = "số xe";
            // 
            // tongototrong
            // 
            this.tongototrong.AutoSize = true;
            this.tongototrong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tongototrong.Location = new System.Drawing.Point(391, 20);
            this.tongototrong.Name = "tongototrong";
            this.tongototrong.Size = new System.Drawing.Size(44, 18);
            this.tongototrong.TabIndex = 4;
            this.tongototrong.Text = "số xe";
            // 
            // tongxemaytrong
            // 
            this.tongxemaytrong.AutoSize = true;
            this.tongxemaytrong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tongxemaytrong.Location = new System.Drawing.Point(670, 20);
            this.tongxemaytrong.Name = "tongxemaytrong";
            this.tongxemaytrong.Size = new System.Drawing.Size(44, 18);
            this.tongxemaytrong.TabIndex = 5;
            this.tongxemaytrong.Text = "số xe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tongxemaytrong);
            this.groupBox3.Controls.Add(this.tongototrong);
            this.groupBox3.Controls.Add(this.tongtong);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(12, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 41);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vị trí trống.";
            // 
            // hientai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 435);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewtkht);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hientai";
            this.Text = "xedangtrongben";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtkht)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewtkht;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tongxemayht;
        private System.Windows.Forms.Label tongotoht;
        private System.Windows.Forms.Label tongxeht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttimkiemadmim;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label tongtong;
        private System.Windows.Forms.Label tongototrong;
        private System.Windows.Forms.Label tongxemaytrong;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}