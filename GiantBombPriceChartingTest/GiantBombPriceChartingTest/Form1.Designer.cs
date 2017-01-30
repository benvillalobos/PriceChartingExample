namespace GiantBombPriceChartingTest
{
    partial class Form1
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
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ListOfGames = new System.Windows.Forms.ListBox();
            this.BoxArt = new System.Windows.Forms.PictureBox();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.BoxArt)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(220, 28);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(100, 20);
            this.SearchBar.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(231, 54);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListOfGames
            // 
            this.ListOfGames.FormattingEnabled = true;
            this.ListOfGames.Location = new System.Drawing.Point(57, 275);
            this.ListOfGames.Name = "ListOfGames";
            this.ListOfGames.Size = new System.Drawing.Size(178, 160);
            this.ListOfGames.TabIndex = 2;
            // 
            // BoxArt
            // 
            this.BoxArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoxArt.Location = new System.Drawing.Point(-2, -3);
            this.BoxArt.Name = "BoxArt";
            this.BoxArt.Size = new System.Drawing.Size(564, 438);
            this.BoxArt.TabIndex = 3;
            this.BoxArt.TabStop = false;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Location = new System.Drawing.Point(243, 9);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(54, 13);
            this.LoadingLabel.TabIndex = 4;
            this.LoadingLabel.Text = "Loading...";
            this.LoadingLabel.Visible = false;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(264, 162);
            this.DescriptionBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(261, 273);
            this.DescriptionBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 432);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.ListOfGames);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.BoxArt);
            this.Name = "Form1";
            this.Text = "PriceCharting / GiantBomb";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox ListOfGames;
        private System.Windows.Forms.PictureBox BoxArt;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.WebBrowser DescriptionBox;
    }
}

