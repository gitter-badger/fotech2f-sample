
using System.Windows.Forms;

namespace Fotech2FSample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.openCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.openVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.playPauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.frameStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.focusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.fpsValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVideo,
            this.openCamera});
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.開啟ToolStripMenuItem.Text = "開啟...";
            // 
            // openVideo
            // 
            this.openVideo.Name = "openVideo";
            this.openVideo.Size = new System.Drawing.Size(315, 40);
            this.openVideo.Text = "影片";
            this.openVideo.Click += new System.EventHandler(this.openVideo_Click);
            // 
            // openCamera
            // 
            this.openCamera.Name = "openCamera";
            this.openCamera.Size = new System.Drawing.Size(315, 40);
            this.openCamera.Text = "相機";
            this.openCamera.Click += new System.EventHandler(this.openCamera_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1252, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Image(JPG)|*.jpg|All files(*.*)|*.*";
            // 
            // openVideoDialog
            // 
            this.openVideoDialog.Filter = "Video(MP4)|*.mp4|All files(*.*)|*.*";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(191, 682);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1054, 80);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // playPauseBtn
            // 
            this.playPauseBtn.Location = new System.Drawing.Point(12, 661);
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.Size = new System.Drawing.Size(137, 43);
            this.playPauseBtn.TabIndex = 3;
            this.playPauseBtn.Text = "Play/Pause";
            this.playPauseBtn.UseVisualStyleBackColor = true;
            this.playPauseBtn.Click += new System.EventHandler(this.playPauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(12, 709);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(137, 43);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerStatus,
            this.frameStatus,
            this.focusValue,
            this.fpsValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 780);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1276, 39);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerStatus
            // 
            this.timerStatus.Name = "timerStatus";
            this.timerStatus.Size = new System.Drawing.Size(54, 30);
            this.timerStatus.Text = "Stop";
            // 
            // frameStatus
            // 
            this.frameStatus.Name = "frameStatus";
            this.frameStatus.Size = new System.Drawing.Size(43, 30);
            this.frameStatus.Text = "0/0";
            // 
            // focusValue
            // 
            this.focusValue.Name = "focusValue";
            this.focusValue.Size = new System.Drawing.Size(138, 30);
            this.focusValue.Text = "FocusValue: 0";
            // 
            // fpsValue
            // 
            this.fpsValue.Name = "fpsValue";
            this.fpsValue.Size = new System.Drawing.Size(68, 30);
            this.fpsValue.Text = "FPS: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 819);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playPauseBtn);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 開啟ToolStripMenuItem;
        private ToolStripMenuItem openVideo;
        private ToolStripMenuItem openCamera;
        private PictureBox pictureBox1;
        private OpenFileDialog openImageDialog;
        private OpenFileDialog openVideoDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Timer timer1;
        private TrackBar trackBar1;
        private Button playPauseBtn;
        private Button stopBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel timerStatus;
        private ToolStripStatusLabel frameStatus;
        private ToolStripStatusLabel focusValue;
        private ToolStripStatusLabel fpsValue;
    }
}

