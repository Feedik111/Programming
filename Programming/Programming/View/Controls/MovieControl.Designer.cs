using System.ComponentModel;

namespace Programming.View.Controls
{
    partial class MovieControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DurationMinutesMovieTextBox = new System.Windows.Forms.TextBox();
            this.YearReleaseMovieTextBox = new System.Windows.Forms.TextBox();
            this.GenreMovieTextBox = new System.Windows.Forms.TextBox();
            this.RatingMovieTextBox = new System.Windows.Forms.TextBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.NameMovieTextBox = new System.Windows.Forms.TextBox();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.NameFilmLabel = new System.Windows.Forms.Label();
            this.GenreFilmLabel = new System.Windows.Forms.Label();
            this.DurationMinutesFilmLabel = new System.Windows.Forms.Label();
            this.YearReleaseFilmLabel = new System.Windows.Forms.Label();
            this.RatingFilmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DurationMinutesMovieTextBox
            // 
            this.DurationMinutesMovieTextBox.Location = new System.Drawing.Point(117, 137);
            this.DurationMinutesMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DurationMinutesMovieTextBox.Name = "DurationMinutesMovieTextBox";
            this.DurationMinutesMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.DurationMinutesMovieTextBox.TabIndex = 33;
            this.DurationMinutesMovieTextBox.TextChanged += new System.EventHandler(this.DurationMinutesMovieTextBox_TextChanged);
            // 
            // YearReleaseMovieTextBox
            // 
            this.YearReleaseMovieTextBox.Location = new System.Drawing.Point(117, 98);
            this.YearReleaseMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YearReleaseMovieTextBox.Name = "YearReleaseMovieTextBox";
            this.YearReleaseMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.YearReleaseMovieTextBox.TabIndex = 32;
            this.YearReleaseMovieTextBox.TextChanged += new System.EventHandler(this.YearReleaseMovieTextBox_TextChanged);
            // 
            // GenreMovieTextBox
            // 
            this.GenreMovieTextBox.Location = new System.Drawing.Point(117, 59);
            this.GenreMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreMovieTextBox.Name = "GenreMovieTextBox";
            this.GenreMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.GenreMovieTextBox.TabIndex = 31;
            this.GenreMovieTextBox.TextChanged += new System.EventHandler(this.GenreMovieTextBox_TextChanged);
            // 
            // RatingMovieTextBox
            // 
            this.RatingMovieTextBox.Location = new System.Drawing.Point(117, 176);
            this.RatingMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RatingMovieTextBox.Name = "RatingMovieTextBox";
            this.RatingMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.RatingMovieTextBox.TabIndex = 30;
            this.RatingMovieTextBox.TextChanged += new System.EventHandler(this.RatingMovieTextBox_TextChanged);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(0, 3);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(112, 290);
            this.MovieListBox.TabIndex = 22;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // NameMovieTextBox
            // 
            this.NameMovieTextBox.Location = new System.Drawing.Point(117, 21);
            this.NameMovieTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameMovieTextBox.Name = "NameMovieTextBox";
            this.NameMovieTextBox.Size = new System.Drawing.Size(119, 20);
            this.NameMovieTextBox.TabIndex = 29;
            this.NameMovieTextBox.TextChanged += new System.EventHandler(this.NameMovieTextBox_TextChanged);
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(117, 270);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(71, 23);
            this.FindMovieButton.TabIndex = 28;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // NameFilmLabel
            // 
            this.NameFilmLabel.Location = new System.Drawing.Point(117, 3);
            this.NameFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameFilmLabel.Name = "NameFilmLabel";
            this.NameFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.NameFilmLabel.TabIndex = 27;
            this.NameFilmLabel.Text = "Name:";
            // 
            // GenreFilmLabel
            // 
            this.GenreFilmLabel.Location = new System.Drawing.Point(117, 42);
            this.GenreFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenreFilmLabel.Name = "GenreFilmLabel";
            this.GenreFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.GenreFilmLabel.TabIndex = 24;
            this.GenreFilmLabel.Text = "Genre:";
            // 
            // DurationMinutesFilmLabel
            // 
            this.DurationMinutesFilmLabel.Location = new System.Drawing.Point(117, 120);
            this.DurationMinutesFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DurationMinutesFilmLabel.Name = "DurationMinutesFilmLabel";
            this.DurationMinutesFilmLabel.Size = new System.Drawing.Size(105, 15);
            this.DurationMinutesFilmLabel.TabIndex = 26;
            this.DurationMinutesFilmLabel.Text = "Duration in minutes:";
            // 
            // YearReleaseFilmLabel
            // 
            this.YearReleaseFilmLabel.Location = new System.Drawing.Point(117, 82);
            this.YearReleaseFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YearReleaseFilmLabel.Name = "YearReleaseFilmLabel";
            this.YearReleaseFilmLabel.Size = new System.Drawing.Size(106, 15);
            this.YearReleaseFilmLabel.TabIndex = 25;
            this.YearReleaseFilmLabel.Text = "Year of release:";
            // 
            // RatingFilmLabel
            // 
            this.RatingFilmLabel.Location = new System.Drawing.Point(117, 159);
            this.RatingFilmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RatingFilmLabel.Name = "RatingFilmLabel";
            this.RatingFilmLabel.Size = new System.Drawing.Size(49, 15);
            this.RatingFilmLabel.TabIndex = 23;
            this.RatingFilmLabel.Text = "Rating:";
            // 
            // MovieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DurationMinutesMovieTextBox);
            this.Controls.Add(this.YearReleaseMovieTextBox);
            this.Controls.Add(this.GenreMovieTextBox);
            this.Controls.Add(this.RatingMovieTextBox);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.NameMovieTextBox);
            this.Controls.Add(this.FindMovieButton);
            this.Controls.Add(this.NameFilmLabel);
            this.Controls.Add(this.GenreFilmLabel);
            this.Controls.Add(this.DurationMinutesFilmLabel);
            this.Controls.Add(this.YearReleaseFilmLabel);
            this.Controls.Add(this.RatingFilmLabel);
            this.Name = "MovieControl";
            this.Size = new System.Drawing.Size(296, 369);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox DurationMinutesMovieTextBox;
        private System.Windows.Forms.TextBox YearReleaseMovieTextBox;
        private System.Windows.Forms.TextBox GenreMovieTextBox;
        private System.Windows.Forms.TextBox RatingMovieTextBox;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.TextBox NameMovieTextBox;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.Label NameFilmLabel;
        private System.Windows.Forms.Label GenreFilmLabel;
        private System.Windows.Forms.Label DurationMinutesFilmLabel;
        private System.Windows.Forms.Label YearReleaseFilmLabel;
        private System.Windows.Forms.Label RatingFilmLabel;

        #endregion
    }
}