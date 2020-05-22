namespace motor
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxSpeed = new System.Windows.Forms.CheckBox();
            this.cbxPosition = new System.Windows.Forms.CheckBox();
            this.set = new System.Windows.Forms.TextBox();
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.MaskedTextBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDegree = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbSpeed = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.Kp = new System.Windows.Forms.TextBox();
            this.Ki = new System.Windows.Forms.TextBox();
            this.Kd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(381, 231);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 46);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Clicked);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(253, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 46);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Clicked);
            // 
            // cbxSpeed
            // 
            this.cbxSpeed.AutoSize = true;
            this.cbxSpeed.Location = new System.Drawing.Point(253, 193);
            this.cbxSpeed.Name = "cbxSpeed";
            this.cbxSpeed.Size = new System.Drawing.Size(71, 21);
            this.cbxSpeed.TabIndex = 3;
            this.cbxSpeed.Text = "Speed";
            this.cbxSpeed.UseVisualStyleBackColor = true;
            // 
            // cbxPosition
            // 
            this.cbxPosition.AutoSize = true;
            this.cbxPosition.Location = new System.Drawing.Point(381, 193);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(80, 21);
            this.cbxPosition.TabIndex = 4;
            this.cbxPosition.Text = "Position";
            this.cbxPosition.UseVisualStyleBackColor = true;
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(298, 28);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(100, 22);
            this.set.TabIndex = 5;
            this.set.TextChanged += new System.EventHandler(this.set_TextChanged);
            // 
            // UART
            // 
            this.UART.BaudRate = 115200;
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_DataReceived);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(45, 104);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(146, 46);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(-2, 430);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(143, 22);
            this.Status.TabIndex = 7;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(253, 305);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(98, 38);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Clicked);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(381, 305);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(88, 38);
            this.btnRight.TabIndex = 9;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Clicked);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(416, 5);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(82, 31);
            this.btnIncrease.TabIndex = 10;
            this.btnIncrease.Text = "Increase";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Clicked);
            // 
            // btnDegree
            // 
            this.btnDegree.Location = new System.Drawing.Point(416, 42);
            this.btnDegree.Name = "btnDegree";
            this.btnDegree.Size = new System.Drawing.Size(82, 28);
            this.btnDegree.TabIndex = 11;
            this.btnDegree.Text = "Degree";
            this.btnDegree.UseVisualStyleBackColor = true;
            this.btnDegree.Click += new System.EventHandler(this.btnDegree_Clicked);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 28);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Clicked);
            // 
            // txbSpeed
            // 
            this.txbSpeed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSpeed.Location = new System.Drawing.Point(253, 104);
            this.txbSpeed.Name = "txbSpeed";
            this.txbSpeed.Size = new System.Drawing.Size(234, 20);
            this.txbSpeed.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(545, -2);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(834, 454);
            this.zedGraphControl1.TabIndex = 14;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // Kp
            // 
            this.Kp.Location = new System.Drawing.Point(100, 208);
            this.Kp.Name = "Kp";
            this.Kp.Size = new System.Drawing.Size(100, 22);
            this.Kp.TabIndex = 15;
            this.Kp.Text = "0.1";
            // 
            // Ki
            // 
            this.Ki.Location = new System.Drawing.Point(100, 264);
            this.Ki.Name = "Ki";
            this.Ki.Size = new System.Drawing.Size(100, 22);
            this.Ki.TabIndex = 16;
            this.Ki.Text = "0.02";
            // 
            // Kd
            // 
            this.Kd.Location = new System.Drawing.Point(100, 321);
            this.Kd.Name = "Kd";
            this.Kd.Size = new System.Drawing.Size(100, 22);
            this.Kd.TabIndex = 17;
            this.Kd.Text = "0.03";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kd";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kd);
            this.Controls.Add(this.Ki);
            this.Controls.Add(this.Kp);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.txbSpeed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDegree);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.set);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.cbxSpeed);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
      
      
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbxSpeed;
        private System.Windows.Forms.CheckBox cbxPosition;
        private System.Windows.Forms.TextBox set;
        private System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.MaskedTextBox Status;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDegree;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txbSpeed;
        private System.Windows.Forms.Timer timer1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox Kp;
        private System.Windows.Forms.TextBox Ki;
        private System.Windows.Forms.TextBox Kd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

