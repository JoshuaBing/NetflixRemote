namespace NetflixServer
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
            this.disable = new System.Windows.Forms.Button();
            this.Enable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disable
            // 
            this.disable.Location = new System.Drawing.Point(64, 12);
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(114, 23);
            this.disable.TabIndex = 0;
            this.disable.Text = "Disable Screensaver";
            this.disable.UseVisualStyleBackColor = true;
            this.disable.Click += new System.EventHandler(this.disable_Click);
            // 
            // Enable
            // 
            this.Enable.Location = new System.Drawing.Point(64, 101);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(114, 23);
            this.Enable.TabIndex = 1;
            this.Enable.Text = "Enable Screensaver";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Enable);
            this.Controls.Add(this.disable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button disable;
        private System.Windows.Forms.Button Enable;
    }
}

