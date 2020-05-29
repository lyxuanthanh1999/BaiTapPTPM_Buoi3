namespace ThietKeControl
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.lbGio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPhut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGiay = new System.Windows.Forms.Label();
            this.lbMiliGiay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(165, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_click);
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(293, 104);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(92, 34);
            this.btnLap.TabIndex = 1;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGio.Location = new System.Drawing.Point(159, 46);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(43, 32);
            this.lbGio.TabIndex = 2;
            this.lbGio.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // lbPhut
            // 
            this.lbPhut.AutoSize = true;
            this.lbPhut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhut.Location = new System.Drawing.Point(238, 46);
            this.lbPhut.Name = "lbPhut";
            this.lbPhut.Size = new System.Drawing.Size(43, 32);
            this.lbPhut.TabIndex = 2;
            this.lbPhut.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = ":";
            // 
            // lbGiay
            // 
            this.lbGiay.AutoSize = true;
            this.lbGiay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiay.Location = new System.Drawing.Point(317, 46);
            this.lbGiay.Name = "lbGiay";
            this.lbGiay.Size = new System.Drawing.Size(43, 32);
            this.lbGiay.TabIndex = 2;
            this.lbGiay.Text = "00";
            // 
            // lbMiliGiay
            // 
            this.lbMiliGiay.AutoSize = true;
            this.lbMiliGiay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiliGiay.Location = new System.Drawing.Point(366, 46);
            this.lbMiliGiay.Name = "lbMiliGiay";
            this.lbMiliGiay.Size = new System.Drawing.Size(43, 32);
            this.lbMiliGiay.TabIndex = 2;
            this.lbMiliGiay.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMiliGiay);
            this.Controls.Add(this.lbGiay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPhut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGio);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStart);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(566, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPhut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbGiay;
        private System.Windows.Forms.Label lbMiliGiay;
        private System.Windows.Forms.Timer timer1;
    }
}
