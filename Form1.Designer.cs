﻿namespace LyricsLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtOutput2 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtOutput2
            // 
            txtOutput2.BackColor = Color.White;
            txtOutput2.BorderStyle = BorderStyle.None;
            txtOutput2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOutput2.Location = new Point(277, 671);
            txtOutput2.Multiline = true;
            txtOutput2.Name = "txtOutput2";
            txtOutput2.Size = new Size(245, 44);
            txtOutput2.TabIndex = 0;
            txtOutput2.Text = "CANNIBAL CORPSE";
            txtOutput2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, -15);
            label1.Name = "label1";
            label1.Size = new Size(593, 159);
            label1.TabIndex = 1;
            label1.Text = "Lyrics Lab";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(701, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 755);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 674);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(35, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(279, 331);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(774, 97);
            label2.Name = "label2";
            label2.Size = new Size(300, 47);
            label2.TabIndex = 5;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1145, 756);
            Controls.Add(label2);
            Controls.Add(txtOutput2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}