using System;
using System.Windows.Forms;

namespace DigDes
{
    public partial class ResultForm : Form
    {
        string text;

        public ResultForm(string asciiText, int textWidth, int textHeight)
        {
            InitializeComponent();
            //Чтобы корректно обработать рисунок, используем браузер и ставим теги PRE
            webBrowser1.DocumentText = "<pre>" + asciiText + "</pre>";

            text = asciiText;

            //Изменение размеров окна соответственно рисунку
            this.Width = textWidth * 9;
            this.Height = textHeight * 9;

            ToolTip tip = new ToolTip();
            tip.SetToolTip(copyButton, "Скопировать в буфер обмена");
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(text);
        }
    }
}
