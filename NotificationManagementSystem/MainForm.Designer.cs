namespace NotificationManagementSystem
{
    partial class MainForm
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
            this.manageSubButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageSubButton
            // 
            this.manageSubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSubButton.Location = new System.Drawing.Point(91, 52);
            this.manageSubButton.Name = "manageSubButton";
            this.manageSubButton.Size = new System.Drawing.Size(139, 54);
            this.manageSubButton.TabIndex = 0;
            this.manageSubButton.Text = "Manage Subscription";
            this.manageSubButton.UseVisualStyleBackColor = true;
            this.manageSubButton.Click += new System.EventHandler(this.manageSubButton_Click);
            // 
            // publishButton
            // 
            this.publishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishButton.Location = new System.Drawing.Point(426, 52);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(139, 54);
            this.publishButton.TabIndex = 1;
            this.publishButton.Text = "Publish Notification";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(725, 52);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 54);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 197);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.manageSubButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageSubButton;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button exitButton;
    }
}

