namespace machine
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.qr1 = new System.Windows.Forms.PictureBox();
            this.qr2 = new System.Windows.Forms.PictureBox();
            this.qr3 = new System.Windows.Forms.PictureBox();
            this.bnt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qr3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::machine.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::machine.Properties.Resources.MoMo_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(61, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::machine.Properties.Resources.zalopay;
            this.pictureBox3.Location = new System.Drawing.Point(61, 309);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // qr1
            // 
            this.qr1.Image = ((System.Drawing.Image)(resources.GetObject("qr1.Image")));
            this.qr1.Location = new System.Drawing.Point(402, 65);
            this.qr1.Name = "qr1";
            this.qr1.Size = new System.Drawing.Size(358, 303);
            this.qr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qr1.TabIndex = 3;
            this.qr1.TabStop = false;
            // 
            // qr2
            // 
            this.qr2.Image = ((System.Drawing.Image)(resources.GetObject("qr2.Image")));
            this.qr2.Location = new System.Drawing.Point(402, 65);
            this.qr2.Name = "qr2";
            this.qr2.Size = new System.Drawing.Size(358, 303);
            this.qr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qr2.TabIndex = 4;
            this.qr2.TabStop = false;
            // 
            // qr3
            // 
            this.qr3.Image = ((System.Drawing.Image)(resources.GetObject("qr3.Image")));
            this.qr3.Location = new System.Drawing.Point(402, 65);
            this.qr3.Name = "qr3";
            this.qr3.Size = new System.Drawing.Size(358, 303);
            this.qr3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qr3.TabIndex = 5;
            this.qr3.TabStop = false;
            // 
            // bnt1
            // 
            this.bnt1.Location = new System.Drawing.Point(477, 387);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(213, 38);
            this.bnt1.TabIndex = 6;
            this.bnt1.Text = "Hoan tat";
            this.bnt1.UseVisualStyleBackColor = true;
            this.bnt1.Click += new System.EventHandler(this.bnt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(450, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn hình thức quét mã QR";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt1);
            this.Controls.Add(this.qr3);
            this.Controls.Add(this.qr2);
            this.Controls.Add(this.qr1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Pay by QR";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qr3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox qr1;
        private PictureBox qr2;
        private PictureBox qr3;
        private Button bnt1;
        private Label label1;
    }
}