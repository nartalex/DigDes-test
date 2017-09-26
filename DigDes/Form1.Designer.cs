namespace DigDes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sourcePreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageHorSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.generateAsciiButton = new System.Windows.Forms.Button();
            this.horizontalSizeRadio = new System.Windows.Forms.RadioButton();
            this.verticalSizeRadio = new System.Windows.Forms.RadioButton();
            this.imageVerSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHorSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVerSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(26, 21);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(129, 27);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Открыть файл";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sourcePreview
            // 
            this.sourcePreview.Location = new System.Drawing.Point(435, 21);
            this.sourcePreview.Name = "sourcePreview";
            this.sourcePreview.Size = new System.Drawing.Size(300, 300);
            this.sourcePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourcePreview.TabIndex = 1;
            this.sourcePreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер ASCII изображения:";
            // 
            // imageHorSizeUpDown
            // 
            this.imageHorSizeUpDown.Location = new System.Drawing.Point(156, 115);
            this.imageHorSizeUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.imageHorSizeUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.imageHorSizeUpDown.Name = "imageHorSizeUpDown";
            this.imageHorSizeUpDown.Size = new System.Drawing.Size(52, 23);
            this.imageHorSizeUpDown.TabIndex = 3;
            this.imageHorSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imageHorSizeUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // generateAsciiButton
            // 
            this.generateAsciiButton.Enabled = false;
            this.generateAsciiButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateAsciiButton.Location = new System.Drawing.Point(26, 274);
            this.generateAsciiButton.Name = "generateAsciiButton";
            this.generateAsciiButton.Size = new System.Drawing.Size(182, 47);
            this.generateAsciiButton.TabIndex = 4;
            this.generateAsciiButton.Text = "Сгенерировать";
            this.generateAsciiButton.UseVisualStyleBackColor = true;
            this.generateAsciiButton.Click += new System.EventHandler(this.generateAsciiButton_Click);
            // 
            // horizontalSizeRadio
            // 
            this.horizontalSizeRadio.AutoSize = true;
            this.horizontalSizeRadio.Checked = true;
            this.horizontalSizeRadio.Location = new System.Drawing.Point(27, 115);
            this.horizontalSizeRadio.Name = "horizontalSizeRadio";
            this.horizontalSizeRadio.Size = new System.Drawing.Size(114, 19);
            this.horizontalSizeRadio.TabIndex = 5;
            this.horizontalSizeRadio.TabStop = true;
            this.horizontalSizeRadio.Text = "По горизонтали";
            this.horizontalSizeRadio.UseVisualStyleBackColor = true;
            this.horizontalSizeRadio.CheckedChanged += new System.EventHandler(this.horizontalSizeRadio_CheckedChanged);
            // 
            // verticalSizeRadio
            // 
            this.verticalSizeRadio.AutoSize = true;
            this.verticalSizeRadio.Location = new System.Drawing.Point(27, 155);
            this.verticalSizeRadio.Name = "verticalSizeRadio";
            this.verticalSizeRadio.Size = new System.Drawing.Size(101, 19);
            this.verticalSizeRadio.TabIndex = 7;
            this.verticalSizeRadio.Text = "По вертикали";
            this.verticalSizeRadio.UseVisualStyleBackColor = true;
            this.verticalSizeRadio.CheckedChanged += new System.EventHandler(this.verticalSizeRadio_CheckedChanged);
            // 
            // imageVerSizeUpDown
            // 
            this.imageVerSizeUpDown.Enabled = false;
            this.imageVerSizeUpDown.Location = new System.Drawing.Point(156, 155);
            this.imageVerSizeUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.imageVerSizeUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.imageVerSizeUpDown.Name = "imageVerSizeUpDown";
            this.imageVerSizeUpDown.Size = new System.Drawing.Size(52, 23);
            this.imageVerSizeUpDown.TabIndex = 6;
            this.imageVerSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imageVerSizeUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(467, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Откройте файл по кнопке слева\r\nПредпросмотр будет тут";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.generateAsciiButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verticalSizeRadio);
            this.Controls.Add(this.imageVerSizeUpDown);
            this.Controls.Add(this.horizontalSizeRadio);
            this.Controls.Add(this.generateAsciiButton);
            this.Controls.Add(this.imageHorSizeUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourcePreview);
            this.Controls.Add(this.openFileButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BitmapToASCII";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHorSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVerSizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox sourcePreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown imageHorSizeUpDown;
        private System.Windows.Forms.Button generateAsciiButton;
        private System.Windows.Forms.RadioButton horizontalSizeRadio;
        private System.Windows.Forms.RadioButton verticalSizeRadio;
        private System.Windows.Forms.NumericUpDown imageVerSizeUpDown;
        private System.Windows.Forms.Label label2;
    }
}

