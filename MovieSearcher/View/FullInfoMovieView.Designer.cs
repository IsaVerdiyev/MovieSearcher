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
            this.RatedLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RatedValueLabel = new MovieSearcher.AutoResizingLabel();
            this.ReleasedTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ReleasedKeyLabel = new System.Windows.Forms.Label();
            this.ReleasedValueLabel = new MovieSearcher.AutoResizingLabel();
            this.RuntimeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RuntimeKeyLabel = new System.Windows.Forms.Label();
            this.RuntimeValueLabel = new MovieSearcher.AutoResizingLabel();
            this.GenreTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenreKeyLabel = new System.Windows.Forms.Label();
            this.GenreValueLabel = new MovieSearcher.AutoResizingLabel();
            this.DirectorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DirectorKeyLabel = new System.Windows.Forms.Label();
            this.DirectorValueLabel = new MovieSearcher.AutoResizingLabel();
            this.WriterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WriterKeyLabel = new System.Windows.Forms.Label();
            this.WriterValueLabel = new MovieSearcher.AutoResizingLabel();
            this.ActorsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ActorsKeyLabel = new System.Windows.Forms.Label();
            this.ActorsValueLabel = new MovieSearcher.AutoResizingLabel();
            this.PlotTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlotValueLabel = new MovieSearcher.AutoResizingLabel();
            this.LanguageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LanguageValueLabel = new MovieSearcher.AutoResizingLabel();
            this.CountryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CountryValueLabel = new MovieSearcher.AutoResizingLabel();
            this.InfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlotKeyLabel = new System.Windows.Forms.Label();
            this.LanguageKeyLabel = new System.Windows.Forms.Label();
            this.CountryKeyLabel = new System.Windows.Forms.Label();
            this.YearValueLabel = new MovieSearcher.AutoResizingLabel();
            this.YearLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RatedKeyLabel = new System.Windows.Forms.Label();
            this.YearLabelKey = new System.Windows.Forms.Label();
            this.TitleName = new System.Windows.Forms.Label();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.ScrollPanel.SuspendLayout();
            this.RatedLayoutPanel.SuspendLayout();
            this.ReleasedTableLayoutPanel.SuspendLayout();
            this.RuntimeTableLayoutPanel.SuspendLayout();
            this.GenreTableLayoutPanel.SuspendLayout();
            this.DirectorTableLayoutPanel.SuspendLayout();
            this.WriterTableLayoutPanel.SuspendLayout();
            this.ActorsTableLayoutPanel.SuspendLayout();
            this.PlotTableLayoutPanel.SuspendLayout();
            this.LanguageTableLayoutPanel.SuspendLayout();
            this.CountryTableLayoutPanel.SuspendLayout();
            this.InfoLayoutPanel.SuspendLayout();
            this.YearLayoutPanel.SuspendLayout();
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
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // MoviePoster
            // 
            this.MoviePoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoviePoster.Location = new System.Drawing.Point(3, 3);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(394, 455);
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
            // RatedLayoutPanel
            // 
            this.RatedLayoutPanel.AutoSize = true;
            this.RatedLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RatedLayoutPanel.ColumnCount = 2;
            this.RatedLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.RatedLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.RatedLayoutPanel.Controls.Add(this.RatedValueLabel, 0, 0);
            this.RatedLayoutPanel.Controls.Add(this.RatedKeyLabel, 0, 0);
            this.RatedLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RatedLayoutPanel.Location = new System.Drawing.Point(3, 53);
            this.RatedLayoutPanel.Name = "RatedLayoutPanel";
            this.RatedLayoutPanel.RowCount = 1;
            this.RatedLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RatedLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.RatedLayoutPanel.TabIndex = 2;
            // 
            // RatedValueLabel
            // 
            this.RatedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RatedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatedValueLabel.Location = new System.Drawing.Point(114, 0);
            this.RatedValueLabel.Name = "RatedValueLabel";
            this.RatedValueLabel.Size = new System.Drawing.Size(255, 0);
            this.RatedValueLabel.TabIndex = 2;
            // 
            // ReleasedTableLayoutPanel
            // 
            this.ReleasedTableLayoutPanel.AutoSize = true;
            this.ReleasedTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReleasedTableLayoutPanel.ColumnCount = 2;
            this.ReleasedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ReleasedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ReleasedTableLayoutPanel.Controls.Add(this.ReleasedValueLabel, 0, 0);
            this.ReleasedTableLayoutPanel.Controls.Add(this.ReleasedKeyLabel, 0, 0);
            this.ReleasedTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleasedTableLayoutPanel.Location = new System.Drawing.Point(3, 79);
            this.ReleasedTableLayoutPanel.Name = "ReleasedTableLayoutPanel";
            this.ReleasedTableLayoutPanel.RowCount = 1;
            this.ReleasedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ReleasedTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.ReleasedTableLayoutPanel.TabIndex = 3;
            // 
            // ReleasedKeyLabel
            // 
            this.ReleasedKeyLabel.AutoSize = true;
            this.ReleasedKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleasedKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleasedKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.ReleasedKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ReleasedKeyLabel.Name = "ReleasedKeyLabel";
            this.ReleasedKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.ReleasedKeyLabel.TabIndex = 0;
            this.ReleasedKeyLabel.Text = "Released:";
            this.ReleasedKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReleasedValueLabel
            // 
            this.ReleasedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReleasedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleasedValueLabel.Location = new System.Drawing.Point(114, 0);
            this.ReleasedValueLabel.Name = "ReleasedValueLabel";
            this.ReleasedValueLabel.Size = new System.Drawing.Size(255, 0);
            this.ReleasedValueLabel.TabIndex = 2;
            // 
            // RuntimeTableLayoutPanel
            // 
            this.RuntimeTableLayoutPanel.AutoSize = true;
            this.RuntimeTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RuntimeTableLayoutPanel.ColumnCount = 2;
            this.RuntimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.RuntimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.RuntimeTableLayoutPanel.Controls.Add(this.RuntimeValueLabel, 0, 0);
            this.RuntimeTableLayoutPanel.Controls.Add(this.RuntimeKeyLabel, 0, 0);
            this.RuntimeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuntimeTableLayoutPanel.Location = new System.Drawing.Point(3, 105);
            this.RuntimeTableLayoutPanel.Name = "RuntimeTableLayoutPanel";
            this.RuntimeTableLayoutPanel.RowCount = 1;
            this.RuntimeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RuntimeTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.RuntimeTableLayoutPanel.TabIndex = 4;
            // 
            // RuntimeKeyLabel
            // 
            this.RuntimeKeyLabel.AutoSize = true;
            this.RuntimeKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuntimeKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuntimeKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.RuntimeKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.RuntimeKeyLabel.Name = "RuntimeKeyLabel";
            this.RuntimeKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.RuntimeKeyLabel.TabIndex = 0;
            this.RuntimeKeyLabel.Text = "RunTime:";
            this.RuntimeKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RuntimeValueLabel
            // 
            this.RuntimeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuntimeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuntimeValueLabel.Location = new System.Drawing.Point(114, 0);
            this.RuntimeValueLabel.Name = "RuntimeValueLabel";
            this.RuntimeValueLabel.Size = new System.Drawing.Size(255, 0);
            this.RuntimeValueLabel.TabIndex = 2;
            // 
            // GenreTableLayoutPanel
            // 
            this.GenreTableLayoutPanel.AutoSize = true;
            this.GenreTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenreTableLayoutPanel.ColumnCount = 2;
            this.GenreTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.GenreTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.GenreTableLayoutPanel.Controls.Add(this.GenreValueLabel, 0, 0);
            this.GenreTableLayoutPanel.Controls.Add(this.GenreKeyLabel, 0, 0);
            this.GenreTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreTableLayoutPanel.Location = new System.Drawing.Point(3, 131);
            this.GenreTableLayoutPanel.Name = "GenreTableLayoutPanel";
            this.GenreTableLayoutPanel.RowCount = 1;
            this.GenreTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GenreTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.GenreTableLayoutPanel.TabIndex = 5;
            // 
            // GenreKeyLabel
            // 
            this.GenreKeyLabel.AutoSize = true;
            this.GenreKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.GenreKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.GenreKeyLabel.Name = "GenreKeyLabel";
            this.GenreKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.GenreKeyLabel.TabIndex = 0;
            this.GenreKeyLabel.Text = "Genre:";
            this.GenreKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GenreValueLabel
            // 
            this.GenreValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreValueLabel.Location = new System.Drawing.Point(114, 0);
            this.GenreValueLabel.Name = "GenreValueLabel";
            this.GenreValueLabel.Size = new System.Drawing.Size(255, 0);
            this.GenreValueLabel.TabIndex = 2;
            // 
            // DirectorTableLayoutPanel
            // 
            this.DirectorTableLayoutPanel.AutoSize = true;
            this.DirectorTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DirectorTableLayoutPanel.ColumnCount = 2;
            this.DirectorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.DirectorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.DirectorTableLayoutPanel.Controls.Add(this.DirectorValueLabel, 0, 0);
            this.DirectorTableLayoutPanel.Controls.Add(this.DirectorKeyLabel, 0, 0);
            this.DirectorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectorTableLayoutPanel.Location = new System.Drawing.Point(3, 157);
            this.DirectorTableLayoutPanel.Name = "DirectorTableLayoutPanel";
            this.DirectorTableLayoutPanel.RowCount = 1;
            this.DirectorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DirectorTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.DirectorTableLayoutPanel.TabIndex = 6;
            // 
            // DirectorKeyLabel
            // 
            this.DirectorKeyLabel.AutoSize = true;
            this.DirectorKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectorKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.DirectorKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DirectorKeyLabel.Name = "DirectorKeyLabel";
            this.DirectorKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.DirectorKeyLabel.TabIndex = 0;
            this.DirectorKeyLabel.Text = "Director:";
            this.DirectorKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DirectorValueLabel
            // 
            this.DirectorValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectorValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorValueLabel.Location = new System.Drawing.Point(114, 0);
            this.DirectorValueLabel.Name = "DirectorValueLabel";
            this.DirectorValueLabel.Size = new System.Drawing.Size(255, 0);
            this.DirectorValueLabel.TabIndex = 2;
            // 
            // WriterTableLayoutPanel
            // 
            this.WriterTableLayoutPanel.AutoSize = true;
            this.WriterTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WriterTableLayoutPanel.ColumnCount = 2;
            this.WriterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.WriterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.WriterTableLayoutPanel.Controls.Add(this.WriterValueLabel, 0, 0);
            this.WriterTableLayoutPanel.Controls.Add(this.WriterKeyLabel, 0, 0);
            this.WriterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriterTableLayoutPanel.Location = new System.Drawing.Point(3, 183);
            this.WriterTableLayoutPanel.Name = "WriterTableLayoutPanel";
            this.WriterTableLayoutPanel.RowCount = 1;
            this.WriterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WriterTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.WriterTableLayoutPanel.TabIndex = 7;
            // 
            // WriterKeyLabel
            // 
            this.WriterKeyLabel.AutoSize = true;
            this.WriterKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriterKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.WriterKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WriterKeyLabel.Name = "WriterKeyLabel";
            this.WriterKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.WriterKeyLabel.TabIndex = 0;
            this.WriterKeyLabel.Text = "Writer:";
            this.WriterKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WriterValueLabel
            // 
            this.WriterValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriterValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterValueLabel.Location = new System.Drawing.Point(114, 0);
            this.WriterValueLabel.Name = "WriterValueLabel";
            this.WriterValueLabel.Size = new System.Drawing.Size(255, 0);
            this.WriterValueLabel.TabIndex = 2;
            // 
            // ActorsTableLayoutPanel
            // 
            this.ActorsTableLayoutPanel.AutoSize = true;
            this.ActorsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActorsTableLayoutPanel.ColumnCount = 2;
            this.ActorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ActorsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ActorsTableLayoutPanel.Controls.Add(this.ActorsValueLabel, 0, 0);
            this.ActorsTableLayoutPanel.Controls.Add(this.ActorsKeyLabel, 0, 0);
            this.ActorsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsTableLayoutPanel.Location = new System.Drawing.Point(3, 209);
            this.ActorsTableLayoutPanel.Name = "ActorsTableLayoutPanel";
            this.ActorsTableLayoutPanel.RowCount = 1;
            this.ActorsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ActorsTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.ActorsTableLayoutPanel.TabIndex = 8;
            // 
            // ActorsKeyLabel
            // 
            this.ActorsKeyLabel.AutoSize = true;
            this.ActorsKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorsKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.ActorsKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ActorsKeyLabel.Name = "ActorsKeyLabel";
            this.ActorsKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.ActorsKeyLabel.TabIndex = 0;
            this.ActorsKeyLabel.Text = "Actors:";
            this.ActorsKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ActorsValueLabel
            // 
            this.ActorsValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorsValueLabel.Location = new System.Drawing.Point(114, 0);
            this.ActorsValueLabel.Name = "ActorsValueLabel";
            this.ActorsValueLabel.Size = new System.Drawing.Size(255, 0);
            this.ActorsValueLabel.TabIndex = 2;
            // 
            // PlotTableLayoutPanel
            // 
            this.PlotTableLayoutPanel.AutoSize = true;
            this.PlotTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlotTableLayoutPanel.ColumnCount = 2;
            this.PlotTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PlotTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PlotTableLayoutPanel.Controls.Add(this.PlotValueLabel, 0, 0);
            this.PlotTableLayoutPanel.Controls.Add(this.PlotKeyLabel, 0, 0);
            this.PlotTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotTableLayoutPanel.Location = new System.Drawing.Point(3, 235);
            this.PlotTableLayoutPanel.Name = "PlotTableLayoutPanel";
            this.PlotTableLayoutPanel.RowCount = 1;
            this.PlotTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlotTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.PlotTableLayoutPanel.TabIndex = 9;
            // 
            // PlotValueLabel
            // 
            this.PlotValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotValueLabel.Location = new System.Drawing.Point(114, 0);
            this.PlotValueLabel.Name = "PlotValueLabel";
            this.PlotValueLabel.Size = new System.Drawing.Size(255, 0);
            this.PlotValueLabel.TabIndex = 2;
            // 
            // LanguageTableLayoutPanel
            // 
            this.LanguageTableLayoutPanel.AutoSize = true;
            this.LanguageTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LanguageTableLayoutPanel.ColumnCount = 2;
            this.LanguageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LanguageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.LanguageTableLayoutPanel.Controls.Add(this.LanguageValueLabel, 0, 0);
            this.LanguageTableLayoutPanel.Controls.Add(this.LanguageKeyLabel, 0, 0);
            this.LanguageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LanguageTableLayoutPanel.Location = new System.Drawing.Point(3, 261);
            this.LanguageTableLayoutPanel.Name = "LanguageTableLayoutPanel";
            this.LanguageTableLayoutPanel.RowCount = 1;
            this.LanguageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LanguageTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.LanguageTableLayoutPanel.TabIndex = 10;
            // 
            // LanguageValueLabel
            // 
            this.LanguageValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LanguageValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageValueLabel.Location = new System.Drawing.Point(114, 0);
            this.LanguageValueLabel.Name = "LanguageValueLabel";
            this.LanguageValueLabel.Size = new System.Drawing.Size(255, 0);
            this.LanguageValueLabel.TabIndex = 2;
            // 
            // CountryTableLayoutPanel
            // 
            this.CountryTableLayoutPanel.AutoSize = true;
            this.CountryTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CountryTableLayoutPanel.ColumnCount = 2;
            this.CountryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CountryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.CountryTableLayoutPanel.Controls.Add(this.CountryValueLabel, 0, 0);
            this.CountryTableLayoutPanel.Controls.Add(this.CountryKeyLabel, 0, 0);
            this.CountryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountryTableLayoutPanel.Location = new System.Drawing.Point(3, 287);
            this.CountryTableLayoutPanel.Name = "CountryTableLayoutPanel";
            this.CountryTableLayoutPanel.RowCount = 1;
            this.CountryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CountryTableLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.CountryTableLayoutPanel.TabIndex = 11;
            // 
            // CountryValueLabel
            // 
            this.CountryValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountryValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryValueLabel.Location = new System.Drawing.Point(114, 0);
            this.CountryValueLabel.Name = "CountryValueLabel";
            this.CountryValueLabel.Size = new System.Drawing.Size(255, 0);
            this.CountryValueLabel.TabIndex = 2;
            // 
            // InfoLayoutPanel
            // 
            this.InfoLayoutPanel.AutoSize = true;
            this.InfoLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InfoLayoutPanel.ColumnCount = 1;
            this.InfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfoLayoutPanel.Controls.Add(this.CountryTableLayoutPanel, 0, 11);
            this.InfoLayoutPanel.Controls.Add(this.LanguageTableLayoutPanel, 0, 10);
            this.InfoLayoutPanel.Controls.Add(this.PlotTableLayoutPanel, 0, 9);
            this.InfoLayoutPanel.Controls.Add(this.ActorsTableLayoutPanel, 0, 8);
            this.InfoLayoutPanel.Controls.Add(this.WriterTableLayoutPanel, 0, 7);
            this.InfoLayoutPanel.Controls.Add(this.DirectorTableLayoutPanel, 0, 6);
            this.InfoLayoutPanel.Controls.Add(this.GenreTableLayoutPanel, 0, 5);
            this.InfoLayoutPanel.Controls.Add(this.RuntimeTableLayoutPanel, 0, 4);
            this.InfoLayoutPanel.Controls.Add(this.ReleasedTableLayoutPanel, 0, 3);
            this.InfoLayoutPanel.Controls.Add(this.RatedLayoutPanel, 0, 2);
            this.InfoLayoutPanel.Controls.Add(this.TitleName, 0, 0);
            this.InfoLayoutPanel.Controls.Add(this.YearLayoutPanel, 0, 1);
            this.InfoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.InfoLayoutPanel.Location = new System.Drawing.Point(0, 0);
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
            this.InfoLayoutPanel.Size = new System.Drawing.Size(378, 310);
            this.InfoLayoutPanel.TabIndex = 2;
            // 
            // PlotKeyLabel
            // 
            this.PlotKeyLabel.AutoSize = true;
            this.PlotKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.PlotKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PlotKeyLabel.Name = "PlotKeyLabel";
            this.PlotKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.PlotKeyLabel.TabIndex = 0;
            this.PlotKeyLabel.Text = "Plot:";
            this.PlotKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LanguageKeyLabel
            // 
            this.LanguageKeyLabel.AutoSize = true;
            this.LanguageKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LanguageKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.LanguageKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LanguageKeyLabel.Name = "LanguageKeyLabel";
            this.LanguageKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.LanguageKeyLabel.TabIndex = 0;
            this.LanguageKeyLabel.Text = "Language:";
            this.LanguageKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CountryKeyLabel
            // 
            this.CountryKeyLabel.AutoSize = true;
            this.CountryKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountryKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.CountryKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CountryKeyLabel.Name = "CountryKeyLabel";
            this.CountryKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.CountryKeyLabel.TabIndex = 0;
            this.CountryKeyLabel.Text = "Country:";
            this.CountryKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // YearValueLabel
            // 
            this.YearValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearValueLabel.Location = new System.Drawing.Point(114, 0);
            this.YearValueLabel.Name = "YearValueLabel";
            this.YearValueLabel.Size = new System.Drawing.Size(255, 0);
            this.YearValueLabel.TabIndex = 1;
            // 
            // YearLayoutPanel
            // 
            this.YearLayoutPanel.AutoSize = true;
            this.YearLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.YearLayoutPanel.ColumnCount = 2;
            this.YearLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.YearLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.YearLayoutPanel.Controls.Add(this.YearLabelKey, 0, 0);
            this.YearLayoutPanel.Controls.Add(this.YearValueLabel, 1, 0);
            this.YearLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearLayoutPanel.Location = new System.Drawing.Point(3, 27);
            this.YearLayoutPanel.Name = "YearLayoutPanel";
            this.YearLayoutPanel.RowCount = 1;
            this.YearLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.YearLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.YearLayoutPanel.Size = new System.Drawing.Size(372, 20);
            this.YearLayoutPanel.TabIndex = 1;
            // 
            // RatedKeyLabel
            // 
            this.RatedKeyLabel.AutoSize = true;
            this.RatedKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RatedKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatedKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.RatedKeyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.RatedKeyLabel.Name = "RatedKeyLabel";
            this.RatedKeyLabel.Size = new System.Drawing.Size(111, 20);
            this.RatedKeyLabel.TabIndex = 0;
            this.RatedKeyLabel.Text = "Rated:";
            this.RatedKeyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // YearLabelKey
            // 
            this.YearLabelKey.AutoSize = true;
            this.YearLabelKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearLabelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabelKey.Location = new System.Drawing.Point(0, 0);
            this.YearLabelKey.Margin = new System.Windows.Forms.Padding(0);
            this.YearLabelKey.Name = "YearLabelKey";
            this.YearLabelKey.Size = new System.Drawing.Size(111, 20);
            this.YearLabelKey.TabIndex = 0;
            this.YearLabelKey.Text = "Year:";
            this.YearLabelKey.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TitleName
            // 
            this.TitleName.AutoSize = true;
            this.TitleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleName.Location = new System.Drawing.Point(3, 0);
            this.TitleName.Name = "TitleName";
            this.TitleName.Size = new System.Drawing.Size(372, 24);
            this.TitleName.TabIndex = 0;
            this.TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FullInfoMovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FullInfoMovieView";
            this.Text = "FullInfoMovieView";
            this.MainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ScrollPanel.ResumeLayout(false);
            this.ScrollPanel.PerformLayout();
            this.RatedLayoutPanel.ResumeLayout(false);
            this.RatedLayoutPanel.PerformLayout();
            this.ReleasedTableLayoutPanel.ResumeLayout(false);
            this.ReleasedTableLayoutPanel.PerformLayout();
            this.RuntimeTableLayoutPanel.ResumeLayout(false);
            this.RuntimeTableLayoutPanel.PerformLayout();
            this.GenreTableLayoutPanel.ResumeLayout(false);
            this.GenreTableLayoutPanel.PerformLayout();
            this.DirectorTableLayoutPanel.ResumeLayout(false);
            this.DirectorTableLayoutPanel.PerformLayout();
            this.WriterTableLayoutPanel.ResumeLayout(false);
            this.WriterTableLayoutPanel.PerformLayout();
            this.ActorsTableLayoutPanel.ResumeLayout(false);
            this.ActorsTableLayoutPanel.PerformLayout();
            this.PlotTableLayoutPanel.ResumeLayout(false);
            this.PlotTableLayoutPanel.PerformLayout();
            this.LanguageTableLayoutPanel.ResumeLayout(false);
            this.LanguageTableLayoutPanel.PerformLayout();
            this.CountryTableLayoutPanel.ResumeLayout(false);
            this.CountryTableLayoutPanel.PerformLayout();
            this.InfoLayoutPanel.ResumeLayout(false);
            this.InfoLayoutPanel.PerformLayout();
            this.YearLayoutPanel.ResumeLayout(false);
            this.YearLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Panel ScrollPanel;
        private System.Windows.Forms.TableLayoutPanel InfoLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CountryTableLayoutPanel;
        private AutoResizingLabel CountryValueLabel;
        private System.Windows.Forms.Label CountryKeyLabel;
        private System.Windows.Forms.TableLayoutPanel LanguageTableLayoutPanel;
        private AutoResizingLabel LanguageValueLabel;
        private System.Windows.Forms.Label LanguageKeyLabel;
        private System.Windows.Forms.TableLayoutPanel PlotTableLayoutPanel;
        private AutoResizingLabel PlotValueLabel;
        private System.Windows.Forms.Label PlotKeyLabel;
        private System.Windows.Forms.TableLayoutPanel ActorsTableLayoutPanel;
        private AutoResizingLabel ActorsValueLabel;
        private System.Windows.Forms.Label ActorsKeyLabel;
        private System.Windows.Forms.TableLayoutPanel WriterTableLayoutPanel;
        private AutoResizingLabel WriterValueLabel;
        private System.Windows.Forms.Label WriterKeyLabel;
        private System.Windows.Forms.TableLayoutPanel DirectorTableLayoutPanel;
        private AutoResizingLabel DirectorValueLabel;
        private System.Windows.Forms.Label DirectorKeyLabel;
        private System.Windows.Forms.TableLayoutPanel GenreTableLayoutPanel;
        private AutoResizingLabel GenreValueLabel;
        private System.Windows.Forms.Label GenreKeyLabel;
        private System.Windows.Forms.TableLayoutPanel RuntimeTableLayoutPanel;
        private AutoResizingLabel RuntimeValueLabel;
        private System.Windows.Forms.Label RuntimeKeyLabel;
        private System.Windows.Forms.TableLayoutPanel ReleasedTableLayoutPanel;
        private AutoResizingLabel ReleasedValueLabel;
        private System.Windows.Forms.Label ReleasedKeyLabel;
        private System.Windows.Forms.TableLayoutPanel RatedLayoutPanel;
        private AutoResizingLabel RatedValueLabel;
        private System.Windows.Forms.TableLayoutPanel YearLayoutPanel;
        private AutoResizingLabel YearValueLabel;
        private System.Windows.Forms.Label RatedKeyLabel;
        private System.Windows.Forms.Label TitleName;
        private System.Windows.Forms.Label YearLabelKey;
    }
}