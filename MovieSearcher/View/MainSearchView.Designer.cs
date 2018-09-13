namespace MovieSearcher.View
{
    partial class MainSearchView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPartTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.MoreButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.LeftPartTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LeftPartTableLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LeftPartTableLayoutPanel
            // 
            this.LeftPartTableLayoutPanel.ColumnCount = 1;
            this.LeftPartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftPartTableLayoutPanel.Controls.Add(this.SearchButton, 0, 0);
            this.LeftPartTableLayoutPanel.Controls.Add(this.ResultsListBox, 0, 2);
            this.LeftPartTableLayoutPanel.Controls.Add(this.SearchTextBox, 0, 1);
            this.LeftPartTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPartTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPartTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPartTableLayoutPanel.Name = "LeftPartTableLayoutPanel";
            this.LeftPartTableLayoutPanel.RowCount = 3;
            this.LeftPartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LeftPartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LeftPartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftPartTableLayoutPanel.Size = new System.Drawing.Size(300, 461);
            this.LeftPartTableLayoutPanel.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(0, 0);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(300, 30);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.IntegralHeight = false;
            this.ResultsListBox.Location = new System.Drawing.Point(3, 63);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(294, 395);
            this.ResultsListBox.TabIndex = 1;
            this.ResultsListBox.SelectedIndexChanged += new System.EventHandler(this.ResultsListBox_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTextBox.Location = new System.Drawing.Point(0, 30);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(300, 20);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.MoviePictureBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MoreButton, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(303, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(378, 455);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviePictureBox.Location = new System.Drawing.Point(0, 0);
            this.MoviePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(378, 425);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // MoreButton
            // 
            this.MoreButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MoreButton.Location = new System.Drawing.Point(300, 428);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(75, 23);
            this.MoreButton.TabIndex = 1;
            this.MoreButton.Text = "More...";
            this.MoreButton.UseVisualStyleBackColor = true;
            this.MoreButton.Visible = false;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // MainSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainSearchView";
            this.Text = "MainSearchForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.LeftPartTableLayoutPanel.ResumeLayout(false);
            this.LeftPartTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel LeftPartTableLayoutPanel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Button MoreButton;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}