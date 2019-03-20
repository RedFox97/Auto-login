namespace Auto_Login_WF_app
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
            this.components = new System.ComponentModel.Container();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.save = new System.Windows.Forms.Button();
            this.ketNoi = new System.Windows.Forms.Button();
            this.COMList = new System.Windows.Forms.ComboBox();
            this.psk = new System.Windows.Forms.TextBox();
            this.matKhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // COM
            // 
            this.COM.PortName = "COM";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(239, 37);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(124, 35);
            this.save.TabIndex = 1;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ketNoi
            // 
            this.ketNoi.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketNoi.Location = new System.Drawing.Point(239, 109);
            this.ketNoi.Name = "ketNoi";
            this.ketNoi.Size = new System.Drawing.Size(124, 35);
            this.ketNoi.TabIndex = 1;
            this.ketNoi.Text = "Kết nối";
            this.ketNoi.UseVisualStyleBackColor = true;
            this.ketNoi.Click += new System.EventHandler(this.ketNoi_Click);
            // 
            // COMList
            // 
            this.COMList.Font = new System.Drawing.Font("Arial", 11F);
            this.COMList.FormattingEnabled = true;
            this.COMList.Location = new System.Drawing.Point(12, 114);
            this.COMList.Name = "COMList";
            this.COMList.Size = new System.Drawing.Size(195, 25);
            this.COMList.TabIndex = 2;
            this.COMList.SelectedIndexChanged += new System.EventHandler(this.COMList_SelectedIndexChanged);
            // 
            // psk
            // 
            this.psk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.psk.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psk.Location = new System.Drawing.Point(13, 44);
            this.psk.Name = "psk";
            this.psk.ReadOnly = true;
            this.psk.Size = new System.Drawing.Size(194, 24);
            this.psk.TabIndex = 4;
            // 
            // matKhau
            // 
            this.matKhau.AutoSize = true;
            this.matKhau.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matKhau.Location = new System.Drawing.Point(13, 13);
            this.matKhau.Name = "matKhau";
            this.matKhau.Size = new System.Drawing.Size(66, 17);
            this.matKhau.TabIndex = 5;
            this.matKhau.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "COM Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(380, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matKhau);
            this.Controls.Add(this.psk);
            this.Controls.Add(this.COMList);
            this.Controls.Add(this.save);
            this.Controls.Add(this.ketNoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Auto Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button ketNoi;
        private System.Windows.Forms.ComboBox COMList;
        private System.Windows.Forms.TextBox psk;
        private System.Windows.Forms.Label matKhau;
        private System.Windows.Forms.Label label1;
    }
}

