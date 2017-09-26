using System;
using System.Drawing;
using System.Text;
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

        //Символы, сортированные по степени заполнения: от более темного к пробелу
        private string[] AsciiChars = { "@", "#", "8", "&", "a", "o", "*", ":", "-", ".", " " };

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                //Показываем только избранный список форматов
                Filter = "Изображения|*.jpg;*.jpeg;*.bmp;*.png;*gif"
            };

            //Если файл выбран, показываем его в программе и включаем кнопку
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                source = new Bitmap(dialog.FileName);
                sourcePreview.Image = source;
                generateAsciiButton.Enabled = true;
                label2.Hide();
            }
        }

        private void generateAsciiButton_Click(object sender, EventArgs e)
        {
            //Сначала генерируется новое изображение, размером меньшее, чем исходник
            //с расчетом на то, что один пиксель будет соответствовать одному символу ASCII
            //Высчитываем пропорции и, в зависимости от выбранных параметров, считаем размер нового изображения
            double ratio = (double)source.Width / source.Height;
            int width = horizontalSizeRadio.Checked
                ? (int)imageHorSizeUpDown.Value
                : (int)Math.Round((int)imageVerSizeUpDown.Value / ratio);
            int height = verticalSizeRadio.Checked
                ? (int)imageVerSizeUpDown.Value
                : (int)Math.Round((int)imageHorSizeUpDown.Value / ratio);
            //MessageBox.Show($"Old res: {source.Width} : {source.Height} \r\nNew res: {width} : {height}");

            //Генерация нового изображения
            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.Clear(Color.White);                           //нужно для корректной обработки прозрачности
                g.DrawImage(source, 0, 0, width, height);
                g.Dispose();
            }

            StringBuilder str = new StringBuilder();
            //Делаем рисунок
            //Обрабатываем только четные строки, иначе изображение будет сильно вытянуто по вертикали 
            for (int h = 0; h < resized.Height; h += 2)
            {
                for (int w = 0; w < resized.Width; w++)
                {
                    //Считаем интенсивность серого цвета в пикселе
                    Color pixelColor = resized.GetPixel(w, h);
                    int grayColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    str.Append(AsciiChars[grayColor * 10 / 255]);
                }

                //Добавляем перенос строки в конце каждой линии
                str.Append("\r\n");
            }

            ResultForm resultForm = new ResultForm(str.ToString(), resized.Width, resized.Height);
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
