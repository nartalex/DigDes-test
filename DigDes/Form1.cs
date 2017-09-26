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

        Bitmap source;

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
            MessageBox.Show($"Old res: {source.Width} : {source.Height} \r\nNew res: {width} : {height}");


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
