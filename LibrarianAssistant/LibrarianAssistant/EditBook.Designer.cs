namespace LibrarianAssistant
{
    partial class EditBook
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
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.ISBNtext = new System.Windows.Forms.TextBox();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.GenreText = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.AvailableText = new System.Windows.Forms.TextBox();
            this.Available = new System.Windows.Forms.TextBox();
            this.CHText = new System.Windows.Forms.TextBox();
            this.CardHolder = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(518, 395);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "button1";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // ISBN
            // 
            this.ISBN.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ISBN.Location = new System.Drawing.Point(251, 53);
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Size = new System.Drawing.Size(225, 22);
            this.ISBN.TabIndex = 1;
            this.ISBN.TextChanged += new System.EventHandler(this.ISBN_TextChanged);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(251, 100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(225, 22);
            this.Title.TabIndex = 2;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(251, 143);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(225, 22);
            this.Author.TabIndex = 3;
            // 
            // ISBNtext
            // 
            this.ISBNtext.Location = new System.Drawing.Point(98, 52);
            this.ISBNtext.Name = "ISBNtext";
            this.ISBNtext.ReadOnly = true;
            this.ISBNtext.Size = new System.Drawing.Size(100, 22);
            this.ISBNtext.TabIndex = 4;
            this.ISBNtext.TextChanged += new System.EventHandler(this.ISBNtext_TextChanged);
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(98, 99);
            this.TitleText.Name = "TitleText";
            this.TitleText.ReadOnly = true;
            this.TitleText.Size = new System.Drawing.Size(100, 22);
            this.TitleText.TabIndex = 5;
            this.TitleText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(98, 143);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.ReadOnly = true;
            this.AuthorText.Size = new System.Drawing.Size(100, 22);
            this.AuthorText.TabIndex = 6;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(98, 188);
            this.DateText.Name = "DateText";
            this.DateText.ReadOnly = true;
            this.DateText.Size = new System.Drawing.Size(100, 22);
            this.DateText.TabIndex = 7;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(251, 187);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(225, 22);
            this.Date.TabIndex = 8;
            // 
            // GenreText
            // 
            this.GenreText.Location = new System.Drawing.Point(98, 232);
            this.GenreText.Name = "GenreText";
            this.GenreText.ReadOnly = true;
            this.GenreText.Size = new System.Drawing.Size(100, 22);
            this.GenreText.TabIndex = 9;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(251, 232);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(225, 22);
            this.Genre.TabIndex = 10;
            // 
            // AvailableText
            // 
            this.AvailableText.Location = new System.Drawing.Point(98, 274);
            this.AvailableText.Name = "AvailableText";
            this.AvailableText.ReadOnly = true;
            this.AvailableText.Size = new System.Drawing.Size(100, 22);
            this.AvailableText.TabIndex = 11;
            // 
            // Available
            // 
            this.Available.Location = new System.Drawing.Point(251, 273);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(225, 22);
            this.Available.TabIndex = 12;
            // 
            // CHText
            // 
            this.CHText.Location = new System.Drawing.Point(98, 315);
            this.CHText.Name = "CHText";
            this.CHText.ReadOnly = true;
            this.CHText.Size = new System.Drawing.Size(100, 22);
            this.CHText.TabIndex = 13;
            // 
            // CardHolder
            // 
            this.CardHolder.Location = new System.Drawing.Point(251, 315);
            this.CardHolder.Multiline = true;
            this.CardHolder.Name = "CardHolder";
            this.CardHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CardHolder.Size = new System.Drawing.Size(225, 123);
            this.CardHolder.TabIndex = 14;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(40, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 15;
            this.Back.Text = "button1";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.Submit);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.Load += new System.EventHandler(this.EditBook_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox ISBNtext;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox GenreText;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox AvailableText;
        private System.Windows.Forms.TextBox Available;
        private System.Windows.Forms.TextBox CHText;
        private System.Windows.Forms.TextBox CardHolder;
        private System.Windows.Forms.Button Back;
    }
}