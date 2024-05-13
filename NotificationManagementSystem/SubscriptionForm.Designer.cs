namespace NotificationManagementSystem
{
    partial class SubscriptionForm
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
            this.emailCheckbox = new System.Windows.Forms.CheckBox();
            this.smsCheckbox = new System.Windows.Forms.CheckBox();
            this.subscribeBtn = new System.Windows.Forms.Button();
            this.unsubscribeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.mobileTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailCheckbox
            // 
            this.emailCheckbox.AutoSize = true;
            this.emailCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCheckbox.Location = new System.Drawing.Point(179, 78);
            this.emailCheckbox.Name = "emailCheckbox";
            this.emailCheckbox.Size = new System.Drawing.Size(67, 24);
            this.emailCheckbox.TabIndex = 0;
            this.emailCheckbox.Text = "Email";
            this.emailCheckbox.UseVisualStyleBackColor = true;
            this.emailCheckbox.CheckedChanged += new System.EventHandler(this.emailCheckbox_CheckedChanged);
            // 
            // smsCheckbox
            // 
            this.smsCheckbox.AutoSize = true;
            this.smsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsCheckbox.Location = new System.Drawing.Point(179, 123);
            this.smsCheckbox.Name = "smsCheckbox";
            this.smsCheckbox.Size = new System.Drawing.Size(74, 24);
            this.smsCheckbox.TabIndex = 1;
            this.smsCheckbox.Text = "Phone";
            this.smsCheckbox.UseVisualStyleBackColor = true;
            this.smsCheckbox.CheckedChanged += new System.EventHandler(this.smsCheckbox_CheckedChanged);
            // 
            // subscribeBtn
            // 
            this.subscribeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscribeBtn.Location = new System.Drawing.Point(102, 218);
            this.subscribeBtn.Name = "subscribeBtn";
            this.subscribeBtn.Size = new System.Drawing.Size(112, 46);
            this.subscribeBtn.TabIndex = 2;
            this.subscribeBtn.Text = "Subscribe";
            this.subscribeBtn.UseVisualStyleBackColor = true;
            this.subscribeBtn.Click += new System.EventHandler(this.subscribeBtn_Click);
            // 
            // unsubscribeBtn
            // 
            this.unsubscribeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsubscribeBtn.Location = new System.Drawing.Point(356, 217);
            this.unsubscribeBtn.Name = "unsubscribeBtn";
            this.unsubscribeBtn.Size = new System.Drawing.Size(112, 46);
            this.unsubscribeBtn.TabIndex = 3;
            this.unsubscribeBtn.Text = "Unsubscribe";
            this.unsubscribeBtn.UseVisualStyleBackColor = true;
            this.unsubscribeBtn.Click += new System.EventHandler(this.unsubscribeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(583, 218);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 46);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(287, 78);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(239, 20);
            this.emailTxtBox.TabIndex = 5;
            // 
            // mobileTxtBox
            // 
            this.mobileTxtBox.Location = new System.Drawing.Point(287, 123);
            this.mobileTxtBox.Name = "mobileTxtBox";
            this.mobileTxtBox.Size = new System.Drawing.Size(239, 20);
            this.mobileTxtBox.TabIndex = 6;
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.mobileTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.unsubscribeBtn);
            this.Controls.Add(this.subscribeBtn);
            this.Controls.Add(this.smsCheckbox);
            this.Controls.Add(this.emailCheckbox);
            this.Name = "SubscriptionForm";
            this.Text = "SubscriptionForm";
            this.Load += new System.EventHandler(this.SubscriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emailCheckbox;
        private System.Windows.Forms.CheckBox smsCheckbox;
        private System.Windows.Forms.Button subscribeBtn;
        private System.Windows.Forms.Button unsubscribeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox mobileTxtBox;
    }
}