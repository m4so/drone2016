namespace Hobbyking_4CH_WiFi
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel_JoyStick = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_JoyStick2 = new System.Windows.Forms.Panel();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(317, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 28);
            this.btnConnect.TabIndex = 46;
            this.btnConnect.Text = "Open";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.panel_JoyStick);
            this.panel3.Controls.Add(this.trackBar2);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 330);
            this.panel3.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(142, 375);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "YAW";
            // 
            // panel_JoyStick
            // 
            this.panel_JoyStick.BackColor = System.Drawing.Color.Black;
            this.panel_JoyStick.ForeColor = System.Drawing.Color.White;
            this.panel_JoyStick.Location = new System.Drawing.Point(72, 53);
            this.panel_JoyStick.Name = "panel_JoyStick";
            this.panel_JoyStick.Size = new System.Drawing.Size(200, 200);
            this.panel_JoyStick.TabIndex = 11;
            this.panel_JoyStick.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_JoyStick_Paint);
            this.panel_JoyStick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_JoyStick_MouseDown);
            this.panel_JoyStick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_JoyStick_MouseMove);
            this.panel_JoyStick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_JoyStick_MouseUp);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(21, 49);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = -100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 204);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.TickFrequency = 10;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(61, 259);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(223, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_JoyStick2);
            this.panel1.Controls.Add(this.trackBar4);
            this.panel1.Controls.Add(this.trackBar3);
            this.panel1.Location = new System.Drawing.Point(402, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 330);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "YAW";
            // 
            // panel_JoyStick2
            // 
            this.panel_JoyStick2.BackColor = System.Drawing.Color.Black;
            this.panel_JoyStick2.ForeColor = System.Drawing.Color.White;
            this.panel_JoyStick2.Location = new System.Drawing.Point(72, 53);
            this.panel_JoyStick2.Name = "panel_JoyStick2";
            this.panel_JoyStick2.Size = new System.Drawing.Size(200, 200);
            this.panel_JoyStick2.TabIndex = 11;
            this.panel_JoyStick2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_JoyStick2_Paint);
            this.panel_JoyStick2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_JoyStick2_MouseDown);
            this.panel_JoyStick2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_JoyStick2_MouseMove);
            this.panel_JoyStick2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_JoyStick2_MouseUp);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(21, 49);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Minimum = -100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 204);
            this.trackBar4.TabIndex = 1;
            this.trackBar4.TickFrequency = 10;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(61, 259);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = -100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(223, 45);
            this.trackBar3.TabIndex = 0;
            this.trackBar3.TickFrequency = 10;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 50;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Hobbyking 4CH WiFi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel_JoyStick;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_JoyStick2;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Timer timerUpdate;
    }
}

