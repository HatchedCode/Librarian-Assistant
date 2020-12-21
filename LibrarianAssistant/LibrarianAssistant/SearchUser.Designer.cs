namespace LibrarianAssistant
{
    partial class SearchUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.SearchIDText = new System.Windows.Forms.TextBox();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Books = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // SearchIDText
            // 
            this.SearchIDText.Location = new System.Drawing.Point(112, 80);
            this.SearchIDText.Name = "SearchIDText";
            this.SearchIDText.ReadOnly = true;
            this.SearchIDText.Size = new System.Drawing.Size(100, 22);
            this.SearchIDText.TabIndex = 1;
            this.SearchIDText.Text = "Search ID";
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(348, 80);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(193, 22);
            this.SearchID.TabIndex = 2;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(112, 126);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.ReadOnly = true;
            this.FirstNameText.Size = new System.Drawing.Size(100, 22);
            this.FirstNameText.TabIndex = 3;
            this.FirstNameText.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(348, 126);
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Size = new System.Drawing.Size(193, 22);
            this.FirstName.TabIndex = 4;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(112, 169);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.ReadOnly = true;
            this.LastNameText.Size = new System.Drawing.Size(100, 22);
            this.LastNameText.TabIndex = 5;
            this.LastNameText.Text = "LastName ";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(348, 168);
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Size = new System.Drawing.Size(193, 22);
            this.LastName.TabIndex = 6;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(112, 219);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.ReadOnly = true;
            this.PasswordText.Size = new System.Drawing.Size(100, 22);
            this.PasswordText.TabIndex = 7;
            this.PasswordText.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(348, 218);
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Size = new System.Drawing.Size(193, 22);
            this.Password.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Books";
            // 
            // Books
            // 
            this.Books.Location = new System.Drawing.Point(348, 273);
            this.Books.Multiline = true;
            this.Books.Name = "Books";
            this.Books.ReadOnly = true;
            this.Books.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Books.Size = new System.Drawing.Size(193, 74);
            this.Books.TabIndex = 15;
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.SearchID);
            this.Controls.Add(this.SearchIDText);
            this.Controls.Add(this.button1);
            this.Name = "SearchUser";
            this.Text = "SearchUser";
            this.Load += new System.EventHandler(this.SearchUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchIDText;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Books;
    }
}