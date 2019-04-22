namespace LibrarianAssistant
{
    partial class AddCardHolder
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
            this.submit = new System.Windows.Forms.Button();
            this.IDText = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(616, 340);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_ClickAsync);
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(106, 96);
            this.IDText.Name = "IDText";
            this.IDText.ReadOnly = true;
            this.IDText.Size = new System.Drawing.Size(100, 22);
            this.IDText.TabIndex = 1;
            this.IDText.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(323, 95);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 2;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(106, 144);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.ReadOnly = true;
            this.FirstNameText.Size = new System.Drawing.Size(100, 22);
            this.FirstNameText.TabIndex = 3;
            this.FirstNameText.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(323, 143);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 22);
            this.FirstName.TabIndex = 4;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(106, 203);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.ReadOnly = true;
            this.LastNameText.Size = new System.Drawing.Size(100, 22);
            this.LastNameText.TabIndex = 5;
            this.LastNameText.Text = "Last Name";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(323, 202);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 22);
            this.LastName.TabIndex = 6;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(106, 257);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.ReadOnly = true;
            this.PasswordText.Size = new System.Drawing.Size(100, 22);
            this.PasswordText.TabIndex = 7;
            this.PasswordText.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(323, 256);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 8;
            // 
            // AddCardHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.submit);
            this.Name = "AddCardHolder";
            this.Text = "AddCardHolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox Password;
    }
}