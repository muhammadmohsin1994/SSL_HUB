﻿namespace SSL_HUB.Central
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
            this.Stop = new System.Windows.Forms.Button();
            this.TrackBall = new System.Windows.Forms.Button();
            this.Move = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.IsYellow = new System.Windows.Forms.CheckBox();
            this.Kick = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenSerial = new System.Windows.Forms.Button();
            this.CloseSerial = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.KickSpeedX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Spinner = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.KickSpeedZ = new System.Windows.Forms.TextBox();
            this.Serial = new System.Windows.Forms.CheckBox();
            this.Strategy1 = new System.Windows.Forms.Button();
            this.Strategy2 = new System.Windows.Forms.Button();
            this.StopBallTracking = new System.Windows.Forms.Button();
            this.COMPort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(279, 37);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 17;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // TrackBall
            // 
            this.TrackBall.Location = new System.Drawing.Point(279, 64);
            this.TrackBall.Name = "TrackBall";
            this.TrackBall.Size = new System.Drawing.Size(75, 23);
            this.TrackBall.TabIndex = 16;
            this.TrackBall.Text = "Track Ball";
            this.TrackBall.UseVisualStyleBackColor = true;
            this.TrackBall.Click += new System.EventHandler(this.TrackBall_Click);
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(279, 8);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(75, 23);
            this.Move.TabIndex = 15;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(89, 59);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(100, 20);
            this.Angle.TabIndex = 11;
            this.Angle.Text = "0";
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(89, 33);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(100, 20);
            this.Y.TabIndex = 10;
            this.Y.Text = "0";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(89, 7);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 20);
            this.X.TabIndex = 9;
            this.X.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Id";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(89, 85);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 18;
            this.Id.Text = "0";
            // 
            // IsYellow
            // 
            this.IsYellow.AutoSize = true;
            this.IsYellow.Location = new System.Drawing.Point(195, 87);
            this.IsYellow.Name = "IsYellow";
            this.IsYellow.Size = new System.Drawing.Size(68, 17);
            this.IsYellow.TabIndex = 20;
            this.IsYellow.Text = "Is Yellow";
            this.IsYellow.UseVisualStyleBackColor = true;
            // 
            // Kick
            // 
            this.Kick.Location = new System.Drawing.Point(279, 134);
            this.Kick.Name = "Kick";
            this.Kick.Size = new System.Drawing.Size(75, 23);
            this.Kick.TabIndex = 24;
            this.Kick.Text = "Kick";
            this.Kick.UseVisualStyleBackColor = true;
            this.Kick.Click += new System.EventHandler(this.Kick_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "PORT";
            // 
            // OpenSerial
            // 
            this.OpenSerial.Location = new System.Drawing.Point(12, 227);
            this.OpenSerial.Name = "OpenSerial";
            this.OpenSerial.Size = new System.Drawing.Size(112, 23);
            this.OpenSerial.TabIndex = 27;
            this.OpenSerial.Text = "Open Serial";
            this.OpenSerial.UseVisualStyleBackColor = true;
            this.OpenSerial.Click += new System.EventHandler(this.OpenSerial_Click);
            // 
            // CloseSerial
            // 
            this.CloseSerial.Location = new System.Drawing.Point(130, 227);
            this.CloseSerial.Name = "CloseSerial";
            this.CloseSerial.Size = new System.Drawing.Size(109, 23);
            this.CloseSerial.TabIndex = 28;
            this.CloseSerial.Text = "Close Serial";
            this.CloseSerial.UseVisualStyleBackColor = true;
            this.CloseSerial.Click += new System.EventHandler(this.CloseSerial_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "9600";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Baud Rate";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(360, 8);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 242);
            this.textBox3.TabIndex = 31;
            // 
            // KickSpeedX
            // 
            this.KickSpeedX.Location = new System.Drawing.Point(89, 112);
            this.KickSpeedX.Name = "KickSpeedX";
            this.KickSpeedX.Size = new System.Drawing.Size(100, 20);
            this.KickSpeedX.TabIndex = 32;
            this.KickSpeedX.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Kick Speed X";
            // 
            // Spinner
            // 
            this.Spinner.AutoSize = true;
            this.Spinner.Checked = true;
            this.Spinner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Spinner.Location = new System.Drawing.Point(195, 114);
            this.Spinner.Name = "Spinner";
            this.Spinner.Size = new System.Drawing.Size(62, 17);
            this.Spinner.TabIndex = 34;
            this.Spinner.Text = "Spinner";
            this.Spinner.UseVisualStyleBackColor = true;
            this.Spinner.CheckedChanged += new System.EventHandler(this.Spinner_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Kick Speed Z";
            // 
            // KickSpeedZ
            // 
            this.KickSpeedZ.Location = new System.Drawing.Point(89, 138);
            this.KickSpeedZ.Name = "KickSpeedZ";
            this.KickSpeedZ.Size = new System.Drawing.Size(100, 20);
            this.KickSpeedZ.TabIndex = 36;
            this.KickSpeedZ.Text = "0";
            // 
            // Serial
            // 
            this.Serial.AutoSize = true;
            this.Serial.Location = new System.Drawing.Point(195, 177);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(52, 17);
            this.Serial.TabIndex = 37;
            this.Serial.Text = "Serial";
            this.Serial.UseVisualStyleBackColor = true;
            // 
            // Strategy1
            // 
            this.Strategy1.Location = new System.Drawing.Point(585, 8);
            this.Strategy1.Name = "Strategy1";
            this.Strategy1.Size = new System.Drawing.Size(75, 23);
            this.Strategy1.TabIndex = 38;
            this.Strategy1.Text = "Strategy 1";
            this.Strategy1.UseVisualStyleBackColor = true;
            this.Strategy1.Click += new System.EventHandler(this.Strategy1_Click);
            // 
            // Strategy2
            // 
            this.Strategy2.Location = new System.Drawing.Point(585, 37);
            this.Strategy2.Name = "Strategy2";
            this.Strategy2.Size = new System.Drawing.Size(75, 23);
            this.Strategy2.TabIndex = 39;
            this.Strategy2.Text = "Strategy 2";
            this.Strategy2.UseVisualStyleBackColor = true;
            this.Strategy2.Click += new System.EventHandler(this.Strategy2_Click);
            // 
            // StopBallTracking
            // 
            this.StopBallTracking.Location = new System.Drawing.Point(279, 93);
            this.StopBallTracking.Name = "StopBallTracking";
            this.StopBallTracking.Size = new System.Drawing.Size(75, 35);
            this.StopBallTracking.TabIndex = 23;
            this.StopBallTracking.Text = "Stop Ball Tracking";
            this.StopBallTracking.UseVisualStyleBackColor = true;
            this.StopBallTracking.Click += new System.EventHandler(this.StopBallTracking_Click);
            // 
            // COMPort
            // 
            this.COMPort.FormattingEnabled = true;
            this.COMPort.Location = new System.Drawing.Point(89, 173);
            this.COMPort.Name = "COMPort";
            this.COMPort.Size = new System.Drawing.Size(100, 21);
            this.COMPort.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 293);
            this.Controls.Add(this.COMPort);
            this.Controls.Add(this.Strategy2);
            this.Controls.Add(this.Strategy1);
            this.Controls.Add(this.Serial);
            this.Controls.Add(this.KickSpeedZ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Spinner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KickSpeedX);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CloseSerial);
            this.Controls.Add(this.OpenSerial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Kick);
            this.Controls.Add(this.StopBallTracking);
            this.Controls.Add(this.IsYellow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.TrackBall);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button TrackBall;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.CheckBox IsYellow;
        private System.Windows.Forms.Button Kick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OpenSerial;
        private System.Windows.Forms.Button CloseSerial;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox KickSpeedX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Spinner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox KickSpeedZ;
        private System.Windows.Forms.CheckBox Serial;
        private System.Windows.Forms.Button Strategy1;
        private System.Windows.Forms.Button Strategy2;
        private System.Windows.Forms.Button StopBallTracking;
        private System.Windows.Forms.ComboBox COMPort;

    }
}

