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
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBook
            // 
            this.SearchBook.Location = new System.Drawing.Point(83, 41);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(119, 23);
            this.SearchBook.TabIndex = 0;
            this.SearchBook.Text = "Search Book";
            this.SearchBook.UseVisualStyleBackColor = true;
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // addbook
            // 
            this.addbook.Location = new System.Drawing.Point(83, 83);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(75, 23);
            this.addbook.TabIndex = 1;
            this.addbook.Text = "addBook";
            this.addbook.UseVisualStyleBackColor = true;
            this.addbook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "editBook";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LibrarianMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addbook);
            this.Controls.Add(this.SearchBook);
            this.Name = "LibrarianMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchBook;
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button button3;
    }
}