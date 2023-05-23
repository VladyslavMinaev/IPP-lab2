using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace Merafile.Reader
{
    public partial class Form1 : Form
    {
        private readonly string _filePath = @"I:\lb2\Metafile.FiguresCreator\bin\Debug\net6.0\MatafileHandler.emf";
        private EventWaitHandle _imageAvailableEvent;
        private int _counter;

        public Form1()
        {
            InitializeComponent();
            _counter = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _imageAvailableEvent = EventWaitHandle.OpenExisting("ImageAvailableEvent");
            var imageLoadThread = new Thread(LoadImagePeriodically);
            imageLoadThread.Start();
        }

        private void LoadImagePeriodically()
        {
            while (true)
            {
                _imageAvailableEvent.WaitOne();
                LoadImage();
            }
        }

        private void LoadImage()
        {
            try
            {
                using (var i = Image.FromFile(_filePath, true))
                {
                    pictureBox1.Image = new Bitmap(i);
                    detailsRichTextBox.Text = detailsRichTextBox.Text += $"Metafile snapshot #{_counter}\n";
                    _counter += 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }

        private void stopProcessButton_Click(object sender, EventArgs e)
        {
            _imageAvailableEvent.Dispose();
            Close();
        }
    }
}
