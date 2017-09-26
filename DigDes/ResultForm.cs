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
        public ResultForm(string asciiText, int textWidth, int textHeight)
        {
            InitializeComponent();
            //Чтобы корректно обработать рисунок, используем браузер и ставим теги PRE
            webBrowser1.DocumentText = "<pre>" + asciiText + "</pre>";

            //Изменение размеров окна соответственно рисунку
            this.Width = textWidth * 9;
            this.Height = textHeight * 9;
        }
    }
}
