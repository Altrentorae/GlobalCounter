﻿namespace GlobalCounter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.countLabel = new System.Windows.Forms.Label();
            this.butIncr = new System.Windows.Forms.Button();
            this.butDecr = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOverrideKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(12, 21);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(109, 108);
            this.countLabel.TabIndex = 0;
            this.countLabel.Text = "{}";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butIncr
            // 
            this.butIncr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIncr.Location = new System.Drawing.Point(221, 21);
            this.butIncr.Name = "butIncr";
            this.butIncr.Size = new System.Drawing.Size(47, 37);
            this.butIncr.TabIndex = 2;
            this.butIncr.Text = "+";
            this.butIncr.UseVisualStyleBackColor = true;
            this.butIncr.Click += new System.EventHandler(this.butIncr_Click);
            // 
            // butDecr
            // 
            this.butDecr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDecr.Location = new System.Drawing.Point(221, 64);
            this.butDecr.Name = "butDecr";
            this.butDecr.Size = new System.Drawing.Size(47, 37);
            this.butDecr.TabIndex = 3;
            this.butDecr.Text = "-";
            this.butDecr.UseVisualStyleBackColor = true;
            this.butDecr.Click += new System.EventHandler(this.butDecr_Click);
            // 
            // butReset
            // 
            this.butReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReset.Location = new System.Drawing.Point(221, 107);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(47, 37);
            this.butReset.TabIndex = 4;
            this.butReset.Text = "X";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Text = "notifyIconMain";
            this.notifyIconMain.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 158);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblOverrideKey
            // 
            this.lblOverrideKey.AutoSize = true;
            this.lblOverrideKey.Location = new System.Drawing.Point(159, 161);
            this.lblOverrideKey.Name = "lblOverrideKey";
            this.lblOverrideKey.Size = new System.Drawing.Size(25, 13);
            this.lblOverrideKey.TabIndex = 6;
            this.lblOverrideKey.Text = "Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 190);
            this.Controls.Add(this.lblOverrideKey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butDecr);
            this.Controls.Add(this.butIncr);
            this.Controls.Add(this.countLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Global Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button butIncr;
        private System.Windows.Forms.Button butDecr;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblOverrideKey;
    }
}

