namespace MovieSearcher.View
{
    partial class FullInfoMovieView
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
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.ScrollPanel = new System.Windows.Forms.Panel();
            this.InfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CountryValueLabel = new MovieSearcher.AutoResizingLabel();
            this.LanguageValueLabel = new MovieSearcher.AutoResizingLabel();
            this.PlotValueLabel = new MovieSearcher.AutoResizingLabel();
            this.ActorsValueLabel = new MovieSearcher.AutoResizingLabel();
            this.WriterValueLabel = new MovieSearcher.AutoResizingLabel();
            this.DirectorValueLabel = new MovieSearcher.AutoResizingLabel();
            this.GenreValueLabel = new MovieSearcher.AutoResizingLabel();
            this.RuntimeValueLabel = new MovieSearcher.AutoResizingLabel();
            this.ReleasedValueLabel = new MovieSearcher.AutoResizingLabel();
            this.RatedValueLabel = new MovieSearcher.AutoResizingLabel();
            this.YearValueLabel = new MovieSearcher.AutoResizingLabel();
            this.CountryKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.LanguageKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.PlotKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.ActorsKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.WriterKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.DirectorKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.GenreKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.RuntimeKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.ReleasedKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.RatedKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.TitleLabel = new MovieSearcher.AutoResizingLabel();
            this.YearKeyLabel = new MovieSearcher.AutoResizingLabel();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.ScrollPanel.SuspendLayout();
            this.InfoLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.MoviePoster, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ScrollPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(784, 461);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // MoviePoster
            // 
            this.MoviePoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoviePoster.Location = new System.Drawing.Point(3, 3);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(394, 444);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePoster.TabIndex = 1;
            this.MoviePoster.TabStop = false;
            // 
            // ScrollPanel
            // 
            this.ScrollPanel.AutoScroll = true;
            this.ScrollPanel.Controls.Add(this.InfoLayoutPanel);
            this.ScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollPanel.Location = new System.Drawing.Point(403, 3);
            this.ScrollPanel.Name = "ScrollPanel";
            this.ScrollPanel.Size = new System.Drawing.Size(378, 455);
            this.ScrollPanel.TabIndex = 2;
            // 
            // InfoLayoutPanel
            // 
            this.InfoLayoutPanel.AutoSize = true;
            this.InfoLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InfoLayoutPanel.ColumnCount = 2;
            this.InfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfoLayoutPanel.Controls.Add(this.CountryValueLabel, 1, 11);
            this.InfoLayoutPanel.Controls.Add(this.LanguageValueLabel, 1, 10);
            this.InfoLayoutPanel.Controls.Add(this.PlotValueLabel, 1, 9);
            this.InfoLayoutPanel.Controls.Add(this.ActorsValueLabel, 1, 8);
            this.InfoLayoutPanel.Controls.Add(this.WriterValueLabel, 1, 7);
            this.InfoLayoutPanel.Controls.Add(this.DirectorValueLabel, 1, 6);
            this.InfoLayoutPanel.Controls.Add(this.GenreValueLabel, 1, 5);
            this.InfoLayoutPanel.Controls.Add(this.RuntimeValueLabel, 1, 4);
            this.InfoLayoutPanel.Controls.Add(this.ReleasedValueLabel, 1, 3);
            this.InfoLayoutPanel.Controls.Add(this.RatedValueLabel, 1, 2);
            this.InfoLayoutPanel.Controls.Add(this.YearValueLabel, 1, 1);
            this.InfoLayoutPanel.Controls.Add(this.CountryKeyLabel, 0, 11);
            this.InfoLayoutPanel.Controls.Add(this.LanguageKeyLabel, 0, 10);
            this.InfoLayoutPanel.Controls.Add(this.PlotKeyLabel, 0, 9);
            this.InfoLayoutPanel.Controls.Add(this.ActorsKeyLabel, 0, 8);
            this.InfoLayoutPanel.Controls.Add(this.WriterKeyLabel, 0, 7);
            this.InfoLayoutPanel.Controls.Add(this.DirectorKeyLabel, 0, 6);
            this.InfoLayoutPanel.Controls.Add(this.GenreKeyLabel, 0, 5);
            this.InfoLayoutPanel.Controls.Add(this.RuntimeKeyLabel, 0, 4);
            this.InfoLayoutPanel.Controls.Add(this.ReleasedKeyLabel, 0, 3);
            this.InfoLayoutPanel.Controls.Add(this.RatedKeyLabel, 0, 2);
            this.InfoLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.InfoLayoutPanel.Controls.Add(this.YearKeyLabel, 0, 1);
            this.InfoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 5, 10, 15);
            this.InfoLayoutPanel.Name = "InfoLayoutPanel";
            this.InfoLayoutPanel.RowCount = 12;
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InfoLayoutPanel.Size = new System.Drawing.Size(378, 364);
            this.InfoLayoutPanel.TabIndex = 0;
            // 
            // CountryValueLabel
            // 
            this.CountryValueLabel.AutoSize = true;
            this.CountryValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountryValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryValueLabel.Location = new System.Drawing.Point(85, 339);
            this.CountryValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.CountryValueLabel.Name = "CountryValueLabel";
            this.CountryValueLabel.Size = new System.Drawing.Size(293, 0);
            this.CountryValueLabel.TabIndex = 22;
            // 
            // LanguageValueLabel
            // 
            this.LanguageValueLabel.AutoSize = true;
            this.LanguageValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LanguageValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageValueLabel.Location = new System.Drawing.Point(85, 309);
            this.LanguageValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LanguageValueLabel.Name = "LanguageValueLabel";
            this.LanguageValueLabel.Size = new System.Drawing.Size(293, 0);
            this.LanguageValueLabel.TabIndex = 21;
            // 
            // PlotValueLabel
            // 
            this.PlotValueLabel.AutoSize = true;
            this.PlotValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotValueLabel.Location = new System.Drawing.Point(85, 279);
            this.PlotValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.PlotValueLabel.Name = "PlotValueLabel";
            this.PlotValueLabel.Size = new System.Drawing.Size(293, 0);
            this.PlotValueLabel.TabIndex = 20;
            // 
            // ActorsValueLabel
            // 
            this.ActorsValueLabel.AutoSize = true;
            this.ActorsValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorsValueLabel.Location = new System.Drawing.Point(85, 249);
            this.ActorsValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ActorsValueLabel.Name = "ActorsValueLabel";
            this.ActorsValueLabel.Size = new System.Drawing.Size(293, 0);
            this.ActorsValueLabel.TabIndex = 19;
            // 
            // WriterValueLabel
            // 
            this.WriterValueLabel.AutoSize = true;
            this.WriterValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriterValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterValueLabel.Location = new System.Drawing.Point(85, 219);
            this.WriterValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.WriterValueLabel.Name = "WriterValueLabel";
            this.WriterValueLabel.Size = new System.Drawing.Size(293, 0);
            this.WriterValueLabel.TabIndex = 18;
            // 
            // DirectorValueLabel
            // 
            this.DirectorValueLabel.AutoSize = true;
            this.DirectorValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectorValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorValueLabel.Location = new System.Drawing.Point(85, 189);
            this.DirectorValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.DirectorValueLabel.Name = "DirectorValueLabel";
            this.DirectorValueLabel.Size = new System.Drawing.Size(293, 0);
            this.DirectorValueLabel.TabIndex = 17;
            // 
            // GenreValueLabel
            // 
            this.GenreValueLabel.AutoSize = true;
            this.GenreValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreValueLabel.Location = new System.Drawing.Point(85, 159);
            this.GenreValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.GenreValueLabel.Name = "GenreValueLabel";
            this.GenreValueLabel.Size = new System.Drawing.Size(293, 0);
            this.GenreValueLabel.TabIndex = 16;
            // 
            // RuntimeValueLabel
            // 
            this.RuntimeValueLabel.AutoSize = true;
            this.RuntimeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuntimeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuntimeValueLabel.Location = new System.Drawing.Point(85, 129);
            this.RuntimeValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.RuntimeValueLabel.Name = "RuntimeValueLabel";
            this.RuntimeValueLabel.Size = new System.Drawing.Size(293, 0);
            this.RuntimeValueLabel.TabIndex = 15;
            // 
            // ReleasedValueLabel
            // 
            this.ReleasedValueLabel.AutoSize = true;
            this.ReleasedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleasedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleasedValueLabel.Location = new System.Drawing.Point(85, 99);
            this.ReleasedValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ReleasedValueLabel.Name = "ReleasedValueLabel";
            this.ReleasedValueLabel.Size = new System.Drawing.Size(293, 0);
            this.ReleasedValueLabel.TabIndex = 14;
            // 
            // RatedValueLabel
            // 
            this.RatedValueLabel.AutoSize = true;
            this.RatedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RatedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatedValueLabel.Location = new System.Drawing.Point(85, 69);
            this.RatedValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.RatedValueLabel.Name = "RatedValueLabel";
            this.RatedValueLabel.Size = new System.Drawing.Size(293, 0);
            this.RatedValueLabel.TabIndex = 13;
            // 
            // YearValueLabel
            // 
            this.YearValueLabel.AutoSize = true;
            this.YearValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearValueLabel.Location = new System.Drawing.Point(85, 39);
            this.YearValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.YearValueLabel.Name = "YearValueLabel";
            this.YearValueLabel.Size = new System.Drawing.Size(293, 0);
            this.YearValueLabel.TabIndex = 12;
            // 
            // CountryKeyLabel
            // 
            this.CountryKeyLabel.AutoSize = true;
            this.CountryKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountryKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryKeyLabel.Location = new System.Drawing.Point(0, 339);
            this.CountryKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.CountryKeyLabel.Name = "CountryKeyLabel";
            this.CountryKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.CountryKeyLabel.TabIndex = 11;
            this.CountryKeyLabel.Text = "Country";
            this.CountryKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LanguageKeyLabel
            // 
            this.LanguageKeyLabel.AutoSize = true;
            this.LanguageKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LanguageKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageKeyLabel.Location = new System.Drawing.Point(0, 309);
            this.LanguageKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LanguageKeyLabel.Name = "LanguageKeyLabel";
            this.LanguageKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.LanguageKeyLabel.TabIndex = 10;
            this.LanguageKeyLabel.Text = "Language:";
            this.LanguageKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlotKeyLabel
            // 
            this.PlotKeyLabel.AutoSize = true;
            this.PlotKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotKeyLabel.Location = new System.Drawing.Point(0, 279);
            this.PlotKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.PlotKeyLabel.Name = "PlotKeyLabel";
            this.PlotKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.PlotKeyLabel.TabIndex = 9;
            this.PlotKeyLabel.Text = "Plot:";
            this.PlotKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ActorsKeyLabel
            // 
            this.ActorsKeyLabel.AutoSize = true;
            this.ActorsKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorsKeyLabel.Location = new System.Drawing.Point(0, 249);
            this.ActorsKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ActorsKeyLabel.Name = "ActorsKeyLabel";
            this.ActorsKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.ActorsKeyLabel.TabIndex = 8;
            this.ActorsKeyLabel.Text = "Actors:";
            this.ActorsKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WriterKeyLabel
            // 
            this.WriterKeyLabel.AutoSize = true;
            this.WriterKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriterKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterKeyLabel.Location = new System.Drawing.Point(0, 219);
            this.WriterKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.WriterKeyLabel.Name = "WriterKeyLabel";
            this.WriterKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.WriterKeyLabel.TabIndex = 7;
            this.WriterKeyLabel.Text = "Writer:";
            this.WriterKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DirectorKeyLabel
            // 
            this.DirectorKeyLabel.AutoSize = true;
            this.DirectorKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectorKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorKeyLabel.Location = new System.Drawing.Point(0, 189);
            this.DirectorKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.DirectorKeyLabel.Name = "DirectorKeyLabel";
            this.DirectorKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.DirectorKeyLabel.TabIndex = 6;
            this.DirectorKeyLabel.Text = "Director";
            this.DirectorKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GenreKeyLabel
            // 
            this.GenreKeyLabel.AutoSize = true;
            this.GenreKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreKeyLabel.Location = new System.Drawing.Point(0, 159);
            this.GenreKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.GenreKeyLabel.Name = "GenreKeyLabel";
            this.GenreKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.GenreKeyLabel.TabIndex = 5;
            this.GenreKeyLabel.Text = "Genre:";
            this.GenreKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RuntimeKeyLabel
            // 
            this.RuntimeKeyLabel.AutoSize = true;
            this.RuntimeKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuntimeKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuntimeKeyLabel.Location = new System.Drawing.Point(0, 129);
            this.RuntimeKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.RuntimeKeyLabel.Name = "RuntimeKeyLabel";
            this.RuntimeKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.RuntimeKeyLabel.TabIndex = 4;
            this.RuntimeKeyLabel.Text = "Runtime:";
            this.RuntimeKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReleasedKeyLabel
            // 
            this.ReleasedKeyLabel.AutoSize = true;
            this.ReleasedKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleasedKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleasedKeyLabel.Location = new System.Drawing.Point(0, 99);
            this.ReleasedKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ReleasedKeyLabel.Name = "ReleasedKeyLabel";
            this.ReleasedKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.ReleasedKeyLabel.TabIndex = 3;
            this.ReleasedKeyLabel.Text = "Released:";
            this.ReleasedKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RatedKeyLabel
            // 
            this.RatedKeyLabel.AutoSize = true;
            this.RatedKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RatedKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatedKeyLabel.Location = new System.Drawing.Point(0, 69);
            this.RatedKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.RatedKeyLabel.Name = "RatedKeyLabel";
            this.RatedKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.RatedKeyLabel.TabIndex = 2;
            this.RatedKeyLabel.Text = "Rated:";
            this.RatedKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.InfoLayoutPanel.SetColumnSpan(this.TitleLabel, 2);
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 5);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 0);
            this.TitleLabel.TabIndex = 0;
            // 
            // YearKeyLabel
            // 
            this.YearKeyLabel.AutoSize = true;
            this.YearKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearKeyLabel.Location = new System.Drawing.Point(0, 39);
            this.YearKeyLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.YearKeyLabel.Name = "YearKeyLabel";
            this.YearKeyLabel.Size = new System.Drawing.Size(85, 20);
            this.YearKeyLabel.TabIndex = 1;
            this.YearKeyLabel.Text = "Year:";
            this.YearKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FullInfoMovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FullInfoMovieView";
            this.Text = "FullInfoMovieMovie2";
            this.MainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ScrollPanel.ResumeLayout(false);
            this.ScrollPanel.PerformLayout();
            this.InfoLayoutPanel.ResumeLayout(false);
            this.InfoLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Panel ScrollPanel;
        private System.Windows.Forms.TableLayoutPanel InfoLayoutPanel;
        private AutoResizingLabel TitleLabel;
        private AutoResizingLabel CountryValueLabel;
        private AutoResizingLabel LanguageValueLabel;
        private AutoResizingLabel PlotValueLabel;
        private AutoResizingLabel ActorsValueLabel;
        private AutoResizingLabel WriterValueLabel;
        private AutoResizingLabel DirectorValueLabel;
        private AutoResizingLabel GenreValueLabel;
        private AutoResizingLabel RuntimeValueLabel;
        private AutoResizingLabel ReleasedValueLabel;
        private AutoResizingLabel RatedValueLabel;
        private AutoResizingLabel YearValueLabel;
        private AutoResizingLabel CountryKeyLabel;
        private AutoResizingLabel LanguageKeyLabel;
        private AutoResizingLabel PlotKeyLabel;
        private AutoResizingLabel ActorsKeyLabel;
        private AutoResizingLabel WriterKeyLabel;
        private AutoResizingLabel DirectorKeyLabel;
        private AutoResizingLabel GenreKeyLabel;
        private AutoResizingLabel RuntimeKeyLabel;
        private AutoResizingLabel ReleasedKeyLabel;
        private AutoResizingLabel RatedKeyLabel;
        private AutoResizingLabel YearKeyLabel;
    }
}