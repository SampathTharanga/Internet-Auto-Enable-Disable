namespace InternetAutoOnOff
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpEnable = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpDisable = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAutoDisable = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.lblInternet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblInternet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 188);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(136, 147);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaGreen;
            this.tabPage1.Controls.Add(this.dtpEnable);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSet);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(128, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect";
            // 
            // dtpEnable
            // 
            this.dtpEnable.CustomFormat = "hh:mm";
            this.dtpEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnable.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnable.Location = new System.Drawing.Point(47, 16);
            this.dtpEnable.Name = "dtpEnable";
            this.dtpEnable.ShowUpDown = true;
            this.dtpEnable.Size = new System.Drawing.Size(74, 26);
            this.dtpEnable.TabIndex = 13;
            this.dtpEnable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpEnable_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(16, 63);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(96, 38);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Brown;
            this.tabPage2.Controls.Add(this.dtpDisable);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnAutoDisable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(128, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Disconnect";
            // 
            // dtpDisable
            // 
            this.dtpDisable.CustomFormat = "hh:mm";
            this.dtpDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDisable.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDisable.Location = new System.Drawing.Point(47, 16);
            this.dtpDisable.Name = "dtpDisable";
            this.dtpDisable.ShowUpDown = true;
            this.dtpDisable.Size = new System.Drawing.Size(74, 26);
            this.dtpDisable.TabIndex = 14;
            this.dtpDisable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDisable_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Time";
            // 
            // btnAutoDisable
            // 
            this.btnAutoDisable.BackColor = System.Drawing.Color.Red;
            this.btnAutoDisable.ForeColor = System.Drawing.Color.White;
            this.btnAutoDisable.Location = new System.Drawing.Point(16, 63);
            this.btnAutoDisable.Name = "btnAutoDisable";
            this.btnAutoDisable.Size = new System.Drawing.Size(96, 38);
            this.btnAutoDisable.TabIndex = 11;
            this.btnAutoDisable.Text = "SET";
            this.btnAutoDisable.UseVisualStyleBackColor = false;
            this.btnAutoDisable.Click += new System.EventHandler(this.btnAutoDisable_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(374, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Version 1.0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(211, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "-   2018";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Developed by Sampath Tharanga";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDisable);
            this.groupBox1.Controls.Add(this.btnEnable);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(178, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INTERNET CONNECTION";
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.DarkRed;
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(124, 18);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(116, 39);
            this.btnDisable.TabIndex = 8;
            this.btnDisable.Text = "Disconnect";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(4, 16);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(116, 39);
            this.btnEnable.TabIndex = 7;
            this.btnEnable.Text = "Connect";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternet.Location = new System.Drawing.Point(217, 28);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(0, 25);
            this.lblInternet.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(460, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(476, 498);
            this.MinimumSize = new System.Drawing.Size(476, 498);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Auto ON/OFF - Developed by Sampath Tharanga";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAutoDisable;
        private System.Windows.Forms.DateTimePicker dtpEnable;
        private System.Windows.Forms.DateTimePicker dtpDisable;
        private System.Windows.Forms.Timer timer1;
    }
}

