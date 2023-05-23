using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace Metafile.Handler
{
    class Program
    {
        static int width = 800;
        static int height = 450;
        static int sleepTime = 2000;
        private static EventWaitHandle _imageAvailableEvent;

        static void Main()
        {
            _imageAvailableEvent = new EventWaitHandle(false, EventResetMode.AutoReset, "ImageAvailableEvent");

            while (true)
            {
                GenerateAndSaveImage();
                Thread.Sleep(sleepTime);
            }
        }

        static void GenerateAndSaveImage()
        {
            var b = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(b))
            {
                g.Clear(Color.White);

                using (Pen pen = new Pen(Color.Black, 1))
                {
                    for (int i = 0; i < Random.Shared.Next(5, 15); i++)
                    {
                        var randomValue = Random.Shared.Next(3, 7);

                        int maxRadius = Math.Min((width / 2) - 1, (height / 2) - 1);
                        int radius = Random.Shared.Next(10, maxRadius);

                        int x = Random.Shared.Next(radius, width - radius);
                        int y = Random.Shared.Next(radius, height - radius);
                        Point center = new Point(x, y);

                        DrawPolygonWithSides(center, radius, randomValue, g, pen, width, height);
                    }
                }
            }

            try
            {
                b.Save("MatafileHandler.png", ImageFormat.Png);
                b.Save("MatafileHandler.emf", ImageFormat.Emf);
                b.Dispose();

                Console.WriteLine("Metafile successfully updated!");
            }
            finally
            {
                _imageAvailableEvent.Set();
            }
        }

        static void DrawPolygonWithSides(Point center, int radius, int sides, Graphics g, Pen pen, int imageWidth, int imageHeight)
        {
            PointF[] polygonPoints = new PointF[sides];

            double angle = 2 * Math.PI / sides;
            double rotation = Math.PI / 2;

            for (int i = 0; i < sides; i++)
            {
                double currentAngle = i * angle + rotation;
                float x = (float)(center.X + radius * Math.Cos(currentAngle));
                float y = (float)(center.Y + radius * Math.Sin(currentAngle));
                x = Math.Max(0, Math.Min(x, imageWidth - 1));
                y = Math.Max(0, Math.Min(y, imageHeight - 1));

                polygonPoints[i] = new PointF(x, y);
            }

            g.DrawPolygon(pen, polygonPoints);
        }
    }
}
