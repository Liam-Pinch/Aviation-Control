namespace Aviation_Control
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbConnection = new GroupBox();
            lblPort = new Label();
            lblIPAdress = new Label();
            tbPort = new TextBox();
            tbIPAddress = new TextBox();
            btnClose = new Button();
            btnDisconnect = new Button();
            btnConnent = new Button();
            gbControlBox = new GroupBox();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            gbTeleData = new GroupBox();
            textBox8 = new TextBox();
            lbl_WarningCode = new Label();
            textBox7 = new TextBox();
            lbl_elevationPitch = new Label();
            lbl_throttle = new Label();
            lbl_virtSpeed = new Label();
            lbl_pitch = new Label();
            lbl_speed = new Label();
            lbl_altitude = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            gbTeleHistory = new GroupBox();
            dataGridView1 = new DataGridView();
            Altitude = new DataGridViewTextBoxColumn();
            Speed = new DataGridViewTextBoxColumn();
            Pitch = new DataGridViewTextBoxColumn();
            VirticalSpeed = new DataGridViewTextBoxColumn();
            Throttle = new DataGridViewTextBoxColumn();
            ElevatorPitch = new DataGridViewTextBoxColumn();
            WarningCode = new DataGridViewTextBoxColumn();
            gbConnection.SuspendLayout();
            gbControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            gbTeleData.SuspendLayout();
            gbTeleHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbConnection
            // 
            gbConnection.Controls.Add(lblPort);
            gbConnection.Controls.Add(lblIPAdress);
            gbConnection.Controls.Add(tbPort);
            gbConnection.Controls.Add(tbIPAddress);
            gbConnection.Controls.Add(btnClose);
            gbConnection.Controls.Add(btnDisconnect);
            gbConnection.Controls.Add(btnConnent);
            gbConnection.Location = new Point(12, 12);
            gbConnection.Name = "gbConnection";
            gbConnection.Size = new Size(521, 208);
            gbConnection.TabIndex = 0;
            gbConnection.TabStop = false;
            gbConnection.Text = "Connection";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(28, 78);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 20);
            lblPort.TabIndex = 6;
            lblPort.Text = "Port";
            // 
            // lblIPAdress
            // 
            lblIPAdress.AutoSize = true;
            lblIPAdress.Location = new Point(28, 39);
            lblIPAdress.Name = "lblIPAdress";
            lblIPAdress.Size = new Size(130, 20);
            lblIPAdress.TabIndex = 5;
            lblIPAdress.Tag = "";
            lblIPAdress.Text = "Current IP Address";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(164, 71);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(189, 27);
            tbPort.TabIndex = 4;
            // 
            // tbIPAddress
            // 
            tbIPAddress.Location = new Point(164, 36);
            tbIPAddress.Name = "tbIPAddress";
            tbIPAddress.Size = new Size(189, 27);
            tbIPAddress.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(373, 104);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(373, 69);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(94, 29);
            btnDisconnect.TabIndex = 1;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnConnent
            // 
            btnConnent.Location = new Point(373, 34);
            btnConnent.Name = "btnConnent";
            btnConnent.Size = new Size(94, 29);
            btnConnent.TabIndex = 0;
            btnConnent.Text = "Connect";
            btnConnent.UseVisualStyleBackColor = true;
            // 
            // gbControlBox
            // 
            gbControlBox.Controls.Add(trackBar2);
            gbControlBox.Controls.Add(trackBar1);
            gbControlBox.Location = new Point(17, 240);
            gbControlBox.Name = "gbControlBox";
            gbControlBox.Size = new Size(516, 437);
            gbControlBox.TabIndex = 1;
            gbControlBox.TabStop = false;
            gbControlBox.Text = "Control Menu";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(261, 87);
            trackBar2.Name = "trackBar2";
            trackBar2.Orientation = Orientation.Vertical;
            trackBar2.Size = new Size(56, 309);
            trackBar2.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(134, 87);
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(56, 309);
            trackBar1.TabIndex = 0;
            // 
            // gbTeleData
            // 
            gbTeleData.Controls.Add(textBox8);
            gbTeleData.Controls.Add(lbl_WarningCode);
            gbTeleData.Controls.Add(textBox7);
            gbTeleData.Controls.Add(lbl_elevationPitch);
            gbTeleData.Controls.Add(lbl_throttle);
            gbTeleData.Controls.Add(lbl_virtSpeed);
            gbTeleData.Controls.Add(lbl_pitch);
            gbTeleData.Controls.Add(lbl_speed);
            gbTeleData.Controls.Add(lbl_altitude);
            gbTeleData.Controls.Add(textBox6);
            gbTeleData.Controls.Add(textBox5);
            gbTeleData.Controls.Add(textBox4);
            gbTeleData.Controls.Add(textBox3);
            gbTeleData.Controls.Add(textBox2);
            gbTeleData.Controls.Add(textBox1);
            gbTeleData.Location = new Point(539, 12);
            gbTeleData.Name = "gbTeleData";
            gbTeleData.Size = new Size(820, 374);
            gbTeleData.TabIndex = 2;
            gbTeleData.TabStop = false;
            gbTeleData.Text = "Current Data";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(206, 320);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 14;
            // 
            // lbl_WarningCode
            // 
            lbl_WarningCode.AutoSize = true;
            lbl_WarningCode.Location = new Point(94, 327);
            lbl_WarningCode.Name = "lbl_WarningCode";
            lbl_WarningCode.Size = new Size(113, 20);
            lbl_WarningCode.TabIndex = 13;
            lbl_WarningCode.Text = "Warning Code -";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(363, 55);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(230, 250);
            textBox7.TabIndex = 12;
            // 
            // lbl_elevationPitch
            // 
            lbl_elevationPitch.AutoSize = true;
            lbl_elevationPitch.Location = new Point(94, 285);
            lbl_elevationPitch.Name = "lbl_elevationPitch";
            lbl_elevationPitch.Size = new Size(109, 20);
            lbl_elevationPitch.TabIndex = 11;
            lbl_elevationPitch.Text = "Elevator Pitch -";
            // 
            // lbl_throttle
            // 
            lbl_throttle.AutoSize = true;
            lbl_throttle.Location = new Point(94, 238);
            lbl_throttle.Name = "lbl_throttle";
            lbl_throttle.Size = new Size(71, 20);
            lbl_throttle.TabIndex = 10;
            lbl_throttle.Text = "Throttle -";
            // 
            // lbl_virtSpeed
            // 
            lbl_virtSpeed.AutoSize = true;
            lbl_virtSpeed.Location = new Point(94, 194);
            lbl_virtSpeed.Name = "lbl_virtSpeed";
            lbl_virtSpeed.Size = new Size(111, 20);
            lbl_virtSpeed.TabIndex = 9;
            lbl_virtSpeed.Text = "Virtical Speed -";
            // 
            // lbl_pitch
            // 
            lbl_pitch.AutoSize = true;
            lbl_pitch.Location = new Point(94, 149);
            lbl_pitch.Name = "lbl_pitch";
            lbl_pitch.Size = new Size(51, 20);
            lbl_pitch.TabIndex = 8;
            lbl_pitch.Text = "Pitch -";
            // 
            // lbl_speed
            // 
            lbl_speed.AutoSize = true;
            lbl_speed.Location = new Point(94, 107);
            lbl_speed.Name = "lbl_speed";
            lbl_speed.Size = new Size(61, 20);
            lbl_speed.TabIndex = 7;
            lbl_speed.Text = "Speed -";
            // 
            // lbl_altitude
            // 
            lbl_altitude.AutoSize = true;
            lbl_altitude.Location = new Point(94, 64);
            lbl_altitude.Name = "lbl_altitude";
            lbl_altitude.Size = new Size(72, 20);
            lbl_altitude.TabIndex = 6;
            lbl_altitude.Text = "Altitude -";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(206, 278);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(206, 231);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(206, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(206, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // gbTeleHistory
            // 
            gbTeleHistory.Controls.Add(dataGridView1);
            gbTeleHistory.Location = new Point(540, 392);
            gbTeleHistory.Name = "gbTeleHistory";
            gbTeleHistory.Size = new Size(950, 285);
            gbTeleHistory.TabIndex = 3;
            gbTeleHistory.TabStop = false;
            gbTeleHistory.Text = "Telementry Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Altitude, Speed, Pitch, VirticalSpeed, Throttle, ElevatorPitch, WarningCode });
            dataGridView1.Location = new Point(6, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(949, 213);
            dataGridView1.TabIndex = 0;
            // 
            // Altitude
            // 
            Altitude.HeaderText = "Altitude";
            Altitude.MinimumWidth = 6;
            Altitude.Name = "Altitude";
            Altitude.Width = 125;
            // 
            // Speed
            // 
            Speed.HeaderText = "Speed";
            Speed.MinimumWidth = 6;
            Speed.Name = "Speed";
            Speed.Width = 125;
            // 
            // Pitch
            // 
            Pitch.HeaderText = "Pitch";
            Pitch.MinimumWidth = 6;
            Pitch.Name = "Pitch";
            Pitch.Width = 125;
            // 
            // VirticalSpeed
            // 
            VirticalSpeed.HeaderText = "Virtical Speed";
            VirticalSpeed.MinimumWidth = 6;
            VirticalSpeed.Name = "VirticalSpeed";
            VirticalSpeed.Width = 125;
            // 
            // Throttle
            // 
            Throttle.HeaderText = "Throttle";
            Throttle.MinimumWidth = 6;
            Throttle.Name = "Throttle";
            Throttle.Width = 125;
            // 
            // ElevatorPitch
            // 
            ElevatorPitch.HeaderText = "Elevator Pitch";
            ElevatorPitch.MinimumWidth = 6;
            ElevatorPitch.Name = "ElevatorPitch";
            ElevatorPitch.Width = 125;
            // 
            // WarningCode
            // 
            WarningCode.HeaderText = "Warning Code";
            WarningCode.MinimumWidth = 6;
            WarningCode.Name = "WarningCode";
            WarningCode.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 698);
            Controls.Add(gbTeleHistory);
            Controls.Add(gbTeleData);
            Controls.Add(gbControlBox);
            Controls.Add(gbConnection);
            Name = "Form1";
            Text = "Form1";
            gbConnection.ResumeLayout(false);
            gbConnection.PerformLayout();
            gbControlBox.ResumeLayout(false);
            gbControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            gbTeleData.ResumeLayout(false);
            gbTeleData.PerformLayout();
            gbTeleHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbConnection;
        private GroupBox gbControlBox;
        private GroupBox gbTeleData;
        private GroupBox gbTeleHistory;
        private Button btnClose;
        private Button btnDisconnect;
        private Button btnConnent;
        private Label lblIPAdress;
        private TextBox tbPort;
        private TextBox tbIPAddress;
        private Label lblPort;
        private TextBox textBox7;
        private Label lbl_elevationPitch;
        private Label lbl_throttle;
        private Label lbl_virtSpeed;
        private Label lbl_pitch;
        private Label lbl_speed;
        private Label lbl_altitude;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private TextBox textBox8;
        private Label lbl_WarningCode;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Altitude;
        private DataGridViewTextBoxColumn Speed;
        private DataGridViewTextBoxColumn Pitch;
        private DataGridViewTextBoxColumn VirticalSpeed;
        private DataGridViewTextBoxColumn Throttle;
        private DataGridViewTextBoxColumn ElevatorPitch;
        private DataGridViewTextBoxColumn WarningCode;
    }
}