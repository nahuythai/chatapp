﻿namespace SERVER
{
    partial class Server
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
            this.start_btn = new System.Windows.Forms.Button();
            this.power_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(40, 217);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(310, 89);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // power_lb
            // 
            this.power_lb.AutoSize = true;
            this.power_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power_lb.ForeColor = System.Drawing.Color.Crimson;
            this.power_lb.Location = new System.Drawing.Point(145, 156);
            this.power_lb.Name = "power_lb";
            this.power_lb.Size = new System.Drawing.Size(85, 39);
            this.power_lb.TabIndex = 2;
            this.power_lb.Text = "OFF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHAT SERVER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SERVER.Properties.Resources.Untitled_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 94);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.power_lb);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Server";
            this.ShowIcon = false;
            this.Text = "SERVER";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label power_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

