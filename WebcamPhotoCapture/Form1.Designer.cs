namespace WebcamPhotoCapture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbCameraList = new ComboBox();
            btnStart = new Button();
            btnCapture = new Button();
            btnSaveImage = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pbWebcam = new PictureBox();
            pbCapture = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWebcam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCapture).BeginInit();
            SuspendLayout();
            // 
            // cbCameraList
            // 
            cbCameraList.FormattingEnabled = true;
            cbCameraList.Location = new Point(12, 12);
            cbCameraList.Name = "cbCameraList";
            cbCameraList.Size = new Size(221, 23);
            cbCameraList.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(239, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(320, 12);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(75, 23);
            btnCapture.TabIndex = 2;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(401, 12);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(75, 23);
            btnSaveImage.TabIndex = 3;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pbWebcam, 0, 0);
            tableLayoutPanel1.Controls.Add(pbCapture, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1006, 385);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pbWebcam
            // 
            pbWebcam.BorderStyle = BorderStyle.FixedSingle;
            pbWebcam.Dock = DockStyle.Fill;
            pbWebcam.Location = new Point(3, 3);
            pbWebcam.Name = "pbWebcam";
            pbWebcam.Size = new Size(497, 379);
            pbWebcam.SizeMode = PictureBoxSizeMode.Zoom;
            pbWebcam.TabIndex = 0;
            pbWebcam.TabStop = false;
            // 
            // pbCapture
            // 
            pbCapture.BorderStyle = BorderStyle.FixedSingle;
            pbCapture.Dock = DockStyle.Fill;
            pbCapture.Location = new Point(506, 3);
            pbCapture.Name = "pbCapture";
            pbCapture.Size = new Size(497, 379);
            pbCapture.SizeMode = PictureBoxSizeMode.Zoom;
            pbCapture.TabIndex = 1;
            pbCapture.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnSaveImage);
            Controls.Add(btnCapture);
            Controls.Add(btnStart);
            Controls.Add(cbCameraList);
            Name = "Form1";
            Text = "WebCam Photo Capture";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbWebcam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCapture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbCameraList;
        private Button btnStart;
        private Button btnCapture;
        private Button btnSaveImage;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbWebcam;
        private PictureBox pbCapture;
    }
}
