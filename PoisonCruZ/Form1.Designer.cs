﻿namespace PoisonCruZ
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tir = new System.Windows.Forms.TextBox();
            this.tiv = new System.Windows.Forms.TextBox();
            this.tti = new System.Windows.Forms.TextBox();
            this.tmr = new System.Windows.Forms.TextBox();
            this.tmv = new System.Windows.Forms.TextBox();
            this.ttmac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Envenenar ARP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adaptador RED:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Router:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP Victima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tu IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "MAC Router:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "MAC Victima:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tu MAC:";
            // 
            // tir
            // 
            this.tir.Location = new System.Drawing.Point(85, 58);
            this.tir.MaxLength = 15;
            this.tir.Name = "tir";
            this.tir.Size = new System.Drawing.Size(136, 21);
            this.tir.TabIndex = 9;
            this.tir.Text = "192.168.1.1";
            this.tir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tir_KeyPress);
            // 
            // tiv
            // 
            this.tiv.Location = new System.Drawing.Point(85, 89);
            this.tiv.MaxLength = 15;
            this.tiv.Name = "tiv";
            this.tiv.Size = new System.Drawing.Size(136, 21);
            this.tiv.TabIndex = 10;
            this.tiv.Text = "192.168.1.100";
            this.tiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tiv_KeyPress);
            // 
            // tti
            // 
            this.tti.Location = new System.Drawing.Point(85, 122);
            this.tti.MaxLength = 15;
            this.tti.Name = "tti";
            this.tti.Size = new System.Drawing.Size(136, 21);
            this.tti.TabIndex = 11;
            this.tti.Text = "192.168.1.200";
            this.tti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tti_KeyPress);
            // 
            // tmr
            // 
            this.tmr.Location = new System.Drawing.Point(348, 58);
            this.tmr.MaxLength = 12;
            this.tmr.Name = "tmr";
            this.tmr.Size = new System.Drawing.Size(136, 21);
            this.tmr.TabIndex = 12;
            this.tmr.Text = "ABCDEF123456";
            this.tmr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tmr_KeyPress);
            // 
            // tmv
            // 
            this.tmv.Location = new System.Drawing.Point(348, 89);
            this.tmv.MaxLength = 12;
            this.tmv.Name = "tmv";
            this.tmv.Size = new System.Drawing.Size(136, 21);
            this.tmv.TabIndex = 13;
            this.tmv.Text = "ABCDEF123456";
            this.tmv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tmv_KeyPress);
            // 
            // ttmac
            // 
            this.ttmac.Location = new System.Drawing.Point(348, 122);
            this.ttmac.MaxLength = 12;
            this.ttmac.Name = "ttmac";
            this.ttmac.Size = new System.Drawing.Size(136, 21);
            this.ttmac.TabIndex = 14;
            this.ttmac.Text = "ABCDEF123456";
            this.ttmac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttmac_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "Status:  Esperando...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 154);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 21);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "1000";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Entre cada paquete ms:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Enrutamiento: OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 19);
            this.button3.TabIndex = 19;
            this.button3.Text = "..";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 195);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ttmac);
            this.Controls.Add(this.tmv);
            this.Controls.Add(this.tmr);
            this.Controls.Add(this.tti);
            this.Controls.Add(this.tiv);
            this.Controls.Add(this.tir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poison CruZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tir;
        private System.Windows.Forms.TextBox tiv;
        private System.Windows.Forms.TextBox tti;
        private System.Windows.Forms.TextBox tmr;
        private System.Windows.Forms.TextBox tmv;
        private System.Windows.Forms.TextBox ttmac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}

