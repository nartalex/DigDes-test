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
            this.Width = textWidth * 10;
            this.Height = textHeight * 10;

            ToolTip tip = new ToolTip();
            tip.SetToolTip(copyButton, "Скопировать в буфер обмена");
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(text);
        }
    }
}
