using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigDes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap source;
        private string[] AsciiChars = { "@", "#", "8", "&", "a", "o", "*", ":", "-", ".", "&nbsp;" };

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Изображения|*.jpg;*.jpeg;*.bmp;*.png;*gif"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                source = new Bitmap(dialog.FileName);
                sourcePreview.Image = source;
                generateAsciiButton.Enabled = true;
            }
        }

        private void generateAsciiButton_Click(object sender, EventArgs e)
        {
            double ratio = (double)source.Width / source.Height;
            int width = horizontalSizeRadio.Checked
                ? (int)imageHorSizeUpDown.Value
                : (int)Math.Round((int)imageVerSizeUpDown.Value / ratio);
            int height = verticalSizeRadio.Checked
                ? (int)imageVerSizeUpDown.Value
                : (int)Math.Round((int)imageHorSizeUpDown.Value / ratio);
            //MessageBox.Show($"Old res: {source.Width} : {source.Height} \r\nNew res: {width} : {height}");

            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(source, 0, 0, width, height);
                g.Dispose();
            }

            StringBuilder str = new StringBuilder();
            for (int h = 0; h < resized.Height; h += 2)
            {
                for (int w = 0; w < resized.Width; w++)
                {
                    Color pixelColor = resized.GetPixel(w, h);
                    int grayColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    str.Append(AsciiChars[grayColor * 10 / 255]);
                }
                str.Append("<br>");
            }
            ResultForm resultForm = new ResultForm(str.ToString());
            resultForm.Show();
        }

        private void horizontalSizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            imageHorSizeUpDown.Enabled = horizontalSizeRadio.Checked;
        }

        private void verticalSizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            imageVerSizeUpDown.Enabled = verticalSizeRadio.Checked;
        }
    }
}
