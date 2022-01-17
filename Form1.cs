using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tw.Edu.Fotech.Fotech2F;

namespace Fotech2FSample
{
    public partial class Form1 : Form
    {
        private readonly ItemSelectDialog openCameraDialog = new ItemSelectDialog();
        private readonly VideoCapture videoCapture = VideoCapture.GetInstance();
        private readonly IFrameProcessor<double> asdkmm5050Processor = new Asdkmm5050Processor();

        public Form1()
        {
            InitializeComponent();
        }

        private void openImage_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                // Open Image
            }
        }

        private void openVideo_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (openVideoDialog.ShowDialog() == DialogResult.OK)
            {
                // Open Video
                if (videoCapture.Open(openVideoDialog.FileName))
                {
                    timer1.Interval = (int)(1000 / videoCapture.FPS);
                    trackBar1.Maximum = videoCapture.FrameCount;
                    showFrameStatus();
                }
                else
                {
                    MessageBox.Show("Failed to open video!");
                }
            }
        }

        private void openCamera_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var cameraList = GetCameraList();
            openCameraDialog.Items = cameraList;
            if (openCameraDialog.ShowDialog() == DialogResult.OK)
                // Open Camera
                if (videoCapture.Open(int.Parse(openCameraDialog.SelectedItem.ToString())))
                {
                    timer1.Interval = 1000 / 60;
                    trackBar1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Failed to open camera!");
                }
        }

        private List<string> GetCameraList()
        {
            int cameraCount = VideoCapture.GetCameraCount();
            var nums = new List<string>();
            for (int i = 0; i < cameraCount; ++i)
            {
                nums.Add(i.ToString());
            }

            return nums;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showFrameStatus();
            if (videoCapture.MoveNext())
            {
                var startTime = DateTime.Now;

                var b = videoCapture.Current?.Bitmap;
                pictureBox1.Image = b;

                var fv = asdkmm5050Processor.Process(videoCapture.Current);
                focusValue.Text = $@"Focus Value: {fv}";

                var spentTime = DateTime.Now - startTime;
                fpsValue.Text = $@"FPS: {1000 / spentTime.TotalMilliseconds}";
            }
            else
            {
                timer1.Stop();

                timerStatus.Text = timer1.Enabled.ToString();
            }
        }

        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            timerStatus.Text = timer1.Enabled.ToString();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            videoCapture.SetCurrentFramePosition(0);

            timerStatus.Text = timer1.Enabled.ToString();
        }

        private void showFrameStatus()
        {
            frameStatus.Text = $@"{videoCapture.CurrentFramePosition}/{videoCapture.FrameCount}";
            if (trackBar1.Enabled)
            {
                trackBar1.Value = videoCapture.CurrentFramePosition;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            videoCapture.SetCurrentFramePosition(trackBar1.Value);
            timer1_Tick(sender, e);
        }
    }
}