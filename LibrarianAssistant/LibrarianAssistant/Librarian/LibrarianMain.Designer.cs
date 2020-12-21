namespace LibrarianAssistant.Librarian
{
    partial class LibrarianMain
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
            this.SearchBook = new System.Windows.Forms.Button();
            this.addbook = new System.Windows.Forms.Button();
            this.editBookButton = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loggedInUserNameLabel = new System.Windows.Forms.Label();
            this.AddHolder = new System.Windows.Forms.Button();
            this.SearchUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBook
            // 
            this.SearchBook.Location = new System.Drawing.Point(78, 242);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(304, 38);
            this.SearchBook.TabIndex = 0;
            this.SearchBook.Text = "Search Book";
            this.SearchBook.UseVisualStyleBackColor = true;
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // addbook
            // 
            this.addbook.Location = new System.Drawing.Point(584, 242);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(304, 38);
            this.addbook.TabIndex = 1;
            this.addbook.Text = "addBook";
            this.addbook.UseVisualStyleBackColor = true;
            this.addbook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // editBookButton
            // 
            this.editBookButton.Location = new System.Drawing.Point(78, 356);
            this.editBookButton.Name = "editBookButton";
            this.editBookButton.Size = new System.Drawing.Size(304, 38);
            this.editBookButton.TabIndex = 2;
            this.editBookButton.Text = "editBook";
            this.editBookButton.UseVisualStyleBackColor = true;
            this.editBookButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(584, 356);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(304, 38);
            this.Checkout.TabIndex = 3;
            this.Checkout.Text = "Checkout/Return";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loggedInUserNameLabel
            // 
            this.loggedInUserNameLabel.AutoSize = true;
            this.loggedInUserNameLabel.Location = new System.Drawing.Point(25, 42);
            this.loggedInUserNameLabel.Name = "loggedInUserNameLabel";
            this.loggedInUserNameLabel.Size = new System.Drawing.Size(74, 17);
            this.loggedInUserNameLabel.TabIndex = 5;
            this.loggedInUserNameLabel.Text = "Welcome, ";
            // 
            // AddHolder
            // 
            this.AddHolder.Location = new System.Drawing.Point(584, 154);
            this.AddHolder.Name = "AddHolder";
            this.AddHolder.Size = new System.Drawing.Size(304, 53);
            this.AddHolder.TabIndex = 6;
            this.AddHolder.Text = "AddCard Holder";
            this.AddHolder.UseVisualStyleBackColor = true;
            this.AddHolder.Click += new System.EventHandler(this.AddHolder_Click);
            // 
            // SearchUser
            // 
            this.SearchUser.Location = new System.Drawing.Point(78, 154);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(251, 53);
            this.SearchUser.TabIndex = 7;
            this.SearchUser.Text = "Search User";
            this.SearchUser.UseVisualStyleBackColor = true;
            this.SearchUser.Click += new System.EventHandler(this.SearchUser_Click);
            // 
            // LibrarianMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 517);
            this.Controls.Add(this.SearchUser);
            this.Controls.Add(this.AddHolder);
            this.Controls.Add(this.loggedInUserNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.editBookButton);
            this.Controls.Add(this.addbook);
            this.Controls.Add(this.SearchBook);
            this.Name = "LibrarianMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LibrarianMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBook;
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button editBookButton;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loggedInUserNameLabel;
        private System.Windows.Forms.Button AddHolder;
        private System.Windows.Forms.Button SearchUser;
    }
}