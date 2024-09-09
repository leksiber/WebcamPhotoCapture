using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;

namespace WebcamPhotoCapture
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice videoSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo captureDevice in captureDevices)
            {
                cbCameraList.Items.Add(captureDevice.Name);
            }
            cbCameraList.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pbWebcam.Image = null;
                pbWebcam.Invalidate();
            }
            videoSource = new VideoCaptureDevice(captureDevices[cbCameraList.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbWebcam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pbWebcam.Image = null;
                pbWebcam.Invalidate();
                pbCapture.Image = null;
                pbCapture.Invalidate();
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            pbCapture.Image = (Bitmap)pbWebcam.Image.Clone();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image As";
            saveFileDialog.Filter = "Image Files (*.jpg, *.png) | *.jpg, *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                }
                pbCapture.Image.Save(saveFileDialog.FileName, imageFormat);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tableLayoutPanel1.Width = this.Width - 40;
            tableLayoutPanel1.Height = this.Height - 120;
        }
    }
}
