namespace Reg.GUI
{
    partial class StartForm
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
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationBtn.Location = new System.Drawing.Point(329, 124);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(161, 64);
            this.RegistrationBtn.TabIndex = 0;
            this.RegistrationBtn.Text = "Регистрация";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInBtn.Location = new System.Drawing.Point(49, 124);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(161, 64);
            this.SignInBtn.TabIndex = 1;
            this.SignInBtn.Text = "Войти";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 310);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.RegistrationBtn);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegistrationBtn;
        private System.Windows.Forms.Button SignInBtn;
    }
}