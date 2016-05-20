namespace _3.Interface_Layer
{
    partial class MusicPlayerMainForm
    {/// <summary>
     /// Required designer variable.
     /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerMainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDisplayPlaylist = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tlpMaster = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scramblePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlaying = new System.Windows.Forms.Label();
            this.lbCurrentPlaylist = new System.Windows.Forms.ListBox();
            this.tlpControls.SuspendLayout();
            this.tlpMaster.SuspendLayout();
            this.tlpPlayer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 6;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpControls.Controls.Add(this.btnOpen, 0, 0);
            this.tlpControls.Controls.Add(this.btnNext, 5, 0);
            this.tlpControls.Controls.Add(this.btnStop, 4, 0);
            this.tlpControls.Controls.Add(this.btnPlay, 3, 0);
            this.tlpControls.Controls.Add(this.btnPrevious, 2, 0);
            this.tlpControls.Controls.Add(this.btnDisplayPlaylist, 1, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(0, 227);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Size = new System.Drawing.Size(309, 32);
            this.tlpControls.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOpen.BackColor = System.Drawing.Color.Silver;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(3, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(45, 25);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNext.BackColor = System.Drawing.Color.Silver;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(258, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 25);
            this.btnNext.TabIndex = 7;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStop.BackColor = System.Drawing.Color.Silver;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(207, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 25);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPlay.BackColor = System.Drawing.Color.Silver;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(156, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(45, 25);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.BackColor = System.Drawing.Color.Silver;
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(105, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 25);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnDisplayPlaylist
            // 
            this.btnDisplayPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDisplayPlaylist.BackColor = System.Drawing.Color.Silver;
            this.btnDisplayPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayPlaylist.Image = global::_3.Interface_Layer.Properties.Resources.playlist;
            this.btnDisplayPlaylist.Location = new System.Drawing.Point(54, 3);
            this.btnDisplayPlaylist.Name = "btnDisplayPlaylist";
            this.btnDisplayPlaylist.Size = new System.Drawing.Size(45, 25);
            this.btnDisplayPlaylist.TabIndex = 8;
            this.btnDisplayPlaylist.UseVisualStyleBackColor = false;
            this.btnDisplayPlaylist.Click += new System.EventHandler(this.btnDisplayPlaylist_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tlpMaster
            // 
            this.tlpMaster.ColumnCount = 2;
            this.tlpMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tlpMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaster.Controls.Add(this.tlpPlayer, 1, 0);
            this.tlpMaster.Controls.Add(this.lbCurrentPlaylist, 0, 0);
            this.tlpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaster.Location = new System.Drawing.Point(0, 0);
            this.tlpMaster.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMaster.Name = "tlpMaster";
            this.tlpMaster.RowCount = 1;
            this.tlpMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaster.Size = new System.Drawing.Size(309, 259);
            this.tlpMaster.TabIndex = 1;
            // 
            // tlpPlayer
            // 
            this.tlpPlayer.ColumnCount = 1;
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayer.Controls.Add(this.menuStrip1, 0, 0);
            this.tlpPlayer.Controls.Add(this.tlpControls, 0, 3);
            this.tlpPlayer.Controls.Add(this.lblPlaying, 0, 2);
            this.tlpPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlayer.Location = new System.Drawing.Point(0, 0);
            this.tlpPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPlayer.Name = "tlpPlayer";
            this.tlpPlayer.RowCount = 4;
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpPlayer.Size = new System.Drawing.Size(309, 259);
            this.tlpPlayer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playlistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPlaylistToolStripMenuItem,
            this.savePlaylistToolStripMenuItem,
            this.scramblePlaylistToolStripMenuItem});
            this.playlistToolStripMenuItem.Enabled = false;
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // loadPlaylistToolStripMenuItem
            // 
            this.loadPlaylistToolStripMenuItem.Name = "loadPlaylistToolStripMenuItem";
            this.loadPlaylistToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadPlaylistToolStripMenuItem.Text = "Load Playlist";
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save Playlist";
            // 
            // scramblePlaylistToolStripMenuItem
            // 
            this.scramblePlaylistToolStripMenuItem.Name = "scramblePlaylistToolStripMenuItem";
            this.scramblePlaylistToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.scramblePlaylistToolStripMenuItem.Text = "Scramble Playlist";
            // 
            // lblPlaying
            // 
            this.lblPlaying.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Location = new System.Drawing.Point(3, 210);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(0, 13);
            this.lblPlaying.TabIndex = 1;
            // 
            // lbCurrentPlaylist
            // 
            this.lbCurrentPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrentPlaylist.FormattingEnabled = true;
            this.lbCurrentPlaylist.Location = new System.Drawing.Point(3, 3);
            this.lbCurrentPlaylist.Name = "lbCurrentPlaylist";
            this.lbCurrentPlaylist.Size = new System.Drawing.Size(1, 253);
            this.lbCurrentPlaylist.TabIndex = 1;
            this.lbCurrentPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCurrentPlaylist_DoubleClick);
            // 
            // MusicPlayerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(309, 259);
            this.Controls.Add(this.tlpMaster);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MusicPlayerMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Music Player";
            this.tlpControls.ResumeLayout(false);
            this.tlpControls.PerformLayout();
            this.tlpMaster.ResumeLayout(false);
            this.tlpPlayer.ResumeLayout(false);
            this.tlpPlayer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TableLayoutPanel tlpMaster;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer;
        private System.Windows.Forms.Button btnDisplayPlaylist;
        private System.Windows.Forms.Label lblPlaying;
        private System.Windows.Forms.ListBox lbCurrentPlaylist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scramblePlaylistToolStripMenuItem;
    }
}

