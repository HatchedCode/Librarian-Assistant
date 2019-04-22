namespace LibrarianAssistant.Librarian
{
    partial class AddBook
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
            this.Submit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.CardHolder = new System.Windows.Forms.TextBox();
            this.CHText = new System.Windows.Forms.TextBox();
            this.Available = new System.Windows.Forms.TextBox();
            this.AvailableText = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.GenreText = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.TextBox();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.ISBNtext = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(611, 336);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 32;
            this.Submit.Text = "submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(115, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 31;
            this.Back.Text = "button1";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // CardHolder
            // 
            this.CardHolder.Location = new System.Drawing.Point(326, 315);
            this.CardHolder.Multiline = true;
            this.CardHolder.Name = "CardHolder";
            this.CardHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CardHolder.Size = new System.Drawing.Size(225, 123);
            this.CardHolder.TabIndex = 30;
            // 
            // CHText
            // 
            this.CHText.Location = new System.Drawing.Point(173, 315);
            this.CHText.Name = "CHText";
            this.CHText.ReadOnly = true;
            this.CHText.Size = new System.Drawing.Size(100, 22);
            this.CHText.TabIndex = 29;
            // 
            // Available
            // 
            this.Available.Location = new System.Drawing.Point(326, 273);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(225, 22);
            this.Available.TabIndex = 28;
            // 
            // AvailableText
            // 
            this.AvailableText.Location = new System.Drawing.Point(173, 274);
            this.AvailableText.Name = "AvailableText";
            this.AvailableText.ReadOnly = true;
            this.AvailableText.Size = new System.Drawing.Size(100, 22);
            this.AvailableText.TabIndex = 27;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(326, 232);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(225, 22);
            this.Genre.TabIndex = 26;
            // 
            // GenreText
            // 
            this.GenreText.Location = new System.Drawing.Point(173, 232);
            this.GenreText.Name = "GenreText";
            this.GenreText.ReadOnly = true;
            this.GenreText.Size = new System.Drawing.Size(100, 22);
            this.GenreText.TabIndex = 25;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(326, 187);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(225, 22);
            this.Date.TabIndex = 24;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(173, 188);
            this.DateText.Name = "DateText";
            this.DateText.ReadOnly = true;
            this.DateText.Size = new System.Drawing.Size(100, 22);
            this.DateText.TabIndex = 23;
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(173, 143);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.ReadOnly = true;
            this.AuthorText.Size = new System.Drawing.Size(100, 22);
            this.AuthorText.TabIndex = 22;
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(173, 99);
            this.TitleText.Name = "TitleText";
            this.TitleText.ReadOnly = true;
            this.TitleText.Size = new System.Drawing.Size(100, 22);
            this.TitleText.TabIndex = 21;
            // 
            // ISBNtext
            // 
            this.ISBNtext.Location = new System.Drawing.Point(173, 52);
            this.ISBNtext.Name = "ISBNtext";
            this.ISBNtext.ReadOnly = true;
            this.ISBNtext.Size = new System.Drawing.Size(100, 22);
            this.ISBNtext.TabIndex = 20;
            this.ISBNtext.TextChanged += new System.EventHandler(this.ISBNtext_TextChanged);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(326, 143);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(225, 22);
            this.Author.TabIndex = 19;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(326, 100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(225, 22);
            this.Title.TabIndex = 18;
            // 
            // ISBN
            // 
            this.ISBN.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ISBN.Location = new System.Drawing.Point(326, 53);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(225, 22);
            this.ISBN.TabIndex = 17;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CardHolder);
            this.Controls.Add(this.CHText);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.AvailableText);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.GenreText);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.ISBNtext);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ISBN);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox CardHolder;
        private System.Windows.Forms.TextBox CHText;
        private System.Windows.Forms.TextBox Available;
        private System.Windows.Forms.TextBox AvailableText;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox GenreText;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.TextBox ISBNtext;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox ISBN;
    }
}