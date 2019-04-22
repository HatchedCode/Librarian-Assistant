namespace LibrarianAssistant.Librarian
{
    partial class SearchBookcs
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
            this.searchClick = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.TextBox();
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
            // searchClick
            // 
            this.searchClick.Location = new System.Drawing.Point(582, 296);
            this.searchClick.Name = "searchClick";
            this.searchClick.Size = new System.Drawing.Size(75, 23);
            this.searchClick.TabIndex = 37;
            this.searchClick.Text = "Search";
            this.searchClick.UseVisualStyleBackColor = true;
            this.searchClick.Click += new System.EventHandler(this.searchClick_ClickAsync);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(297, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(225, 22);
            this.search.TabIndex = 36;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(144, 39);
            this.searchText.Name = "searchText";
            this.searchText.ReadOnly = true;
            this.searchText.Size = new System.Drawing.Size(100, 22);
            this.searchText.TabIndex = 35;
            this.searchText.Text = "search";
            // 
            // CardHolder
            // 
            this.CardHolder.Location = new System.Drawing.Point(297, 339);
            this.CardHolder.Multiline = true;
            this.CardHolder.Name = "CardHolder";
            this.CardHolder.ReadOnly = true;
            this.CardHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CardHolder.Size = new System.Drawing.Size(225, 74);
            this.CardHolder.TabIndex = 33;
            // 
            // CHText
            // 
            this.CHText.Location = new System.Drawing.Point(144, 339);
            this.CHText.Name = "CHText";
            this.CHText.ReadOnly = true;
            this.CHText.Size = new System.Drawing.Size(100, 22);
            this.CHText.TabIndex = 32;
            this.CHText.Text = "Current Holders";
            // 
            // Available
            // 
            this.Available.Location = new System.Drawing.Point(297, 297);
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            this.Available.Size = new System.Drawing.Size(225, 22);
            this.Available.TabIndex = 31;
            // 
            // AvailableText
            // 
            this.AvailableText.Location = new System.Drawing.Point(144, 298);
            this.AvailableText.Name = "AvailableText";
            this.AvailableText.ReadOnly = true;
            this.AvailableText.Size = new System.Drawing.Size(100, 22);
            this.AvailableText.TabIndex = 30;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(297, 256);
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Size = new System.Drawing.Size(225, 22);
            this.Genre.TabIndex = 29;
            // 
            // GenreText
            // 
            this.GenreText.Location = new System.Drawing.Point(144, 256);
            this.GenreText.Name = "GenreText";
            this.GenreText.ReadOnly = true;
            this.GenreText.Size = new System.Drawing.Size(100, 22);
            this.GenreText.TabIndex = 28;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(297, 211);
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(225, 22);
            this.Date.TabIndex = 27;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(144, 212);
            this.DateText.Name = "DateText";
            this.DateText.ReadOnly = true;
            this.DateText.Size = new System.Drawing.Size(100, 22);
            this.DateText.TabIndex = 26;
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(144, 167);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.ReadOnly = true;
            this.AuthorText.Size = new System.Drawing.Size(100, 22);
            this.AuthorText.TabIndex = 25;
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(144, 82);
            this.TitleText.Name = "TitleText";
            this.TitleText.ReadOnly = true;
            this.TitleText.Size = new System.Drawing.Size(100, 22);
            this.TitleText.TabIndex = 24;
            // 
            // ISBNtext
            // 
            this.ISBNtext.Location = new System.Drawing.Point(144, 122);
            this.ISBNtext.Name = "ISBNtext";
            this.ISBNtext.ReadOnly = true;
            this.ISBNtext.Size = new System.Drawing.Size(100, 22);
            this.ISBNtext.TabIndex = 23;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(297, 167);
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Size = new System.Drawing.Size(225, 22);
            this.Author.TabIndex = 22;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(297, 82);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(225, 22);
            this.Title.TabIndex = 21;
            // 
            // ISBN
            // 
            this.ISBN.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ISBN.Location = new System.Drawing.Point(297, 122);
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Size = new System.Drawing.Size(225, 22);
            this.ISBN.TabIndex = 20;
            this.ISBN.TextChanged += new System.EventHandler(this.ISBN_TextChanged);
            // 
            // SearchBookcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchClick);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchText);
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
            this.Name = "SearchBookcs";
            this.Text = "SearchBookcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchClick;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox searchText;
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