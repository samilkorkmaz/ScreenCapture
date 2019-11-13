namespace CaptureScreen
{
    partial class Form1
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
            this.btCapture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbNbOfFrames = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCapture
            // 
            this.btCapture.Location = new System.Drawing.Point(433, 12);
            this.btCapture.Name = "btCapture";
            this.btCapture.Size = new System.Drawing.Size(75, 23);
            this.btCapture.TabIndex = 0;
            this.btCapture.Text = "capture...";
            this.btCapture.UseVisualStyleBackColor = true;
            this.btCapture.Click += new System.EventHandler(this.btCapture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 324);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(23, 390);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(28, 13);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Info:";
            // 
            // tbNbOfFrames
            // 
            this.tbNbOfFrames.Location = new System.Drawing.Point(365, 13);
            this.tbNbOfFrames.Name = "tbNbOfFrames";
            this.tbNbOfFrames.Size = new System.Drawing.Size(62, 20);
            this.tbNbOfFrames.TabIndex = 3;
            this.tbNbOfFrames.Text = "500";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(44, 13);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(42, 20);
            this.tbX.TabIndex = 4;
            this.tbX.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "y:";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(129, 13);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(38, 20);
            this.tbY.TabIndex = 6;
            this.tbY.Text = "210";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "w:";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(199, 13);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(53, 20);
            this.tbWidth.TabIndex = 8;
            this.tbWidth.Text = "250";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "h:";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(279, 13);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(53, 20);
            this.tbHeight.TabIndex = 10;
            this.tbHeight.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 416);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbNbOfFrames);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCapture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbNbOfFrames;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label5;
    }
}

