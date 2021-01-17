﻿namespace TimeCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inputMinutes = new System.Windows.Forms.ComboBox();
            this.inputSeconds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(231, 214);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(131, 64);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(84, 214);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(131, 64);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(80, 41);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 25);
            this.label.TabIndex = 4;
            this.label.Text = "Minutes:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputMinutes
            // 
            this.inputMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputMinutes.FormattingEnabled = true;
            this.inputMinutes.Location = new System.Drawing.Point(84, 73);
            this.inputMinutes.Name = "inputMinutes";
            this.inputMinutes.Size = new System.Drawing.Size(121, 33);
            this.inputMinutes.TabIndex = 5;
            // 
            // inputSeconds
            // 
            this.inputSeconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSeconds.FormattingEnabled = true;
            this.inputSeconds.Location = new System.Drawing.Point(231, 73);
            this.inputSeconds.Name = "inputSeconds";
            this.inputSeconds.Size = new System.Drawing.Size(121, 33);
            this.inputSeconds.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seconds:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold);
            this.labelOutput.Location = new System.Drawing.Point(24, 41);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(503, 189);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "00:00";
            this.labelOutput.Visible = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(170, 309);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(169, 29);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "Always On Top";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(452, 380);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSeconds);
            this.Controls.Add(this.inputMinutes);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 427);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 427);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox inputMinutes;
        private System.Windows.Forms.ComboBox inputSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

