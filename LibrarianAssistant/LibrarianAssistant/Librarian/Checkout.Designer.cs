namespace LibrarianAssistant.Librarian
{
    partial class Checkout
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
            this.UserText = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.TextBox();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.returner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(518, 239);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Checkout";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_ClickAsync);
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(115, 76);
            this.UserText.Name = "UserText";
            this.UserText.ReadOnly = true;
            this.UserText.Size = new System.Drawing.Size(100, 22);
            this.UserText.TabIndex = 1;
            this.UserText.Text = "UserID";
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(360, 75);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(100, 22);
            this.UserId.TabIndex = 2;
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(115, 135);
            this.TitleText.Name = "TitleText";
            this.TitleText.ReadOnly = true;
            this.TitleText.Size = new System.Drawing.Size(100, 22);
            this.TitleText.TabIndex = 3;
            this.TitleText.Text = "Title";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(360, 135);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 22);
            this.Title.TabIndex = 4;
            // 
            // returner
            // 
            this.returner.Location = new System.Drawing.Point(518, 297);
            this.returner.Name = "returner";
            this.returner.Size = new System.Drawing.Size(75, 23);
            this.returner.TabIndex = 5;
            this.returner.Text = "return";
            this.returner.UseVisualStyleBackColor = true;
            this.returner.Click += new System.EventHandler(this.returner_ClickAsync);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returner);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.Submit);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button returner;
    }
}