namespace AudioPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonAddSong = new System.Windows.Forms.Button();
            this.listBoxSongDisplay = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(206, 0);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(540, 564);
            this.windowsMediaPlayer.TabIndex = 0;
            // 
            // buttonAddSong
            // 
            this.buttonAddSong.BackColor = System.Drawing.Color.Tomato;
            this.buttonAddSong.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSong.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddSong.Location = new System.Drawing.Point(5, 469);
            this.buttonAddSong.Name = "buttonAddSong";
            this.buttonAddSong.Size = new System.Drawing.Size(195, 95);
            this.buttonAddSong.TabIndex = 2;
            this.buttonAddSong.Text = "Add Song";
            this.buttonAddSong.UseVisualStyleBackColor = false;
            this.buttonAddSong.Click += new System.EventHandler(this.buttonAddSong_Click);
            // 
            // listBoxSongDisplay
            // 
            this.listBoxSongDisplay.BackColor = System.Drawing.Color.LightCoral;
            this.listBoxSongDisplay.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.listBoxSongDisplay.FormattingEnabled = true;
            this.listBoxSongDisplay.ItemHeight = 20;
            this.listBoxSongDisplay.Location = new System.Drawing.Point(8, 4);
            this.listBoxSongDisplay.Name = "listBoxSongDisplay";
            this.listBoxSongDisplay.Size = new System.Drawing.Size(192, 464);
            this.listBoxSongDisplay.TabIndex = 0;
            this.listBoxSongDisplay.SelectedIndexChanged += new System.EventHandler(this.listBoxSongDisplay_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 564);
            this.Controls.Add(this.listBoxSongDisplay);
            this.Controls.Add(this.buttonAddSong);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(440, 200);
            this.Name = "MainForm";
            this.Text = "Audio Player";
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Button buttonAddSong;
        private System.Windows.Forms.ListBox listBoxSongDisplay;
    }
}

