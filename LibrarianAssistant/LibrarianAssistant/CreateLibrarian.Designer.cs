namespace LibrarianAssistant
{
    partial class CreateLibrarian
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
            this.Back = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.RePasswordText = new System.Windows.Forms.TextBox();
            this.RePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 23);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "button1";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(241, 322);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "button2";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(133, 77);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.ReadOnly = true;
            this.FirstNameText.Size = new System.Drawing.Size(100, 22);
            this.FirstNameText.TabIndex = 2;
            this.FirstNameText.TextChanged += new System.EventHandler(this.FirstNameText_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(330, 77);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 22);
            this.FirstName.TabIndex = 3;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(133, 120);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.ReadOnly = true;
            this.LastNameText.Size = new System.Drawing.Size(100, 22);
            this.LastNameText.TabIndex = 4;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(330, 120);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 22);
            this.LastName.TabIndex = 5;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(133, 161);
            this.IDText.Name = "IDText";
            this.IDText.ReadOnly = true;
            this.IDText.Size = new System.Drawing.Size(100, 22);
            this.IDText.TabIndex = 6;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(133, 202);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.ReadOnly = true;
            this.PasswordText.Size = new System.Drawing.Size(100, 22);
            this.PasswordText.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(330, 161);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(330, 202);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 10;
            // 
            // RePasswordText
            // 
            this.RePasswordText.Location = new System.Drawing.Point(133, 244);
            this.RePasswordText.Name = "RePasswordText";
            this.RePasswordText.ReadOnly = true;
            this.RePasswordText.Size = new System.Drawing.Size(100, 22);
            this.RePasswordText.TabIndex = 11;
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(330, 244);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(100, 22);
            this.RePassword.TabIndex = 12;
            // 
            // CreateLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.RePasswordText);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Back);
            this.Name = "CreateLibrarian";
            this.Text = "CreateLibrarian";
            this.Load += new System.EventHandler(this.CreateLibrarian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox RePasswordText;
        private System.Windows.Forms.TextBox RePassword;
    }
}